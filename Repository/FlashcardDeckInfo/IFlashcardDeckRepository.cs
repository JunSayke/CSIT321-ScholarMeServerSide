﻿using RestTest.Models;

namespace ScholarMeServer.Repository.FlashcardDeckInfo
{
    public interface IFlashcardDeckRepository
    {
        public Task AddFlashcardDeck(FlashcardDeck flashcardDeck);
        public Task<List<FlashcardDeck>> GetFlashcardDecksByUserId(Guid userAccountId);
        public Task<FlashcardDeck?> GetFlashcardDeckById(Guid flashcardDeckId, bool includeFlashcards = false);
        public Task SaveFlashcardDeck(FlashcardDeck flashcardDeck);
        public Task DeleteFlashcardDeck(FlashcardDeck flashcardDeck);
        public Task<List<FlashcardDeck>> GetAllFlashcardDecks(bool includeFlashcards = false);

    }
}
    