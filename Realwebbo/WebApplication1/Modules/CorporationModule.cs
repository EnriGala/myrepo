using System.Web.UI.WebControls;
using Nancy;
using Realwebbo.Services;

namespace WebApplication1.Modules
{
    public class CorporationModule : NancyModule
    {
        public CorporationModule()
        {
            Get["corps"] = _ =>
            {
                var corporationServ = new CorporationServices();
                var corporation = corporationServ.FillCorp();
                return corporation;
            };

            Get["corps", true] = async (Parameter, csx) =>
            {
                var corporationServ = new CorporationServices();
                var corporation = corporationServ.FillCorp();
                return corporation;
            };

            Get["pandaria"] =_=>
            {
                var corporationServ = new CorporationServices();
                var corporation = corporationServ.FillCorp();
                return corporation;
            };
        }
    }
}
