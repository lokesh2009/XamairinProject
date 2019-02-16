using System.Linq;
using CrossplatformApp.Base;
using CrossplatformApp.Pages;
using CrossplatformApp.Utility;
using CrossplatformApp;
using NUnit.Framework;
using Xamarin.UITest;
using CrossplatformWestBendApp;
using System;
using CrossplatformApp.Extension;
using System.Threading;
using AppResult = System.Func<Xamarin.UITest.Queries.AppResult,Xamarin.UITest.Queries.AppResult>;
using Xamarin.UITest.Utils ; 

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
            Thread.Sleep(6000);
            app = ApplicationContext;

            //app = AppManager.StartApp();
		}
        
        [Test]
        public void VerifyApp_version()
            { 
            
               
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password"));
            Currentpage = new UserLoggedInPage ();
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().Snakbar_Successfullmessage);
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().AllPolicyDisplayScreen);
            Currentpage.As<UserLoggedInPage>().ClickMenuBarTap();
            Currentpage.As<UserLoggedInPage>().ClickOnAnyLink(UserLoggedInPage.MenuBar_AccountSetting);
           // AppResult[] results = app.Query(x=>x.All());

            }

          [Test]
        public void CreateAccount_IfEmailIdAlreadyexistAndUserTrytoCreateAccount()
            { 
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();  
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(8,"Firstname"),ExcelUtil.ReadData(8,"Lastname"),ExcelUtil.ReadData(8,"Email"),ExcelUtil.ReadData(8,"Contact"));
           Currentpage.As<CreateAccountPage>().RegistrationSecondpage(ExcelUtil.ReadData(8,"Password"),ExcelUtil.ReadData(8,"ConfirmPassword"));
           Currentpage.As<CreateAccountPage>().ClickonIAgreeCheckbox();

           Currentpage.As<CreateAccountPage>().ClickonCreateAccountButton();
           Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().Snakbar_UseremailAlreadyExist);
           Assert.AreEqual("An account already exists with this email address. Please login (101)",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().Snakbar_UseremailAlreadyExist).First().Text);
            Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();     
            
            }



       
        [Test]
        public void SubmitClaim_When_User_NotSelectedAnyPolicy()
            { 
            
           Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password"));
            Currentpage = new UserLoggedInPage ();
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().Snakbar_Successfullmessage);
      
             Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().AllPolicyDisplayScreen);
            
             Currentpage.As<UserLoggedInPage>().ClickMenuBarTap();
             Currentpage.As<UserLoggedInPage>().ClickOnAnyLink(UserLoggedInPage.MenuBar_Submitaclaim);
             Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().NoPolicySelected);
             Assert.AreEqual("No Policy has been selected",ApplicationContext.Query(Currentpage.As<UserLoggedInPage>().NoPolicySelected).First().Text);
            
          
            
            
            }
        [Test]
        public void PolicySummaryPage_errorMessage()
            { 
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password"));
            Currentpage = new UserLoggedInPage ();
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().Snakbar_Successfullmessage);
      
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().AllPolicyDisplayScreen);
            
            Currentpage.As<UserLoggedInPage>().ClickMenuBarTap();
            
            Currentpage.As<UserLoggedInPage>().ClickOnAnyLink(UserLoggedInPage.MenuBar_PolicySummary);
            Currentpage.As<UserLoggedInPage>().TapOnFirstPolicy(Currentpage.As<UserLoggedInPage>().FirstElementClick);
           
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().ErrorRetrievingPolicy);
            Assert.AreEqual("Error retrieving the billing summary",ApplicationContext.Query(Currentpage.As<UserLoggedInPage>().ErrorRetrievingPolicy).First().Text);
           
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().TaponOK);
            Currentpage.As<UserLoggedInPage>().TaponMessageOk();
            
            }

        [Test]
        public void SubmitClaim_WhenUserSelectPolicySelected()
            { 
            
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password"));
            Currentpage = new UserLoggedInPage ();
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().Snakbar_Successfullmessage);
      
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().AllPolicyDisplayScreen);
            
            Currentpage.As<UserLoggedInPage>().ClickMenuBarTap();
            
            Currentpage.As<UserLoggedInPage>().ClickOnAnyLink(UserLoggedInPage.MenuBar_PolicySummary);
            Currentpage.As<UserLoggedInPage>().TapOnFirstPolicy(Currentpage.As<UserLoggedInPage>().FirstElementClick);
           
            Currentpage.As<UserLoggedInPage>().Waitingelement_UserLogged(Currentpage.As<UserLoggedInPage>().PolicySummary);
            Currentpage.As<UserLoggedInPage>().ClickMenuBarTap();
            Currentpage.As<UserLoggedInPage>().ClickOnAnyLink(UserLoggedInPage.MenuBar_Submitaclaim);
           
           
            }
            
			
        [Test]
        public void SignInWithValidUseridandPassword()
            { 

            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(3,"Userid"),ExcelUtil.ReadData(3,"Password")); 
            Currentpage.As<SignInEmail>().Waitingelement(Currentpage.As<SignInEmail>().All_PolicyHeader);
             }

        }
}
