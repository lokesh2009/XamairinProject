using System.Linq;
using CrossplatformApp.Base;
using CrossplatformApp.Pages;
using CrossplatformApp.Utility;
using CrossplatformApp;
using NUnit.Framework;
using Xamarin.UITest;
using CrossplatformWestBendApp;
using System;
//using CrossplatformWestBendApp;
//using CrossplatformWestBendApp.Base;
//using CrossplatformWestBendApp.Pages;
//using CrossplatformWestBendApp.Utility;

//namespace CrossplatformWestBendApp
namespace CrossplatformApp
{
    [TestFixture(Platform.Android)]
//	[TestFixture(Platform.iOS)]

	public class SignInWithEmail:Basepage
	{
		private IApp app;
		readonly Platform platform;

		public SignInWithEmail(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
        
      
            ApplicationContext = AppInitializer.StartApp(platform);
            app = ApplicationContext;

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
            

            app.Repl();
            
             // Passing locater in to the app context 
             // Locaters specifically for Android 
             /*
            
            app.Tap(x=>x.Text("Sign in with email"));
            app.EnterText(x=>x.Id("NoResourceEntry-64"),"testuser4@mailinator.com");
            app.DismissKeyboard();
            app.Tap(x=>x.Id("NoResourceEntry-65"));
            app.EnterText(x=>x.Id("NoResourceEntry-65"),"Aa@12345");
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
            
            */
       
            }

        [Test]
        public void VerifyInvalidSignIn()
            { 
          
         /*
           app.Tap(x=>x.Text("Sign in with email"));
           app.EnterText(x=>x.Id("NoResourceEntry-62"),"lsharma@xtivia");
           app.Tap(x=>x.Id("NoResourceEntry-66"));
           app.EnterText(x=>x.Id("NoResourceEntry-66"),"lSSS");
           app.Tap(x=>x.Text("SIGN IN"));
           app.Query(x=>x.Class("android.widget.Button"));
           
           app.Tap(x=>x.Text("OK"));

           */
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(2,"Userid"),ExcelUtil.ReadData(2,"Password")); 
            
           

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
                public void CreateAccount_UsingPOM()
            { 
            
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
    
            /*
            Currentpage = new CreateAccountPage();
            Currentpage.As<CreateAccountPage>().ClickonCreateAccountLink();
            Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
            Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           */

           
            /*
             * This is POM code where i am using without Pagefactory approch
             * 
             * 
            
            CreateAccountPage createacc = new CreateAccountPage();
             SignInEmail loginin = new SignInEmail();

            //Create Account first
            createacc.ClickonCreateAccountLink();
            createacc.ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
            createacc.CompleteCreateAccount("Gemini@12","Gemini@12");
           */


          }
         
        [Test]
        public void SignwithBlankUseridandPassword()
            
            { 
          //  "Username and password can't be blank"

          //  app.Repl();

            
            
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            Currentpage.As<SignInEmail>().SignInWithoutanyUsernameAndPassword();
            Assert.AreEqual("Username and password can't be blank",ApplicationContext.Query(Currentpage.As<SignInEmail>().ErrorMessage_InvalidUsername_Password).First().Text);
            Currentpage.As<SignInEmail>().ClickOn_Alert_OK();
       

        /*
           Currentpage = new SignInEmail();
           Currentpage.As<SignInEmail>().ClickonSignInLink();
           Currentpage.As<SignInEmail>().SignInWithoutanyUsernameAndPassword();
           //Assert.AreEqual("You have entered an invalid username or password", app.Query("You have entered an invalid username or password").First().Text);
           Assert.AreEqual("You have entered an invalid username or password",ApplicationContext.Query(Currentpage.As<SignInEmail>().ErrorMessage_InvalidUsername_Password).First().Text);
           Currentpage.As<SignInEmail>().ClickOn_Alert_OK();
   */
            } 
            

        [Test]
        public void SignInWithInvalidUserIdandPassword()
            { 
         
           Currentpage = new SignInEmail();
           Currentpage.As<SignInEmail>().ClickonSignInLink();
           Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(2,"Userid"),ExcelUtil.ReadData(2,"Password")); 
            ApplicationContext.WaitForElement("InvalidUseridandPwdMessage");
            Assert.AreEqual("Invalid email or password, please check your information and try again.",ApplicationContext.Query(Currentpage.As<SignInEmail>().InvalidUseridandPwdMessage).First().Text);
            Currentpage.As<SignInEmail>().ClickOn_Alert_OK();
         
       app.Repl();
            }
           

        [Test]
        public void SignInWithTestDataUsingExcelSheet()
            { 
            //app.Repl();
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password")); 
               
            //Console.WriteLine($"Userid: {ExcelUtil.ReadData(1, "Userid")} and Password: {ExcelUtil.ReadData(1, "Password")}");

            }
       
        }
}
