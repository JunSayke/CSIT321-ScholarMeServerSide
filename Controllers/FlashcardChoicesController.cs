﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScholarMeServer.DTO.FlashcardChoice;
using ScholarMeServer.Services.FlashcardChoiceInfo;

namespace ScholarMeServer.Controllers
{
    [ApiController]
    [Route("api/flashcards")]
    [Authorize]
    public class FlashcardChoicesController : ControllerBase
    {
        private readonly IFlashcardChoiceService _flashcardChoiceService;

        public FlashcardChoicesController(IFlashcardChoiceService flashcardChoiceService)
        {
            _flashcardChoiceService = flashcardChoiceService;
        }

        [HttpPost("cards/{flashcardId}/choices")]
        public async Task<IActionResult> CreateFlashcardChoice([FromRoute] int flashcardId, [FromBody] FlashcardChoiceCreateDto flashcardChoiceDto)
        {
            var createdFlashcardChoice = await _flashcardChoiceService.CreateFlashcardChoice(flashcardId, flashcardChoiceDto);
            return CreatedAtRoute("GetFlashcardChoiceById", new { id = createdFlashcardChoice.Id }, createdFlashcardChoice);
        }

        [HttpGet("cards/{flashcardId}/choices")]
        public async Task<IActionResult> GetFlashcardChoicesByCardId([FromRoute] int flashcardId)
        {
            var flashcardChoices = await _flashcardChoiceService.GetFlashcardChoicesByCardId(flashcardId);
            return Ok(flashcardChoices);
        }

        [HttpGet("choices/{flashcardChoiceId:int}", Name = "GetFlashcardChoiceById")]
        public async Task<IActionResult> GetFlashcardChoiceById([FromRoute] int flashcardChoiceId)
        {
            var flashcardChoice = await _flashcardChoiceService.GetFlashcardChoiceById(flashcardChoiceId);
            return Ok(flashcardChoice);
        }

        [HttpPut("choices/{flashcardChoiceId:int}")]
        public async Task<IActionResult> UpdateFlashcardChoice([FromRoute] int flashcardChoiceId, [FromBody] FlashcardChoiceUpdateDto flashcardChoiceDto)
        {
            var updatedFlashcardChoice = await _flashcardChoiceService.UpdateFlashcardChoice(flashcardChoiceId, flashcardChoiceDto);
            return Ok(updatedFlashcardChoice);
        }

        [HttpDelete("choices/{flashcardChoiceId:int}")]
        public async Task<IActionResult> DeleteFlashcardChoice([FromRoute] int flashcardChoiceId)
        {
            await _flashcardChoiceService.DeleteFlashcardChoice(flashcardChoiceId);
            return NoContent();
        }
    }
}
