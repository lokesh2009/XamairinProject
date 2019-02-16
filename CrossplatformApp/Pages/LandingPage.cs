using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using CrossplatformApp.Extension;


namespace CrossplatformApp.Pages
//namespace CrossplatformWestBendApp.Pages
{
    class LandingPage : Basepage
    {
       
       public Query SignINwithEmailidLink = x=>x.Marked("SIGN_IN_WITH_EMAIL_BUTTON");
       // public Query SignINwithEmailidLink = x=>x.Property("contentDescription").Contains("SIGN_IN_BUTTON");
        public Query CreateAccountlink = x => x.Marked("CREATE_ACCOUNT_LINK_BUTTON");
       // public Query SignINwithEmailidLink= x =>x.Text("Sign in with email");
        public Query PayBillLink = x=>x.Marked("PAY_BILL_BUTTON");

        public Query LearnMoreLink=x=>x.Marked("LEARN_MORE_BUTTON");
       
        // Skip Sign In Link is depriciated and now no use of that link
         
            //public Query SkipSignInLInk=x=>x.Text("Skip Sign In");


        internal  CreateAccountPage Clickon_CreateAccountLink()
            { 
            CreateAccountlink.Click();
            return new CreateAccountPage();

            }

        internal SignInEmail ClickOn_SignINwithEmailidLink()
            { 
            SignINwithEmailidLink.Click();
            return new SignInEmail();
            }

        internal LearnMorePage Clickon_LearnMoreLink()
            { 
            LearnMoreLink.Click();
            return new LearnMorePage();
            }

        internal void Clickon_payBill()
            { 
            PayBillLink.Click();
            }


        // This Method is depriciated and no longer working
        /*
        internal void Clickon_SkipSignInLInk()
            { 
            SkipSignInLInk.Click();
            }
            */
    }
}
