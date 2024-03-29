﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vod.Models;
using System.ComponentModel.DataAnnotations;

namespace Vod.ViewModels
{
    public class CustomerFormViewModel
    {

        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Membership Type")]
        public byte? MembershipTypeId { get; set; }


        public string Title

        {
            get
            {
                return Id != 0 ? "Edit Customer" : "New Customer";
            }

        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            MembershipTypeId = customer.MembershipTypeId;
            Birthdate = customer.Birthdate;
            IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;

        }

    }
}