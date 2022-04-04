using AbsaPhoneBook.SharedKernel.ApiHelper;
using AbsaPhoneBook.SharedKernel.Dto;
using AbsaPhoneBook.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;
        private readonly string baseUrl = "http://localhost:5001/";

        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                if (TempData["Error"] != null) 
                   ModelState.AddModelError(string.Empty, TempData["Error"].ToString());

                if (TempData["SearchResults"] != null)
                {
                    var model = JsonConvert.DeserializeObject<List<PhoneBookViewModel>>(TempData["SearchResults"].ToString());
                    
                    ViewBag.PhoneBooks = model;
                }
                else
                {
                    var url = $"{baseUrl}Phonebooks";

                    var res = await Helper.GetAsync<PhoneBookListResponse>(url);

                    if (res?.PhonebookDtos?.Count > 0)
                    {
                       var model = _mapper.Map<List<PhoneBookViewModel>>(res.PhonebookDtos);

                        ViewBag.PhoneBooks = model;
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View(new EntryViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> GetPhonebook(string Name)
        {
            try
            {
                if (string.IsNullOrEmpty(Name))
                {
                    TempData["Error"] = "Search string cannot be null";
                    return RedirectToAction("Index");
                }
                var url = $"{baseUrl}PhoneBook/Search/{Name}";

                var res = await Helper.GetAsync<List<PhonebookDto>>(url);

                if (res?.Count > 0)
                {
                    var model = _mapper.Map<List<PhoneBookViewModel>>(res);

                    TempData["SearchResults"] = JsonConvert.SerializeObject(model); 
                }
                else 
                {
                    TempData["Error"] = "No Results";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }
          
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(EntryViewModel entry)
        {
            try
            {
                //Use Automapper

                var entryDto = new EntryDto {
                    Name = entry.Name,
                    PhoneNumber = entry.PhoneNumber,
                    CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    CreatedDate = DateTime.Now
                };

                var phonebook = new PhonebookDto()
                {
                    Name = entry.Name,
                    Entries = new List<EntryDto>() { entryDto },
                    CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    CreatedDate = DateTime.Now
                };

                var url = $"{baseUrl}Phonebook";

                var res = await Helper.PostAsync<PhonebookDto, PhonebookDto>(url, phonebook);

                if (res?.Id > 0)
                    TempData["StatusMessage"] = $"{res.Name} added successfully";
                else
                    ModelState.AddModelError(string.Empty, "Something went wrong");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    /// <summary>
    /// Extension Class
    /// </summary>
    public class PhoneBookListResponse
    {
        public List<PhonebookDto> PhonebookDtos { get; set; } = new();
    }
}
