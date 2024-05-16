using AutoMapper;
using FinTrack.Api.Contracts;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseCategoryController : ControllerBase
    {
        private readonly IExpenseCategoryService _expenseCategoryService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public ExpenseCategoryController(IExpenseCategoryService expenseCategoryService,IUserService userService, IMapper mapper)
        {
            _expenseCategoryService = expenseCategoryService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("{userId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ExpenseCategoryDto>))]
        public async Task<IActionResult> GeExpenseCategories(int userId)
        {
            var categories = await _expenseCategoryService.GetExpenseCategoriesAsync(userId);
            if (categories.IsFailure)
            {
                return NotFound();
            }

            var categoriesMap = _mapper.Map<IEnumerable<ExpenseCategoryDto>>(categories.Value.ToList());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(categoriesMap);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(422)]
        public async Task<IActionResult> CreateExpenseCategory([FromQuery] int userId,[FromBody] ExpenseCategoryDto expenseCategoryCreate)
        {
            if (expenseCategoryCreate == null)
                return BadRequest(ModelState);

            var category = _mapper.Map<ExpenseCategory>(expenseCategoryCreate);
            
            var user = await _userService.GetUserById(userId);

            category.User = user.Value;

            var result = await _expenseCategoryService.CreateExpenseCategoryAsync(category);
            if (result.IsFailure)
            {
                ModelState.AddModelError("", result.Error);
                return StatusCode(422, ModelState);
            }

            return Ok();
        }
    }
}
