using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SurveyApi.Controller;

public class SurveysController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public SurveysController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get()
    {
        var surveys = await _unitOfWork.Surveys.GetAllAsync();
        return Ok(surveys);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var survey = await _unitOfWork.Surveys.GetByIdAsync(id);
        if (survey == null)
        {
            return NotFound();
        }
        return Ok(survey);
    }
}
