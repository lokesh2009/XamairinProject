﻿using System.Linq;
using CrossplatformApp.Base;
using CrossplatformApp.Pages;
using CrossplatformApp.Utility;
using CrossplatformApp;
using NUnit.Framework;
using Xamarin.UITest;
using CrossplatformWestBendApp;
using System;
using CrossplatformApp.Extension;



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
        public void VerifyInvalidSignIn()
            { 
          
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","Sheet1");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(2,"Userid"),ExcelUtil.ReadData(2,"Password")); 
            
            }
     
             [Test]    
                public void CreateAccount_UsingPOM()
            { 
            
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(1,"");
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
            Currentpage.As<SignInEmail>().SignInWithoutprovidinganyUsernameAndPassword();
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
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","Sheet1");          
           Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(2,"Userid"),ExcelUtil.ReadData(2,"Password")); 
           Currentpage.As<SignInEmail>().Waitingelement();
           Assert.AreEqual("Invalid email or password, please check your information and try again.",ApplicationContext.Query(Currentpage.As<SignInEmail>().InvalidUseridandPwdMessage).First().Text);
           Currentpage.As<SignInEmail>().ClickOn_Alert_OK();
         
       //app.Repl();
            }
           

        [Test]
        public void SignInWithValidUseridandPassword()
            { 
            //app.Repl();
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","Sheet1");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password")); 
               
            //Console.WriteLine($"Userid: {ExcelUtil.ReadData(1, "Userid")} and Password: {ExcelUtil.ReadData(1, "Password")}");

            }
       
        [Test]
        public void WIP()
            { 
            
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
      
            
            }
        }
}
