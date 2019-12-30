﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _Text = "ViewB";

        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }
    }
}
