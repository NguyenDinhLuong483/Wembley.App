﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;
using WEMBLEY.App.Core.Domain.Dtos;

namespace WEMBLEY.App.Core.Application.Store
{
    public class ProductStore : BaseViewModel
    {
        public List<ProductDto> HerapinCapProducts { get; private set; }
        public ObservableCollection<string> HerapinCapProductNames { get; private set; }
        public ProductStore()
        {
            HerapinCapProducts = new List<ProductDto>();
            HerapinCapProductNames = new ObservableCollection<string>();
        }

        public void SetHerapinCapProduct(IEnumerable<ProductDto> products)
        {
            HerapinCapProducts = products.ToList();
            HerapinCapProductNames = new ObservableCollection<string>(HerapinCapProducts.Select(i => i.ProductName).OrderBy(s => s));
        }
    }
}
