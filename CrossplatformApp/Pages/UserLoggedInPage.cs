using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

using  AppWebQuery =  System.Func<Xamarin.UITest.Queries.AppQuery,Xamarin.UITest.Queries.AppQuery>;

using AppResult = System.Func<Xamarin.UITest.Queries.AppResult,Xamarin.UITest.Queries.AppResult>;
using Xamarin.UITest.Queries;

namespace CrossplatformApp.Pages
{
    class UserLoggedInPage : Basepage
    {
        
        public Query AllPolicyDisplayScreen = x=>x.Text("Select a policy");
      //  private readonly double timeoutInSeconds;

        public Query Snakbar_Successfullmessage => x => x.Text("Authentication Successful.");
        public Query EnterEmailid => x => x.Id("NoResourceEntry-57");
    //  public Query (c => c.WebView().InvokeJs("document.getElementById('test-1').style.backgroundColor"))
        public Query MenuBar => x=>x.Class("android.widget.ImageView");
        public Query PolicyNoTap =>x => x.Class("android.view.ViewGroup");
        public Query SubmitClaimTap => x=>x.Text("Submit a claim");
        public Query AllPolicy => x=>x.Text("All Policies");
        public Query PolicySummary =>x=>x.Text("Policy Summary");
        public Query AccountSetting =>x=>x.Text("Account Settings");
        public Query Versionno => x=>x.Class("android.widget.TextView");
        
        
        //****************************Menu Bar Links **********************************
        public static Query MenuBar_PolicySummary => x=>x.Text("Policy Summary");
        public static Query MenuBar_Paybills => x=>x.Text("Pay Bills");
        public static Query MenuBar_Submitaclaim => x=>x.Text("Submit a Claim");
        public static Query MenuBar_PolicyDocument => x=>x.Text("Policy Documents");
        public static Query MenuBar_VehicleIdcard => x=>x.Text("Vehicle ID Cards");
        public static Query MenuBar_Contact => x=>x.Text("Contacts");
        public static Query MenuBar_AccountSetting => x=>x.Text("Account Settings");
        public static Query MenuBar_LinkPolicy => x=>x.Text("Link Policy");


        public Query FirstElementClick =>x=>x.Text("Policy Type");
        public Query ErrorRetrievingPolicy=x=>x.Text("Error retrieving the policy details, services might be down. The remote server returned an error: (503) Server Unavailable. (1)");
        public Query TaponOK =>x=>x.Text("OK");
        public Query NoPolicySelected => x=>x.Text("No Policy has been selected");
        //***************************************************************************
        internal void TaponMessageOk()
            { 
            ApplicationContext.Tap(TaponOK);
            }
           
      internal void TapOnFirstPolicy(Query ElementOnTap)
            { 
             ApplicationContext.Tap(ElementOnTap);

            } 
 
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

        internal void ClickOnAnyLink(Query linkQuery)
            { 
            ApplicationContext.Tap(linkQuery);
            
            }
       
        
        internal void Waitingelement_UserLogged(Query waitelem)
            { 
             ApplicationContext.WaitForElement(waitelem,"Please wait for snackbar to upload",new TimeSpan(0,0,0,250,0));
           
            }
        
}

}




