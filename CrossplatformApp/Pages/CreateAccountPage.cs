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
        public Query FirstName = x => x.Marked("INPUT_FIRST_NAME");
        public Query LastName = x => x.Marked("INPUT_LAST_NAME");
        public Query Emailid = x => x.Marked("INPUT_EMAIL");
        public Query PhoneNo = x => x.Id("NoResourceEntry-62");
        
        public Query Next => x => x.Marked("NEXT_BUTTON");
        
        //=================SnackBar Error Messages====================
        public Query SnakbarOk => x => x.Id("snackbar_action");
        public Query UsernotprovideanydataandclickonNext => x =>x.Text("All fields in this form are required");
        public Query Snakbar_PasswordNotmatched => x =>x.Text("Confirm Password does not match Password");
        public Query Snakbar_PasswordnotfoundinCreateacc => x=>x.Text("Please enter valid password");
        public Query Snakbar_UseremailAlreadyExist = x=>x.Text("An account already exists with this email address. Please login (101)");
        // Create Account second page locaters

        public Query Password => x => x.Id("NoResourceEntry-102");
        public Query ConfirmPassword => x => x.Id("NoResourceEntry-108");
        public Query IagreeCheckbox => x => x.Id("NoResourceEntry-132");
        public Query CreateAccButton => x => x.Text("Create Account");
        public Query ClickCreateButton => x=> x.Marked("LEARN_MORE_BUTTON");

        public Query BackButton => x => x.Class("android.widget.TextView");

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
        
            internal void Registrationwithoutdata()
        { 
        
              Thread.Sleep(10*1500);
              ApplicationContext.Tap(Next);

        }
            
            
            internal void RegistrationFpage(string Fname, string Lname,string Email, string contact )
            { 
           
            Thread.Sleep(10*1500);
            ApplicationContext.Tap(FirstName);
            WestBendExtensionMethods.TapandEnterText(FirstName,Fname);
            
            Thread.Sleep(10*1500);
            ApplicationContext.Tap(LastName);
            WestBendExtensionMethods.TapandEnterText(LastName,Lname);
            
            Thread.Sleep(10*1000);
            ApplicationContext.Tap(Emailid);
            WestBendExtensionMethods.TapandEnterText(Emailid,Email);
            
            Thread.Sleep(10*1000);
            ApplicationContext.Tap(PhoneNo);
            // String contact need to convert in Double
            WestBendExtensionMethods.TapandEnterText(PhoneNo,contact);
           
            
            Thread.Sleep(10*1500);
            ApplicationContext.Tap(Next);
           //ApplicationContext.Tap(Next);

            } 

        internal void RegistrationSecondpage(string password, string confirmpassword)
            { 

          /*             
            ApplicationContext.Tap(FirstName);
          
            WestBendExtensionMethods.TapandEnterText(FirstName,Fname);
            
            ApplicationContext.Tap(LastName);
            WestBendExtensionMethods.TapandEnterText(LastName,Lname);

            */
            Thread.Sleep(10*1000);
            ApplicationContext.Tap(Password);
            WestBendExtensionMethods.TapandEnterText(Password,password);

            Thread.Sleep(10*1000);
            ApplicationContext.Tap(ConfirmPassword);
            WestBendExtensionMethods.TapandEnterText(ConfirmPassword,confirmpassword);
          
            }
        public void ClickonIAgreeCheckbox()
            { 
            Thread.Sleep(10*1000);
            ApplicationContext.Tap(IagreeCheckbox);
            
            }

        public void ClickonCreateAccountButton()
            {
            Thread.Sleep(10*1000);
           // ApplicationContext.Tap(CreateAccButton);
           ApplicationContext.Tap(ClickCreateButton);
           }
        internal void ClickOn_Alert_OK()
            { 
            Thread.Sleep(10*1000);
            ApplicationContext.Tap(SnakbarOk);

            }


        internal void Wait4Element(Query elementwait)
            { 
            
            ApplicationContext.WaitForElement(elementwait,"Please wait for snackbar to upload",new TimeSpan(0,0,0,350,0));
            
            }
    }
}
