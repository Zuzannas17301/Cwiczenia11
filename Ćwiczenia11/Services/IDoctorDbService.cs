using System.Collections;
using System.Collections.Generic;
using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public IActionResult AddDoctor(AddDoctorRequest request);
        public IActionResult ModifyDoctor(ModifyDoctorRequest request);
        public IActionResult DeleteDoctor(DeleteDoctorRequest request);

    }
}