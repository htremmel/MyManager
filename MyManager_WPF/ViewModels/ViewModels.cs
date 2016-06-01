using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyManager.Controller;

namespace MyManager_WPF.ViewModels
{
    public abstract class ViewModel
    {
        protected IController _controller;

        protected ViewModel(IController controller)
        {

        }
    }
}
