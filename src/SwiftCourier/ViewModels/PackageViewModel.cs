﻿using SwiftCourier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftCourier.ViewModels
{
    public class PackageViewModel
    {
        [Display(Name = "Booking Id")]
        public int BookingId { get; set; }

        [Display(Name = "Package Type")]
        public PackageType Type { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "# Of Pieces")]
        public int Pieces { get; set; }

        [Display(Name = "Weight (Pounds)")]
        public Decimal Weight { get; set; }

        [Display(Name = "Special Instructions")]
        public string SpecialInstructions { get; set; }

        [Display(Name = "Tracking #")]
        public string TrackingNumber { get; set; }

        [Display(Name = "Picked Up At")]
        public DateTime? PickedUpAt { get; set; }

        [Display(Name = "Delivered At")]
        public DateTime? DeliveredAt { get; set; }

        [Display(Name = "Assigned To")]
        public int? AssignedToUserId { get; set; }

        [Display(Name = "Delivered By")]
        public int? DeliveredByUserId { get; set; }

        [Display(Name = "Status")]
        public PackageStatus Status { get; set; }
    }

    public class PackageDetailsViewModel
    {
        [Display(Name = "Booking Id")]
        public int BookingId { get; set; }

        [Display(Name = "Package Type")]
        public string Type { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "# Of Pieces")]
        public int Pieces { get; set; }

        [Display(Name = "Weight (Pounds)")]
        public Decimal Weight { get; set; }

        [Display(Name = "Special Instructions")]
        public string SpecialInstructions { get; set; }

        [Display(Name = "Tracking #")]
        public string TrackingNumber { get; set; }

        [Display(Name = "Picked Up At")]
        public DateTime? PickedUpAt { get; set; }

        [Display(Name = "Delivered At")]
        public DateTime? DeliveredAt { get; set; }

        [Display(Name = "Assigned To")]
        public string AssignedTo { get; set; }

        [Display(Name = "Delivered By")]
        public string DeliveredBy { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}