using ECommerceApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.Infrastructure
{
    public class InterfaceLocator
    {
        public MainViewModel Main { get; set; }

        public InterfaceLocator()
        {
            Main = new MainViewModel();
        }
    }

}
