using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class UsersVM
    {
        public struct User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
            public List<string> RegionsPermissions { get; set; }
            public List<string> ShelterPermissions { get; set; }
            public List<string> EventsPermissions { get; set; }
            public List<string> TrailsPermissions { get; set; }
        }

        public List<User> AllUsers { get; set; }

        public User CurrentUser { get; set; }
        public List<string> AllawedRoles { get; set; }
    }
}
