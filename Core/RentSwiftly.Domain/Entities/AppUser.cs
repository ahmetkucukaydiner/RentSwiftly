﻿namespace RentSwiftly.Domain.Entities
{
    public class AppUser
    {
        public int AppUserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AppRoleID { get; set; }
        public AppRole AppRole { get; set; }
        public string Email { get; set; }
    }
}
