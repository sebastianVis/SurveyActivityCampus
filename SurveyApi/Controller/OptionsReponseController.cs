using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SurveyApi.Controller;

public class OptionsReponseController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public OptionsReponseController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get()
    {
        var optionsResponses = await _unitOfWork.OptionsResponses.GetAllAsync();
        return Ok(optionsResponses);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var optionsResponse = await _unitOfWork.OptionsResponses.GetByIdAsync(id);
        if (optionsResponse == null)
        {
            return NotFound();
        }
        return Ok(optionsResponse);
    }
}