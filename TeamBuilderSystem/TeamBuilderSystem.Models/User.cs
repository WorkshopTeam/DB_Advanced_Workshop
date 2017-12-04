namespace TeamBuilderSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using TeamBuilderSystem.Models.Enums;

    public class User
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string Username
        {
            get
            {
                return this.Username;
            }
            set
            {
                if (this.Username.Length < 3 || this.Username.Length > 25)
                {
                    throw new ArgumentException("Username must be in range [3-25] characters!");
                }
                this.Username = value;
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [MinLength(6)]
        public string Password
        {
            get
            {
                return this.Password;
            }
            set
            {
                if (this.Password.Length < 6 || this.Password.Length > 30)
                {
                    throw new ArgumentException("Passwod must be in range [6-30] characters!");
                }

                if (!(this.Password.Any(c => Char.IsDigit(c)) && this.Password.Any(c => Char.IsUpper(c))))
                {
                    throw new ArgumentException("Passwod should contain one digit and one uppercase letter!");
                }

                this.Password = value;
            }
        }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Event> CreatedEvents { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }

        public ICollection<UserTeam> CreatedUserTeams { get; set; }

        public int MyProperty { get; set; }
    }
}
