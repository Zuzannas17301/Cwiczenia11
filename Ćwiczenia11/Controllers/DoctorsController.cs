using System.Linq;
using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using Cwiczenia11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorDbService _service;

        public DoctorsController(IDoctorDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_service.GetDoctors());
        }

        [HttpPost]
        public IActionResult AddDoctor(AddDoctorRequest request)
        {
            return Ok(_service.AddDoctor(request));
        }

        [HttpPut]
        public IActionResult ModifyDoctor(ModifyDoctorRequest request)
        {
            return Ok(_service.ModifyDoctor(request));
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(DeleteDoctorRequest request)
        {
            return Ok(_service.DeleteDoctor(request));
        }
    }
}