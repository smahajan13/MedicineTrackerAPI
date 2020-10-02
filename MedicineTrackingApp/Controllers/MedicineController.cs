using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineTrackingApp.Service;
using MedicineTrackingApp.ViewModal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MedicineTrackingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicineController : ControllerBase
    {
        public readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        [Route("GetMedicineList")]
        [HttpGet]
        public IActionResult GetMedicines()
        {
            try
            {
                var result = _medicineService.GetMedicinesList();
                if (result.Count > 0)
                {
                    var response = new Response
                    {
                        Data = result,
                        Message = "Medicines returned successfully"
                    };
                    return Ok(response);
                }
                else
                {
                    var response = new Response
                    {
                        Message = "No Data Found"
                    };
                    return Ok(response);
                }
            }
            catch(Exception ex)
            {
                var response = new Response
                {
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }

        [Route("GetMedicineDetails")]
        [HttpPost]
        public IActionResult GetMedicinesDetails([FromBody] ViewMedicineViewModel model)
        {
            try
            {
                var result = _medicineService.GetMedicineDetails(model);
                if (result != null)
                {
                    var response = new Response
                    {
                        Data = result,
                        Message = "Medicine details returned successfully"
                    };
                    return Ok(response);
                }
                else
                {
                    var response = new Response
                    {
                        Message = "No Data Found"
                    };
                    return BadRequest(response);
                }
            }
            catch(Exception ex)
            {
                var response = new Response
                {
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }
        [Route("addMedicine")]
        [HttpPost]
        public IActionResult AddMedicinesDetails([FromBody] MedicineViewModel model)
        {
            try
            {
                var result = _medicineService.AddMedicineDetails(model);
                if (result)
                {
                    var response = new Response
                    {
                        Data = result,
                        Message = "Medicine is added successfully"
                    };
                    return Ok(response);
                }
                else
                {
                    var response = new Response
                    {
                        Data = result,
                        Message = "Cannot add medicine with expiry date less than 15 days."
                    };
                    return BadRequest(response);

                }
            }
            catch (Exception ex)
            {
                var response = new Response
                {
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }
        [Route("updateMedicineRoute")]
        [HttpPost]
        public IActionResult updateMedicinesDetails([FromBody] UpdateMedicineViewModel model)
        {
            try
            {
                var result = _medicineService.UpdateMedicineDetails(model);
                if (result)
                {
                    var response = new Response
                    {
                        Data = result,
                        Message = "Medicine Notes are updated successfully"
                    };
                    return Ok(response);
                }
                else
                {
                    var response = new Response
                    {
                        Data = result,
                        Message = "Cannot update medicine."
                    };
                    return BadRequest(response);
                }
            }
            catch (Exception ex)
            {
                var response = new Response
                {
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }
    }
}
