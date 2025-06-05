using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SurveyApi.Controller;

public class OptionQuestionsController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public OptionQuestionsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get()
    {
        var optionQuestions = await _unitOfWork.OptionQuestions.GetAllAsync();
        return Ok(optionQuestions);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var optionQuestion = await _unitOfWork.OptionQuestions.GetByIdAsync(id);
        if (optionQuestion == null)
        {
            return NotFound();
        }
        return Ok(optionQuestion);
    }
}
