using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SurveyApi.Controller;

public class ChaptersController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public ChaptersController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get()
    {
        var chapters = await _unitOfWork.Chapters.GetAllAsync();
        return Ok(chapters);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var chapter = await _unitOfWork.Chapters.GetByIdAsync(id);
        if (chapter == null)
        {
            return NotFound();
        }
        return Ok(chapter);
    }


}
