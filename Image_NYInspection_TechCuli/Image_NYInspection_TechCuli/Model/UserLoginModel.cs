using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Model
{
    public class UserLoginModel
    {
        private int id;
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string time;
        private int phanquyen;
        private string Machine;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }
        public string Time { get => time; set => time = value; }
        public int Phanquyen { get => phanquyen; set => phanquyen = value; }
        public string Machine1 { get => Machine; set => Machine = value; }

        public UserLoginModel(int id, string username, string password, string firstName, string lastName, string time, int phanquyen, string machine)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Time = time;
            this.Phanquyen = phanquyen;
            this.Machine1 = machine;
        }
    }
}
