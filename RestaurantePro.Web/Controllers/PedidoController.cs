using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantePro.Web.Models;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace RestaurantePro.Web.Controllers
{
    public class PedidoController : Controller
    {
        // GET: PedidoController

        HttpClientHandler httpClientHandler = new HttpClientHandler();

        public PedidoController()
        {
            this.httpClientHandler = new HttpClientHandler();
            this.httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
        }
        public async Task<ActionResult> Index()
        {
            PedidoListResult pedidoListResult = new PedidoListResult();

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {
                var url = "http://localhost:5157/api/Pedido/GetPedido";

                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK) 
                    { 
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        pedidoListResult = JsonConvert.DeserializeObject<PedidoListResult>(apiResponse);

                        if (!pedidoListResult.success)
                        {
                            ViewBag.Message = pedidoListResult.message;
                            return View();
                        }
                    }
                }
            }

            return View(pedidoListResult.Result);
        }

        // GET: PedidoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            PedidoGetResult pedidoGetResult = new PedidoGetResult();

            HttpClient client = new HttpClient(this.httpClientHandler);

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {
                var url = $"http://localhost:5157/api/Pedido/GetPedidoById?id={id}";

                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        pedidoGetResult = JsonConvert.DeserializeObject<PedidoGetResult>(apiResponse);

                        if (!pedidoGetResult.success)
                        {
                            ViewBag.Message = pedidoGetResult.message;
                            return View();
                        }
                    }
                }
            }
            return View(pedidoGetResult.Result);
        }

        // GET: PedidoController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: PedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PedidoSaveModel pedidoSave)
        {
            try
            {
                PedidoSaveResult pedidoSaveResult = new PedidoSaveResult();

               

                using (var httpClient = new HttpClient(this.httpClientHandler))
                {
                    var url = "http://localhost:5157/api/Pedido/SavePedido";

                  //  StringContent  content = new StringContent(JsonConvert.SerializeObject(pedidoSave), Encoding.UTF8, "application/json" );

                    using (var response = await httpClient.PostAsJsonAsync(url, pedidoSave))
                    {

                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            pedidoSaveResult = JsonConvert.DeserializeObject<PedidoSaveResult>(apiResponse);

                            if (!pedidoSaveResult.success)
                            {
                                ViewBag.Message = pedidoSaveResult.message;
                                return View();
                            }
                        }
                    }
                }




                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PedidoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
