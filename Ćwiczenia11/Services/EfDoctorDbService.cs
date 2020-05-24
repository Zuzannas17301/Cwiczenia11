using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Services
{
    public class EfDoctorDbService : IDoctorDbService
    {
        private readonly DoctorsDbContex _contex;
        
        public EfDoctorDbService(DoctorsDbContex contex)
        {
            _contex = contex;
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return _contex.Doctors.ToList();
        }
        

        public IActionResult AddDoctor(AddDoctorRequest request){
        var newDoctor=  _contex.Doctors.Add(new Doctor()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email
                });

                _contex.SaveChanges();
                return new CreatedAtActionResult("Add Doctor", "DoctorsController",new {idDoctor = newDoctor.Entity.IdDoctor} ,newDoctor);
        }

        public IActionResult ModifyDoctor(ModifyDoctorRequest request)
        {
            var res = _contex.Doctors.Where(e => e.IdDoctor == request.IdDoctor).SingleOrDefault();

            if (res != null)
            {
                res.FirstName = request.FirstName;
                res.LastName = request.LastName;
                res.Email = request.Email;
            }
            else
            {
                return new BadRequestResult();
            }
            _contex.SaveChanges();
            return new OkObjectResult(res);
        }

        public IActionResult DeleteDoctor(DeleteDoctorRequest request)
        {
            var prescriptions = _contex.Prescription.Where(e => e.IdDoctor == request.IdDoctor).ToList();
            var prescriptionMedicamentList = new ArrayList();
            foreach (Prescription prescription in prescriptions)
            {
                prescriptionMedicamentList.Add(
                    _contex.PrescriptionMedicaments.Where(e => e.IdPrescription == prescription.IdPrescription));
            }

            foreach (Prescription_Medicament prescriptionMedicament in prescriptionMedicamentList)
            {
                _contex.Remove(prescriptionMedicament);
            }

            foreach (Prescription prescription in prescriptions)
            {
                _contex.Remove(prescription);
            }

            _contex.Remove(_contex.Doctors.Where(e => e.IdDoctor == request.IdDoctor).ToList().First());
            _contex.SaveChanges();

            return new OkObjectResult("Pomyślnie usunięto doktora wra ze wszystkimi wystawionymi przez niego receptami");
        }
    }
    }
