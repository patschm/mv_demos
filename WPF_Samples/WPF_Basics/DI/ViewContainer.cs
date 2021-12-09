using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Basics.ViewModels;

namespace WPF_Basics.DI
{
    class ViewContainer : IViewContainer
    {
        private IHost _host;

        public ViewContainer(IHost host)
        {
            _host = host;
        }
        public BindingWindow BindingWindow
        {
            get
            {
                return new BindingWindow(_host.Services.GetRequiredService<BindingViewModel>());
            }
        }
        public StylesWindow StylesWindow
        {
            get
            {
                return new StylesWindow();
            }
        }

        
    }
}
