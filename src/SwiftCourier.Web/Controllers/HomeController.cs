﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SwiftCourier.Web.Data;
using Microsoft.AspNetCore.Authorization;
using SwiftCourier.Web.Models.Enums;

namespace SwiftCourier.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public HomeController(
            UserManager<User> userManager, ApplicationDbContext context) : base(userManager, context)
        {
        }

        //[Authorize(Policy = "HasPermission")]
        public IActionResult Index()
        {
            var countCustomers = _context.Customers.Count();
            ViewData["countCustomers"] = countCustomers;

            var countBookings = _context.Bookings.Count();
            ViewData["countBookings"] = countBookings;

            var countBookingsToday = _context.Bookings.Where(b => b.CreatedAt.Date.Equals(DateTime.Now.Date)).Count();
            ViewData["countBookingsToday"] = countBookingsToday;

            var startOfWeek = DateTime.Now.Date;
            while (startOfWeek.DayOfWeek != DayOfWeek.Sunday)
            {
                startOfWeek = startOfWeek.AddDays(-1);
            }
            var endOfWeek = startOfWeek.AddDays(7);

            var countBookingsThisWeek = _context.Bookings.Where(b => b.CreatedAt.Date >= startOfWeek && b.CreatedAt.Date <= endOfWeek).Count(); ;
            ViewData["countBookingsThisWeek"] = countBookingsThisWeek;

            var countPackagesPendingPickup = _context.Packages.Where(p => p.Status == PackageStatus.PendingPickup).Count();
            ViewData["countPackagesPendingPickup"] = countPackagesPendingPickup;

            var countPackagesDeliveredToday = _context.Packages.Where(p => p.DeliveredAt.GetValueOrDefault().Date.Equals(DateTime.Now.Date)).Count();
            ViewData["countPackagesDeliveredToday"] = countPackagesDeliveredToday;

            decimal incomeToday = 0;

            var paymentsToday = _context.Payments.Where(p => p.ProcessedAt.Date.Equals(DateTime.Now.Date));

            foreach (var payment in paymentsToday)
            {
                incomeToday += payment.Amount;
            }

            ViewData["incomeToday"] = incomeToday;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
