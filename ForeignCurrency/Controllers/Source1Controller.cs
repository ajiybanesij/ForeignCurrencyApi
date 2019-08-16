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

        private WebClient client = new WebClient();

        [Route("source1/currencyList")]
        [HttpGet]
        public async Task<IHttpActionResult> CurrencyList()
        {
            Uri URL = new Uri("https://kur.doviz.com/");
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

        [Route("source1/bankcurrencyList")]
        [HttpGet]
        public async Task<IHttpActionResult> BankCurrencyList()
        {
            List<Source1ListModel> bankCurrencyList = new List<Source1ListModel>();

            var bankList = _scripts.BankNames();
            foreach (var item in bankList)
            {
                Uri URL = new Uri("https://kur.doviz.com/" + item);
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
                                                                            //model.Change = array[5];                        // Currency Change
                                                                            //model.ChangeUpDown = null;                      //COMING
                            model.UpdateTime = array[5];                   // Currency Update Time

                            count++;
                            currencyList.Add(model);

                        }
                    }
                    Source1ListModel ListModel = new Source1ListModel
                    {
                        BankName = item,
                        CurrencyList = currencyList
                    };
                    bankCurrencyList.Add(ListModel);
                }
                catch (Exception)
                {
                    return Ok("null");
                }

            }

            return Ok(bankCurrencyList);
        }

        [Route("source1/goldList")]
        [HttpGet]
        public async Task<IHttpActionResult> GoldList()
        {
            Uri URL = new Uri("https://altin.doviz.com/");
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

        [Route("source1/emtiaList")]
        [HttpGet]
        public async Task<IHttpActionResult> EmtiaList()
        {
            Uri URL = new Uri("https://www.doviz.com/emtialar");
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
                        model.Buyin = array[2];                         // Currency Buyin
                        //model.Sales = array[4];                         // Currency Sales
                        model.Change = array[4];                        // Currency Change
                       // model.ChangeUpDown = null;                      //COMING
                       // model.UpdateTime = array[11];                   // Currency Update Time

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

        [Route("source1/paritiesList")]
        [HttpGet]
        public async Task<IHttpActionResult> ParitiesList()
        {
            Uri URL = new Uri("https://www.doviz.com/pariteler");
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

        [Route("source1/cryptomoneyList")]
        [HttpGet]
        public async Task<IHttpActionResult> CryptoMoneyList()
        {
            Uri URL = new Uri("https://www.doviz.com/kripto-paralar");
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
                        model.Sales = _scripts.NameControl(array[4]);   // Currency Sales
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


        [Route("source1/AllIndex")]
        [HttpGet]
        public async Task<IHttpActionResult> AllIndex()
        {
            Uri URL = new Uri("https://borsa.doviz.com/endeksler");
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
                        //model.Sales = array[4];                         // Currency Sales
                        model.Change = array[7];                        // Currency Change
                       // model.ChangeUpDown = null;                      //COMING
                         model.UpdateTime = array[10];                   // Currency Update Time

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
