﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required, StringLength(49)]
        public string Name { get; set; }        
    }
}