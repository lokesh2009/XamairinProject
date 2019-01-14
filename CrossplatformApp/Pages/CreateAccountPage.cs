using CrossplatformApp.Base;
using CrossplatformApp.Extension;
//using CrossplatformWestBendApp.Extension;
//using CrossplatformWestBendApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossplatformApp.Pages
//namespace CrossplatformWestBendApp.Pages
{
    class  CreateAccountPage : Basepage 
    {
        
        public Query CreateAccount = x => x.Text("Create Account");
        public Query FirstName = x => x.Id("NoResourceEntry-60");
        public Query LastName = x => x.Id("NoResourceEntry-62");
        public Query Emailid = x => x.Id("NoResourceEntry-63");
        public Query PhoneNo = x => x.Id("NoResourceEntry-64");
        public Query Next => x => x.Text("Next");
        public Query SnakbarOk => x => x.Id("snackbar_action");
        public Query UsernotprovideanydataandclickonNext => x =>x.Text("All fields in this form are required");


        // Create Account second page locaters

        public Query Password => x => x.Id("NoResourceEntry-78");
        public Query ConfirmPassword => x => x.Id("NoResourceEntry-84");
        public Query IagreeCheckbox => x => x.Id("NoResourceEntry-107");
        public Query CreateAccButton => x => x.Id("NoResourceEntry-118");

        //***************************************************************************

        //*************************Click on Create Account link***********************
        /*
            internal void ClickonCreateAccountLink()
            { 
            
          //SettingPage.Appcontext.Tap(x=>x.Text("Sign in with email"));

          //  ApplicationContext.Tap(CreateAccount);
            CreateAccount.Click();

            }
            
             */


      //***********************************************************************************************
      //***************** Click_on_Next_Event_occurs_when_user_passed_values_as_parameter************

        
            internal void ClickNext(string FName, string Lname, string Email, string Phone)
            { 
            
            /*
             * 
             * Using extension methods
             * 
             * 
             */

            
            FirstName.EnterTextAndDismissKeyboardAndTapNextElement(FName);
            LastName.EnterTextAndDismissKeyboardAndTapNextElement(Lname);
            Emailid.EnterTextAndDismissKeyboardAndTapNextElement(Email);
            PhoneNo.EnterTextAndDismissKeyboardAndTapNextElement(Phone);
            Next.Click();
            

            /*
            ApplicationContext.EnterText(FirstName,FName);
            
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(LastName);
           
              */

            //Provide Entry in Last name
            ApplicationContext.EnterText(LastName, Lname);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(Emailid);

            //Provide Entry in Email
            ApplicationContext.EnterText(Emailid,Email);
            ApplicationContext.DismissKeyboard();
            ApplicationContext.Tap(PhoneNo);
            
            // provide Phone no
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
        // Registration First page parameter
                internal void RegistrationFpage(string Fname, string Lname,string Email, string contact )
            { 
            ApplicationContext.Tap(FirstName);
            WestBendExtensionMethods.EnterText(FirstName,Fname);
            ApplicationContext.DismissKeyboard();
             Thread.Sleep(2000);

            ApplicationContext.Tap(LastName);
            ApplicationContext.Tap(LastName);
            WestBendExtensionMethods.EnterText(LastName,Lname);
            ApplicationContext.DismissKeyboard();
            Thread.Sleep(2000);
            
            ApplicationContext.Tap(Emailid);
            ApplicationContext.Tap(Emailid);
            WestBendExtensionMethods.EnterText(Emailid,Email);
            ApplicationContext.DismissKeyboard();
            Thread.Sleep(2000);

            ApplicationContext.Tap(PhoneNo);
            ApplicationContext.Tap(PhoneNo);
            Thread.Sleep(2000);
            ApplicationContext.EnterText(PhoneNo, contact);
            ApplicationContext.DismissKeyboard();
            Thread.Sleep(2000);

            ApplicationContext.Tap(Next);
            ApplicationContext.Tap(Next);

           

            
                   

            } 

        internal void RegistrationSecondpage(string password, string confirmpassword)
            { 
            
            WestBendExtensionMethods.TapandEnterText(Password,password);
            WestBendExtensionMethods.TapandEnterText(ConfirmPassword,confirmpassword);
            ApplicationContext.Tap(CreateAccButton);

            }

    }
}
