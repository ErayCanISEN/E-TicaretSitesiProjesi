﻿namespace Entities.Dtos.UserDtos
{
    public class UserDetailDto
    {
       

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}