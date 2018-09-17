using System;
using System.IO;
using System.Linq;
using CrossplatformApp;
using CrossplatformApp.Pages;
using CrossplatformWestBendApp;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossplatformWestBendApp
{
	[TestFixture(Platform.Android)]
//	[TestFixture(Platform.iOS)]
	public class SignInWithEmail
	{
		private IApp app;
		Platform platform;

		public SignInWithEmail(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
            SettingPage.Appcontext = AppInitializer.StartApp(platform);
            app = SettingPage.Appcontext;

            //app = AppManager.StartApp();
		}

		[Test]
		public void VerifySignInEmail()
		{
        
        //****************************************************************************
        //*************** VerifySignInEmail with Valid userid and Password******************
        /*
         * 
         * Author : :Lokesh Sharma
         * 
         * Script : First Sprint Test case
         * 
         * 
         * 
         * 
         * */
            

            //app.Repl();
            
             // Passing locater in to the app context 
             // Locaters specifically for Android 
            app.Tap(x=>x.Text("Sign in with email"));
            app.EnterText(x=>x.Id("NoResourceEntry-62"),"testuser4@mailinator.com");
            app.DismissKeyboard();
            app.Tap(x=>x.Id("NoResourceEntry-66"));
            app.EnterText(x=>x.Id("NoResourceEntry-66"),"Aa@12345");
            app.DismissKeyboard();
            app.Tap(x=>x.Text("SIGN IN"));;
            app.Tap(x=>x.Id("NoResourceEntry-243"));
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
            
       
            }

        [Test]
        public void VerifyInvalidSignIn()
            { 
            
         
           app.Tap(x=>x.Text("Sign in with email"));
           app.EnterText(x=>x.Id("NoResourceEntry-62"),"lsharma@xtivia");
           app.Tap(x=>x.Id("NoResourceEntry-66"));
           app.EnterText(x=>x.Id("NoResourceEntry-66"),"lSSS");
           app.Tap(x=>x.Text("SIGN IN"));
           app.Query(x=>x.Class("android.widget.Button"));
           
           app.Tap(x=>x.Text("OK"));

           
            }

        [Test]
        public void VerifyCreateAccount()
            { 
          
        //****************************************************************************
       //*************** Create Account with Password verification************************
            
               app.Tap(x=>x.Text("Create Account"));
               app.EnterText(x=>x.Id("NoResourceEntry-65"),"Lokesh");
               app.Tap(x=>x.Id("NoResourceEntry-66"));
               app.EnterText(x=>x.Id("NoResourceEntry-66"),"Sharma");
               app.Tap(x=>x.Id("NoResourceEntry-67"));
               app.EnterText(x=>x.Id("NoResourceEntry-67"),"lsharma@xtivia.com");
               app.Tap(x=>x.Id("NoResourceEntry-68"));
               app.EnterText(x=>x.Id("NoResourceEntry-68"),"8447520166");
               app.DismissKeyboard();
               app.Tap(x=>x.Id("NoResourceEntry-70"));
               app.Tap(x=>x.Id("NoResourceEntry-70"));
               app.EnterText(x=>x.Id("NoResourceEntry-78"),"Gemini@12");
               app.Tap(x=>x.Id("NoResourceEntry-84"));
               app.EnterText(x=>x.Id("NoResourceEntry-84"),"Gemini@12");
               app.DismissKeyboard();
               app.Tap(x=>x.Id("NoResourceEntry-107"));
               app.Tap(x=>x.Id("NoResourceEntry-107"));
               app.Tap(x=>x.Id("NoResourceEntry-118"));
        
            }
	
         
             [Test]    
                public void UsingPOM()
            { 
            
         //    app.Repl();
             CreateAccountPage createacc = new CreateAccountPage();
             SignInEmail loginin = new SignInEmail();

            //Create Account first
            createacc.ClickonCreateAccountLink();
            createacc.ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
            createacc.CompleteCreateAccount("Gemini@12","Gemini@12");
           
          }
         

            
           
        
        }
}
