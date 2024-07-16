using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class User
    {
        private string username;
        private string email;
        private string password;
        private string address;
        private string contactNumber;

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }

        public User(string username, string email, string password, string address, string contactNumber)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.address = address;
            this.contactNumber = contactNumber;
        }

        public override string ToString()
        {
            return $"{{Username: {Username}, Email: {Email}, Password: {Password}, Address: {Address}, Contact Number: {ContactNumber}}}";
        }
    }
}
