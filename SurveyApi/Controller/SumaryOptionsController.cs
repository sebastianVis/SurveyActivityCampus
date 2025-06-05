using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SurveyApi.Controller;

public class SumaryOptionsController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public SumaryOptionsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get()
    {
        var summaryOptions = await _unitOfWork.SumaryOptions.GetAllAsync();
        return Ok(summaryOptions);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var summaryOption = await _unitOfWork.SumaryOptions.GetByIdAsync(id);
        if (summaryOption == null)
        {
            return NotFound();
        }
        return Ok(summaryOption);
    }
}
