using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossplatformApp.Pages
{
    class  CreateAccountPage : Basepage 
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
     
            //x=>x.Text("Create Account")
        public Query CreateAccount = x => x.Text("Create Account");
        public Query FirstName = x => x.Id("NoResourceEntry-65");
        public Query LastName = x => x.Id("NoResourceEntry-66");
        public Query Emailid = x => x.Id("NoResourceEntry-67");
        public Query PhoneNo = x => x.Id("NoResourceEntry-68");
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
            
            ApplicationContext.Tap(CreateAccount);
            //SettingPage.Appcontext.Tap(x=>x.Text("Sign in with email"));

            }
      //***********************************************************************************************
      //***************** Click_on_Next_Event_occurs_when_user_passed_values_as_parameter************

        
            internal void ClickNext(string FName, string Lname, string Email, string Phone)
            { 
            
           // SettingPage.Appcontext.Tap(CreateAccount);
            ApplicationContext.EnterText(FirstName,FName);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(LastName);

            //Provide Entry in Last name
            ApplicationContext.EnterText(LastName, Lname);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(Emailid);

            //Provide Entry in Email
            ApplicationContext.EnterText(Emailid,Email);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(PhoneNo);

            ApplicationContext.EnterText(PhoneNo,Phone);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(Next);
            ApplicationContext.Tap(Next);

            
            }

        internal void CompleteCreateAccount(string password, string confirmpassword)
            { 
            
            ApplicationContext.EnterText(Password,password);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(ConfirmPassword);
            ApplicationContext.EnterText(ConfirmPassword,password);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(IagreeCheckbox);
            ApplicationContext.Tap(IagreeCheckbox);
            ApplicationContext.Tap(CreateAccButton);

            }

 //*********************************************************************************************

 //********************************************Wait for Element******************************** 

        internal void WaitforElement()
            
            {
         
            ApplicationContext.WaitForElement(Password);

            }

    }
}
