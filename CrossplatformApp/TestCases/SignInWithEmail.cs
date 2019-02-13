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
        public void VerifyInvalidSignIn()
            { 
          
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
            Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(2,"Userid"),ExcelUtil.ReadData(2,"Password")); 
            Thread.Sleep(10*1000);
            Assert.AreEqual("Invalid email or password, please check your information and try again.",ApplicationContext.Query(Currentpage.As<SignInEmail>().Snackbar_InvalidUsercredentialsErrorMessage).First().Text);
            Currentpage.As<SignInEmail>().ClickOn_Alert_OK();

            }

                 
                     [Test]
           public void CreateAccount_With_FnameBlank()
          
            {
            
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(2,"Firstname"),ExcelUtil.ReadData(2,"Lastname"),ExcelUtil.ReadData(2,"Email"),ExcelUtil.ReadData(2,"Contact"));
           Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext);

            Assert.AreEqual("All fields in this form are required",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext).First().Text);
         //  Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();
           
            }
                       [Test]
           public void CreateAccount_With_ValidData()
            { 

           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(1,"Firstname"),ExcelUtil.ReadData(1,"Lastname"),ExcelUtil.ReadData(1,"Email"),ExcelUtil.ReadData(1,"Contact"));
           Currentpage.As<CreateAccountPage>().RegistrationSecondpage(ExcelUtil.ReadData(1,"Password"),ExcelUtil.ReadData(1,"ConfirmPassword"));
           Currentpage.As<CreateAccountPage>().ClickonIAgreeCheckbox();
           
            // Below line of code click on Create account CTA
            Currentpage.As<CreateAccountPage>().ClickonCreateAccountButton();


           // Assert.AreEqual("All fields in this form are required",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext).First().Text);
          // Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();
            }

        [Test]
        public void CreateAccount_UserPaswwordNotMatchedVerification()
            { 
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(6,"Firstname"),ExcelUtil.ReadData(6,"Lastname"),ExcelUtil.ReadData(6,"Email"),ExcelUtil.ReadData(6,"Contact"));
           Currentpage.As<CreateAccountPage>().RegistrationSecondpage(ExcelUtil.ReadData(6,"Password"),ExcelUtil.ReadData(6,"ConfirmPassword"));
           Currentpage.As<CreateAccountPage>().ClickonIAgreeCheckbox();
           Currentpage.As<CreateAccountPage>().ClickonCreateAccountButton();
           Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().Snakbar_PasswordNotmatched);

           Assert.AreEqual("Confirm Password does not match Password",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().Snakbar_PasswordNotmatched).First().Text);
            
            
            }


        
        [Test]
        public void CreateAccount_PasswordNotProvidedandClickonCreateAccount()
            { 
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(7,"Firstname"),ExcelUtil.ReadData(7,"Lastname"),ExcelUtil.ReadData(7,"Email"),ExcelUtil.ReadData(7,"Contact"));
           //Currentpage.As<CreateAccountPage>().RegistrationSecondpage(ExcelUtil.ReadData(7,"Password"),ExcelUtil.ReadData(7,"ConfirmPassword"));
           Currentpage.As<CreateAccountPage>().ClickonIAgreeCheckbox();
           Currentpage.As<CreateAccountPage>().ClickonCreateAccountButton();
           Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().Snakbar_PasswordnotfoundinCreateacc);

           Assert.AreEqual("Please enter valid password",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().Snakbar_PasswordnotfoundinCreateacc).First().Text);
            }


                     [Test]

           public void CreateAccount_With_BlankData()
            { 
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           Currentpage.As<CreateAccountPage>().Registrationwithoutdata();
           Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext);

           Assert.AreEqual("All fields in this form are required",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext).First().Text);
           Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();
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
                public void CreateAccount_With_LnameBlank()
            { 
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(3,"Firstname"),ExcelUtil.ReadData(3,"Lastname"),ExcelUtil.ReadData(3,"Email"),ExcelUtil.ReadData(3,"Contact"));
          Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext);

            Assert.AreEqual("All fields in this form are required",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext).First().Text);
            Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();
            }

                     [Test]
                public void CreateAccount_With_EmailBlank()
            {
            
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(4,"Firstname"),ExcelUtil.ReadData(4,"Lastname"),ExcelUtil.ReadData(4,"Email"),ExcelUtil.ReadData(4,"Contact"));
            Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext);

            Assert.AreEqual("All fields in this form are required",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext).First().Text);
            Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();
            
            }


             [Test]    
                public void CreateAccount_With_BlankPhoneNoMessage()
            { 
            
           Currentpage = new LandingPage ();
           Currentpage.As<LandingPage>().Clickon_CreateAccountLink();
           Currentpage = new CreateAccountPage();
           //Currentpage.As<CreateAccountPage>().ClickNext("lokesh","sharma","lsharma@xtivia.com","8447520166");
           //Currentpage.As<CreateAccountPage>().CompleteCreateAccount("Gemini@12","Gemini@12");
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","RegistrationData");
           Currentpage.As<CreateAccountPage>().RegistrationFpage(ExcelUtil.ReadData(5,"Firstname"),ExcelUtil.ReadData(5,"Lastname"),ExcelUtil.ReadData(5,"Email"),ExcelUtil.ReadData(5,"Contact"));
           Currentpage.As<CreateAccountPage>().Wait4Element( Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext);
            Assert.AreEqual("All fields in this form are required",ApplicationContext.Query(Currentpage.As<CreateAccountPage>().UsernotprovideanydataandclickonNext).First().Text);
            Currentpage.As<CreateAccountPage>().ClickOn_Alert_OK();
       



         
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
         
            Currentpage = new LandingPage ();
            Currentpage.As<LandingPage>().ClickOn_SignINwithEmailidLink();
            Currentpage = new SignInEmail();
            Currentpage.As<SignInEmail>().SignInWithoutprovidinganyUsernameAndPassword();
            Currentpage.As<SignInEmail>().Waitingelement(Currentpage.As<SignInEmail>().BlankSignInMessage);
            
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
           ExcelUtil.PopulateInCollection("./TestDataWestband.xlsx","LoginData");          
           Currentpage.As<SignInEmail>().SignIn(ExcelUtil.ReadData(2,"Userid"),ExcelUtil.ReadData(2,"Password")); 
           Currentpage.As<SignInEmail>().Waitingelement(Currentpage.As<SignInEmail>().InvalidUseridandPwdMessage);
           Assert.AreEqual("Invalid email or password, please check your information and try again.",ApplicationContext.Query(Currentpage.As<SignInEmail>().InvalidUseridandPwdMessage).First().Text);
           Currentpage.As<SignInEmail>().ClickOn_Alert_OK();
         
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
       public void WIP()
            { 

               app.Repl();
            
            }
            
        }
}
