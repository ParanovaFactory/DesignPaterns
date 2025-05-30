﻿using System;

namespace DesignPatern.ChainOfResponsibility.Models
{
    public class CustomerProcessViewModel
    {
        public int CustomerProcessId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
