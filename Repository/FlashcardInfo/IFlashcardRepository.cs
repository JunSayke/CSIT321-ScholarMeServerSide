﻿using RestTest.Models;

namespace ScholarMeServer.Repository.FlashcardInfo
{
    public interface IFlashcardRepository
    {
        public Task AddFlashcard(Flashcard flashcard);
        public Task<List<Flashcard>> GetFlashcardsByDeckId(int flashcardDeckId);
        public Task<Flashcard?> GetFlashcardById(int flashcardId);
        public Task DeleteFlashcard(Flashcard flashcard);
        public Task SaveFlashcard(Flashcard flashcard);

        // Added because the user may want to change the deck of a flashcard and therefore we need to check if the deck exists
        public Task<bool> FlashcardDeckExists(int flashcardDeckId);
    }
}
