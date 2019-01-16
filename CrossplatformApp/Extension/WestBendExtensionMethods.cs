using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

//namespace CrossplatformWestBendApp.Extension

namespace CrossplatformApp.Extension
{
    public static class WestBendExtensionMethods
    {

        public static void EnterText(this Query element, string text)
            { 
            Base.Basepage.ApplicationContext.EnterText(text);
            }
        
        public static void ClearAndEnterText(this Query element, string text)
            { 
            Base.Basepage.ApplicationContext.ClearText(element);
            Base.Basepage.ApplicationContext.EnterText(text);
            }

        public static void EnterTextWithDismissKeyboard(this Query element, string text)
            { 
            Base.Basepage.ApplicationContext.EnterText(text);
            Base.Basepage.ApplicationContext.DismissKeyboard();

            }

        public static void Click(this Query element)
            { 
            Base.Basepage.ApplicationContext.Tap(element);
            }

        public static void WaitforElement(this Query element)
            { 
            
            Base.Basepage.ApplicationContext.WaitForElement(element);

            }

        public static void DismissKeyboard(this Query element)
            { 
            
            Base.Basepage.ApplicationContext.DismissKeyboard();
            }


        public static void EnterTextAndDismissKeyboardAndTapNextElement(this Query element,string text)
            { 
            
            Base.Basepage.ApplicationContext.EnterText(text);
            Base.Basepage.ApplicationContext.DismissKeyboard();
            Base.Basepage.ApplicationContext.Tap(element);
            }

        public static void TapandEnterText(this Query element, string text)
            { 
                          Thread.Sleep(2000);
            Base.Basepage.ApplicationContext.Tap(element);
            Base.Basepage.ApplicationContext.EnterText(text);
            Base.Basepage.ApplicationContext.DismissKeyboard();

                          Thread.Sleep(2000);

            }
        

 
        internal static void TapandEnterText(Query phoneNo, double contact1)
        {
            throw new NotImplementedException();
        }
    }
}
