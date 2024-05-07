﻿using Layui.Core.Base;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LayuiComponentExample.ViewModels
{
    public class VRViewModel : LayuiViewModelBase
    { 
        public VRViewModel(IContainerExtension container) : base(container)
        {
        }
    }
}
