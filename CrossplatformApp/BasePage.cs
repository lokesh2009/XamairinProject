using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace CrossplatformApp
{
    class BasePage
    {

        private static BasePage _page;

        public BasePage CurrentPage
        {
            get => _page;
            set => _page = value;

        }

        public static IApp ApplicationContext { get; set; }

        public Tpage As<Tpage>() where Tpage : BasePage
        {
            return (Tpage)this;
        }


        
    }

    }

