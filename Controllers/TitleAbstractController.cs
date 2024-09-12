using System;
using abstractmaker_api.Models;
using abstractmaker_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace abstractmaker_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TitleAbstractController : ControllerBase
{
    private ITitleAbstractRepository _titleAbstractRepository;

    public TitleAbstractController(ITitleAbstractRepository titleAbstractRepository)
    {
        _titleAbstractRepository = titleAbstractRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TitleAbstract>>> GetAllAsync()
    {
        var allTitleAbstracts = await _titleAbstractRepository.GetAllAsync();

        return Ok(allTitleAbstracts);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TitleAbstract>> GetTitleAbstractById(int id)
    {
        var titleAbstract = await _titleAbstractRepository.GetByIdAsync(id);

        if (titleAbstract == null)
        {
            return NotFound();
        }

        return Ok(titleAbstract);
    }

    [HttpPost]
    public async Task<ActionResult<TitleAbstract>> CreateTitleAbstract(TitleAbstract titleAbstract)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest();
        }

        await _titleAbstractRepository.AddTitleAbstractAsync(titleAbstract);
        return CreatedAtAction(nameof(GetTitleAbstractById), new { id = titleAbstract.TitleAbstractID }, titleAbstract);
    }
}
