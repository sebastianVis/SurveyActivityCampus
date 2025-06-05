using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SurveyApi.Controller;

public class SubQuestionsController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public SubQuestionsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get()
    {
        var subQuestions = await _unitOfWork.SubQuestions.GetAllAsync();
        return Ok(subQuestions);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var subQuestion = await _unitOfWork.SubQuestions.GetByIdAsync(id);
        if (subQuestion == null)
        {
            return NotFound();
        }
        return Ok(subQuestion);
    }
}
