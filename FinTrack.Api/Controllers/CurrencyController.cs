using AutoMapper;
using FinTrack.Api.Contracts;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public CurrencyController(ICurrencyService currencyService, IMapper mapper)
        {
            _currencyService = currencyService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CurrencyDto>))]
        public async Task<IActionResult> GetCurrencies()
        {
            var currencies = await _currencyService.GetCurrenciess();
            if (currencies.IsFailure)
            {
                return NotFound();
            }

            var currenciesMap = _mapper.Map<IEnumerable<CurrencyDto>>(currencies.Value.ToList());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(currenciesMap);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public async Task<IActionResult> CreateCurrency(CurrencyDto currencyDto)
        {
            if (currencyDto == null)
                return BadRequest(ModelState);

            var currency = _mapper.Map<Currency>(currencyDto);

            var result = await _currencyService.CreateCurrency(currency);
            if (result.IsFailure)
            {
                ModelState.AddModelError("", result.Error);
                return StatusCode(422, ModelState);
            }

            return Ok();
        }
    }
}
