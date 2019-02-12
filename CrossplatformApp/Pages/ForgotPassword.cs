using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossplatformApp.Pages 
{
    class ForgotPassword : Basepage
    {

        public Query EnterEmail=> x=>x.Id("NoResourceEntry-159");
        public Query Submit=>x=>x.Text("SUBMIT");
        public Query Cancel=>x=>x.Text("CANCEL");

        internal void EnterEmailId(Query Emailid)
            { 

            //ApplicationContext.EnterText(Emailid);

            }
    
        }

}
