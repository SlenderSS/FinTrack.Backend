using AutoMapper;
using FinTrack.Api.Contracts.Income;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;
        private readonly IBudgetService _budgetService;
        private readonly IMapper _mapper;

        public IncomeController(IIncomeService incomeService, IBudgetService budgetService, IMapper mapper)
        {
            _incomeService = incomeService;
            _budgetService = budgetService;
            _mapper = mapper;
        }

        [HttpGet("{budgetId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReadIncomeDto>))]
        public async Task<IActionResult> GetIncomes(int budgetId)
        {
            var incomes = await _incomeService.GetIncomesAsync(budgetId);

            var incomesMap = _mapper.Map<IEnumerable<ReadIncomeDto>>(incomes.Value.ToList());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(incomesMap);
        }



        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public async Task<IActionResult> CreateIncome([FromQuery] int budgetId, [FromBody] ReadIncomeDto incomeCreate)
        {
            if (incomeCreate == null)
                return BadRequest(ModelState);

            var category = _mapper.Map<Income>(incomeCreate);

            var budget = await _budgetService.GetBudgetAsync(budgetId);

            category.Budget = budget.Value;

            var result = await _incomeService.CreateIncomeAsync(category);
            if (result.IsFailure)
            {
                ModelState.AddModelError("", result.Error);
                return StatusCode(422, ModelState);
            }

            return Ok();
        }


        [HttpGet("{incomeId}")]
        [ProducesResponseType(200, Type = typeof(ReadIncomeDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetIncome(int incomeId)
        {
            var incomeMap = _mapper.Map<ReadIncomeDto>(await _incomeService.GetIncomeAsync(incomeId));
            if(!ModelState.IsValid) 
            { 
                return BadRequest(ModelState);
            }
            return Ok(incomeMap);

        }
    }
}
