using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace CrossplatformApp.Base
{

    //*****************************************************************
    //*****Base Page class is a generic method to access the content of the page

    public class Basepage
    {
       private static Basepage _page;

       public static Basepage Currentpage
        {

            get => _page;
            set => _page = value;
        }

        public static IApp ApplicationContext {get;set;}

        public Tpage As<Tpage>() where Tpage : Basepage
            { 
            return(Tpage)this;
            }

    }
}
