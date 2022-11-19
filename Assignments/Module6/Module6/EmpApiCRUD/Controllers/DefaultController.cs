using EmpApiCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmpApiCRUD.Controllers
{
    public class DefaultController : Controller
    {
        private HttpClient _http;
        private string employeeApiUrl;

        public DefaultController(HttpClient http,IConfiguration config)
        {
            _http = http;
            employeeApiUrl = config.GetValue<string>("AppSettings:EmployeesApiUrl");
        }
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await _http.GetAsync(employeeApiUrl);
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<EmpData> data = JsonSerializer.Deserialize<List<EmpData>>(stringData, options);

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmpData obj)
        {
            if (ModelState.IsValid)
            {
                string stringData = JsonSerializer.Serialize(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _http.PostAsync(employeeApiUrl, contentData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Employee Inserted Successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web Api!";
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            HttpResponseMessage response = await _http.GetAsync($"{employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            EmpData obj = JsonSerializer.Deserialize<EmpData>(stringData, options);

            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EmpData obj)
        {
            if (ModelState.IsValid)
            {
                string stringData = JsonSerializer.Serialize(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _http.PutAsync($"{employeeApiUrl}/{obj.Id}", contentData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Employee Updated Successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web Api!";
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            HttpResponseMessage response = await _http.GetAsync($"{employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            EmpData obj = JsonSerializer.Deserialize<EmpData>(stringData, options);

            return View(obj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> SingleDelete(int id)
        {
            HttpResponseMessage response = await _http.DeleteAsync($"{employeeApiUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                ViewBag.Message = "Employee Deleted Successfully!";
            }
            else
            {
                ViewBag.Message = "Error while calling Web Api!";
            }

            return RedirectToAction("Index");
        }
    }
}
