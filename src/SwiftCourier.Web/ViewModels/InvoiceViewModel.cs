﻿using SwiftCourier.Web.Models;
using SwiftCourier.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftCourier.Web.ViewModels
{
    public class InvoiceViewModel
    {
        [Display(Name = "Booking Id")]
        public int BookingId { get; set; }

        [Display(Name = "Service Cost")]
        public decimal ServiceCost { get; set; }

        [Display(Name = "GCT")]
        public decimal GCT { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }

        [Display(Name = "Invoice Status")]
        public InvoiceStatus Status { get; set; }

        [Display(Name = "Billing Mode")]
        public BillingMode BillingMode { get; set; }

        [Display(Name = "Amount Paid")]
        public decimal AmountPaid { get; set; }

        [Display(Name = "Amount Due")]
        public decimal AmountDue { get; set; }

        [Display(Name = "Discount Type")]
        public DiscountType DiscountType { get; set; }

        [Display(Name = "Discount Value")]
        public decimal DiscountValue { get; set; }

        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; set; }
    }

    public class InvoiceDetailsViewModel
    {
        [Display(Name = "Booking Id")]
        public int BookingId { get; set; }

        [Display(Name = "Service Cost")]
        public decimal ServiceCost { get; set; }

        [Display(Name = "GCT")]
        public decimal GCT { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }

        [Display(Name = "Invoice Status")]
        public string Status { get; set; }

        [Display(Name = "Billing Mode")]
        public string BillingMode { get; set; }

        [Display(Name = "Amount Paid")]
        public decimal AmountPaid { get; set; }

        [Display(Name = "Amount Due")]
        public decimal AmountDue { get; set; }

        [Display(Name = "Discount Type")]
        public DiscountType DiscountType { get; set; }

        [Display(Name = "Discount Value")]
        public decimal DiscountValue { get; set; }

        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; set; }

        public List<PaymentListItemViewModel> Payments { get; set; }
    }
}
