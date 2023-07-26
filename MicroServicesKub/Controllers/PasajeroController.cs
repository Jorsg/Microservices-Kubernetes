using AutoMapper;
using MicroServicesKub.Dtos;
using MicroServicesKub.Interfaces;
using MicroServicesKub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MicroServicesKub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasajeroController : ControllerBase
    {
        private readonly IPasajero _pasajero;
        private readonly IMapper _mapper;

        public PasajeroController(IPasajero pasajero, IMapper mapper)
        {
            _pasajero = pasajero;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("--> Getting Platforms");
            var result = _pasajero.GetPasajeros();
            if(result is null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<PasajeroReadDto>>(result));
        }

        [HttpGet("id", Name = "GetPasajerobyId")]
        public ActionResult<PasajeroReadDto> GetPasajerobyId(int id)
        {
            Console.WriteLine("--> Getting Platforms");
            var result = _pasajero.GetPasajero(id);
            if (result is null)
                return NotFound();
            return Ok(_mapper.Map<PasajeroReadDto>(result));
        }

        [HttpPost]
        public IActionResult CreatePasajero(PasajeroCreateDto pasajeroCreateDto)
        {
            var pasajeroModel = _mapper.Map<Pasajero>(pasajeroCreateDto);
            try
            {
                var result = _pasajero.CrearPasajero(pasajeroModel);     
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound();
                throw new ArgumentNullException(nameof(ex.Message));
            }
        }
    }
}
