using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmsOfMayhem.Core.Entities
{
    public class Account
    {
        private string _username;
        private string _email;
        private string _passwordHash;

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsBanned { get; private set; } = false;

        public string Username
        {
            get => _username;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Username cannot be empty.");
                _username = value;
            }
        }

        public string Email
        {
            get => _email;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email cannot be empty.");
                _email = value;
            }
        }

        public string PasswordHash
        {
            get => _passwordHash;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Password cannot be empty.");
                _passwordHash = value;
            }
        }


        public Account(string username, string email, string passwordHash)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;
        }

        public void ChangePassword(string newPasswordHash)
        {
            if (string.IsNullOrWhiteSpace(newPasswordHash))
                throw new ArgumentException("Password cannot be empty.");

            PasswordHash = newPasswordHash;
        }

        public void BanAccount() => IsBanned = true;
        public void UnbanAccount() => IsBanned = false;
    }
}
}
