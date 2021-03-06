﻿using System;
using System.Collections.Generic;

namespace Civia.Blazor.Server.Models
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
    }
}
