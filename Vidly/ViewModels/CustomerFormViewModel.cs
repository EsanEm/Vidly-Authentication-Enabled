﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        
        // To change view's title based on new or existing customer
        public string Title
        {
            get { return Customer != null && Customer.Id != 0 ? "Edit Customer" : "New Customer"; }
        }
    }
}