using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossplatformApp.Pages
{
    class  CreateAccountPage : BasePage
    {
        /*
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
  
             */
     

        public Query CreateAccount => x => x.Text("Create Account");
        public Query FirstName => x => x.Id("NoResourceEntry-65");
        public Query LastName => x => x.Id("NoResourceEntry-66");
        public Query Emailid => x => x.Id("NoResourceEntry-67");
        public Query PhoneNo => x => x.Id("NoResourceEntry-68");
        public Query Next => x => x.Id("NoResourceEntry-70");

        // Create Account second page locaters

        public Query Password => x => x.Id("NoResourceEntry-78");
        public Query ConfirmPassword => x => x.Id("NoResourceEntry-84");
        public Query IagreeCheckbox => x => x.Id("NoResourceEntry-107");
        public Query CreateAccButton => x => x.Id("NoResourceEntry-118");

        //***************************************************************************

        //*************************Click on Create Account link***********************
        
            internal void ClickonCreateAccountLink()
            { 
            SettingPage.Appcontext.Tap(x => x.Text("Create Account"));
            }
  
      //***********************************************************************************************

      //***************** Click_on_Next_Event_occurs_when_user_passed_values_as_parameter************

        
            internal void ClickNext(string FName, string Lname, string Email, string Phone)
            { 
            
           // SettingPage.Appcontext.Tap(CreateAccount);
            SettingPage.Appcontext.EnterText(FirstName,"FName");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(LastName);

            //Provide Entry in Last name
            SettingPage.Appcontext.EnterText(LastName, "Lname");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(Emailid);

            //Provide Entry in Email
            SettingPage.Appcontext.EnterText(Emailid,"Email");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(PhoneNo);

            SettingPage.Appcontext.EnterText(PhoneNo,"Phone");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(Next);
            SettingPage.Appcontext.Tap(Next);

            
            }

        internal void CompleteCreateAccount(string password, string confirmpassword)
            { 
            
            SettingPage.Appcontext.EnterText(Password,"password");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(ConfirmPassword);
            SettingPage.Appcontext.EnterText(ConfirmPassword,"password");
            SettingPage.Appcontext.DismissKeyboard();
            SettingPage.Appcontext.Tap(IagreeCheckbox);
            SettingPage.Appcontext.Tap(CreateAccButton);

            }

        //*********************************************************************************************

         //********************************************Wait for Element******************************** 

        internal void WaitforElement()
            
            {
         
            SettingPage.Appcontext.WaitForElement(Password);

            }

    }
}
