using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace CrossplatformApp.Pages
{
    class CreateAccountPage : Base
    {

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
}
