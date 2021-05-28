using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Exceptions;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet("{number}")]
        public IActionResult Exercise01(int number)
        {
            try
            {
                return Ok(_exerciseService.ResolveExercise01(number));
            }
            catch(InvalidInputException inputException)
            {
                return BadRequest(inputException.Message);
            }
            catch(Exception ex)
            {
                // TODO: Add exception to logger
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception ocurred, contact to help desk.");
            }
            
        }
    }
}
