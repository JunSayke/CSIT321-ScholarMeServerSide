﻿namespace ScholarMeServer.DTO.UserAccount
{
    // User Details
    public class UserAccountReadOnlyDto
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
