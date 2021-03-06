﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore1.Domain.Entities;
namespace SportsStore1.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}