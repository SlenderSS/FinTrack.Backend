using AutoMapper;
using FinTrack.Api.Contracts.Expense;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;
        private readonly IBudgetService _budgetService;
        private readonly IMapper _mapper;

        public ExpenseController(IExpenseService expenseService, IBudgetService budgetService, IMapper mapper)
        {
            _expenseService = expenseService;
            _budgetService = budgetService;
            _mapper = mapper;
        }

        [HttpGet("{budgetId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReadExpenseDto>))]
        public async Task<IActionResult> GetExpenses(int budgetId)
        {
            var expenses = await _expenseService.GetExpensesAsync(budgetId);

            var expensesMap = _mapper.Map<IEnumerable<ReadExpenseDto>>(expenses.Value.ToList());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(expensesMap);
        }



        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public async Task<IActionResult> CreateExpense([FromQuery] int budgetId, [FromBody] ReadExpenseDto expenseCreate)
        {
            if (expenseCreate == null)
                return BadRequest(ModelState);

            var category = _mapper.Map<Expense>(expenseCreate);

            var budget = await _budgetService.GetBudgetAsync(budgetId);

            category.Budget = budget.Value;

            var result = await _expenseService.CreateExpenseAsync(category);
            if (result.IsFailure)
            {
                ModelState.AddModelError("", result.Error);
                return StatusCode(422, ModelState);
            }

            return Ok();
        }


        [HttpGet("{expenseId}")]
        [ProducesResponseType(200, Type = typeof(ReadExpenseDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetExpense(int expenseId)
        {
            var expenseMap = _mapper.Map<ReadExpenseDto>(await _expenseService.GetExpenseAsync(expenseId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(expenseMap);

        }
    }
}
