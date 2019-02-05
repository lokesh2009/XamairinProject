using CrossplatformApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery,Xamarin.UITest.Queries.AppQuery>;
  

namespace CrossplatformApp.Pages
{
    class SubmitClaimPage : Basepage
    {
        public Query SubjectClaim => x=>x.Text("What type of claim would you like to start?");
        public Query Vehicle=>x=>x.Text("VEHICLE");
        public Query VehicleGlass=>x=>x.Text("VEHICLE GLASS ONLY");
        public Query Residence=>x=>x.Text("RESIDENCE");
        public Query OTHER=>x=>x.Text("OTHER");
        public Query Header=>x=>x.Text("Submit a Claim");


        internal void SubmitClaimLinks(Query ClaimLinks)
            { 
            ApplicationContext.Tap(ClaimLinks);
            }


    }
}
