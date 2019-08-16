using ForeignCurrency.Models;
using ForeignCurrency.Helper;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ForeignCurrency.Controllers
{
    [RoutePrefix("api")]
    public class Source1Controller : ApiController
    {
        private readonly Scripts _scripts = new Scripts();
        private readonly Uri URL = new Uri("https://kur.doviz.com/");
        private WebClient client = new WebClient();

        [Route("source1/currencyList")]
        [HttpGet]
        public async Task<IHttpActionResult> CurrencyList()
        {
            List<Source1Model> currencyList = new List<Source1Model>();
            string html = client.DownloadString(URL);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);
            try
            {
                var tableRow = document.DocumentNode.Descendants("tr");
                int count = 0;

                foreach (var node in tableRow)
                {
                    var array = node.InnerText.Replace(" ", "").Trim().Split('\n');
                    if (count < 1)
                    {
                        count++;
                    }
                    else
                    {
                        Source1Model model = new Source1Model();
                        model.Name = _scripts.NameControl(array[0]);    // Currency Name
                        model.Buyin = array[3];                         // Currency Buyin
                        model.Sales = array[4];                         // Currency Sales
                        model.Change = array[8];                        // Currency Change
                        model.ChangeUpDown = null;                      //COMING
                        model.UpdateTime = array[11];                   // Currency Update Time

                        count++;
                        currencyList.Add(model);

                    }
                }

            }
            catch (Exception)
            {
                return Ok("null");
            }
            
            return Ok(currencyList);
        }
    }
}
