using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossplatformApp.Pages
{
    class SignInEmail:BasePage
    {
      
        /*
         
         
            app.Tap(x=>x.Text("Sign in with email"));
            app.EnterText(x=>x.Id("NoResourceEntry-62"),"testuser4@mailinator.com");
            app.DismissKeyboard();
            app.Tap(x=>x.Id("NoResourceEntry-66"));
            app.EnterText(x=>x.Id("NoResourceEntry-66"),"Aa@12345");
            app.DismissKeyboard();
            app.Tap(x=>x.Text("SIGN IN"));;
            app.Tap(x=>x.Id("NoResourceEntry-243"));
            
            app.Tap(x=>x.Text("View Policy"));
            app.Tap(x=>x.Id("NoResourceEntry-293"));
            
            app.SetOrientationPortrait();
            app.Back();
            app.Tap(x=>x.Id("NoResourceEntry-275"));
            app.SetOrientationPortrait();
            app.Back();
            app.Tap(x=>x.Id("NoResourceEntry-275"));
            app.SetOrientationPortrait();
            app.Back();
            app.ScrollDown();
            
         
         */

        // Verify Sign in with valid user id and password

        public Query ClickonSignIn => x => x.Text("Sign in with email");
        public Query EnterEmailid => x => x.Id("NoResourceEntry-62");
        public Query Enterpassword => x => x.Id("NoResourceEntry-66");
        public Query SignInButton => x => x.Text("SIGN IN");


        //After Login Internal Pages 
        /*
         * 
         * View Id card locaters are depend upon the no of data used by the client
         * 
         * 
         * */
        public Query ViewPolicy => x => x.Text("NoResourceEntry-243");
        public Query ViewIdcard => x => x.Id("NoResourceEntry-293");

        
        internal void SignIn(string Username, string pass)
            { 
            
            SettingPage.Appcontext.Tap(ClickonSignIn);
            SettingPage.Appcontext.EnterText(EnterEmailid,"testuser4@mailinator.com");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.EnterText(Enterpassword,"Aa@1234");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(SignInButton);
            
            }

    }
}
