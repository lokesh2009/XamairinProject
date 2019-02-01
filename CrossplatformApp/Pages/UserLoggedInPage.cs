using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using  AppWebQuery =  System.Func<Xamarin.UITest.Queries.AppQuery,Xamarin.UITest.Queries.AppQuery>;
namespace CrossplatformApp.Pages
{
    class UserLoggedInPage : Basepage
    {
        
        public Query AllPolicyDisplayScreen = x=>x.Text("All Policies");
        public Query Snakbar_Successfullmessage => x => x.Text("Authentication Successful.");
        public Query EnterEmailid => x => x.Id("NoResourceEntry-57");
    //  public Query (c => c.WebView().InvokeJs("document.getElementById('test-1').style.backgroundColor"))
        public Query MenuBar => x=>x.Class("android.widget.ImageView");
        public Query PolicyNoTap =>x => x.Class("android.view.ViewGroup");
        public Query SubmitClaimTap => x=>x.Text("Submit a claim");
        public Query AllPolicy => x=>x.Text("All Policies");
        public Query AccountSetting =>x=>x.Text("Account Settings");
        public Query Versionno => x=>x.Class("android.widget.TextView");
        
        internal void ClickMenuBarTap()
            { 
           
            ApplicationContext.Tap(MenuBar);

            }

        internal void WaitForAllPolicyLoad()
            { 

            ApplicationContext.WaitForElement(AllPolicy);
            
            }

        internal void AccountSetting_Tap()
            { 
            ApplicationContext.Tap(AccountSetting);

            }

       
        
}

}




