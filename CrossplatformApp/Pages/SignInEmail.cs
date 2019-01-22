using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;


namespace CrossplatformApp.Pages

//namespace CrossplatformWestBendApp.Pages
   
{
    class SignInEmail: Basepage
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
              
      //  public Query ClickonSignIn => x => x.Property("contentDescription").Contains("ButtonText");

        public Query ClickonSignIn => x => x.Text("Sign in with email");
        public Query EnterEmailid => x => x.Id("NoResourceEntry-57");
        public Query Enterpassword => x => x.Id("NoResourceEntry-62");
        public Query SignInButton => x => x.Text("SIGN IN");
        public Query Rememberme => x => x.Text("Remember Me");
        public Query ForgotPassword => x=> x.Text("Forgot password?");
        public Query BlankSignInMessage => x => x.Text("Username and password can't be blank");
        public Query SnakbarOk => x => x.Id("snackbar_action");
        public Query InvalidUseridandPwdMessage => x =>x.Text("Invalid email or password, please check your information and try again.");
        public  Query Snackbar_InvalidUsercredentialsErrorMessage =>x =>x.Text("Invalid email or password, please check your information and try again.");
        

        //*****************Alert is getting depriciated******************
          public Query ErrorMessage_InvalidUsername_Password => x => x.Text("Username and password can't be blank");
         public Query ClickOK_Alert => x=> x.Text("OK");



        //After Login Internal Pages 
        /*
         * 
         * View Id card locaters are depend upon the no of data used by the client
         * 
         * 
         * */
        public Query ViewPolicy => x => x.Text("NoResourceEntry-243");
        public Query ViewIdcard => x => x.Id("NoResourceEntry-293");

        internal void ClickonSignInLink()
            { 
            
            ApplicationContext.Tap(ClickonSignIn);

            }

 
        internal void SignIn(string Username, string pass)
            { 
            
           
            ApplicationContext.Tap(EnterEmailid);
            ApplicationContext.EnterText(EnterEmailid,Username);
            
            ApplicationContext.DismissKeyboard();
                        
            ApplicationContext.Tap(Enterpassword);
            ApplicationContext.EnterText(Enterpassword,pass);
           
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(SignInButton);
            
            ApplicationContext.Tap(SignInButton);
 
 
            }

        // Sign in Without passing any value

        internal void SignInWithoutprovidinganyUsernameAndPassword()
            { 
            
            ApplicationContext.Tap(SignInButton); 
            ApplicationContext.WaitForElement(ErrorMessage_InvalidUsername_Password);
       
            }

        internal void ClickOn_Alert_OK()
            { 
            ApplicationContext.Tap(SnakbarOk);

            }

        internal void Waitingelement()
            { 
            ApplicationContext.WaitForElement(InvalidUseridandPwdMessage);

            
            }
    }
}
