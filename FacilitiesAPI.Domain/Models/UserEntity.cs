﻿namespace FacilitiesAPI.Domain.Models
{
    public class UserEntity : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? Role { get; set; } = string.Empty;
    }
}
