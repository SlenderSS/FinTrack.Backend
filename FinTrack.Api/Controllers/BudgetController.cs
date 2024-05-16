using AutoMapper;
using FinTrack.Api.Contracts;
using FinTrack.Api.Services.Implementations;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetService _budgetService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public BudgetController(IBudgetService budgetService, IUserService userService, IMapper mapper)
        {
            _budgetService = budgetService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("{userId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BudgetDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetBudgets(int userId)
        {
            var budgets = _mapper.Map<IEnumerable<BudgetDto>>(await _budgetService.GetBudgetsAsync(userId));
            
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(budgets);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public async Task<IActionResult> CreateBudget([FromQuery] int userId, [FromBody] BudgetDto budgetCreate)
        {
            if (budgetCreate == null)
                return BadRequest(ModelState);

            var budget = _mapper.Map<Budget>(budgetCreate);

            var user = await _userService.GetUserById(userId);
            budget.User = user.Value;

            var result = await _budgetService.CreateBudgetAsync(budget);
            if (result.IsFailure)
            {
                ModelState.AddModelError("", result.Error);
                return StatusCode(422, ModelState);
            }

            return Ok();
        }
    }
}
