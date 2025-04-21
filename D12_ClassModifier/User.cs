using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;


namespace D12_ClassModifier
{
    internal class User
    {
        #region Properties
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Department { get; set; }
        internal DateTime RegistrationDate { get; set; }
        internal string Username { get; set; }
        internal string Password { get; set; }

        #endregion

        #region Constructor
        internal User()
        {
            Id = 1;
            Name = string.Empty;
            Department = string.Empty;
            RegistrationDate = DateTime.Today;
            Username = string.Empty;
            Password = string.Empty;
        }

        internal User(int id, string name, string department, DateTime registrationDate, string username, string password)
        {
            Id = id;
            Name = name;
            Department = department;
            RegistrationDate = registrationDate;
            Username = username;
            Password = password;
        }

        #endregion

        #region MyRegion
        Utility utility01 = new Utility();
        internal void createUser()
        {
            Utility.WriteTitle("Create User", "");

           // Id = ValidateId();
            //TODO: fix this  Id = Utility.ValidateInt("ID");
            Id = utility01.ValidateInt("Id");

            Utility.WriteMessage("Name= ");
            Name = Console.ReadLine();


            Utility.WriteMessage("Department= ");
            Department = Console.ReadLine();

            RegistrationDate = utility01.ValidateDate("Registration Date");

            Utility.WriteMessage("Username= ");
            Username = Console.ReadLine();

            Utility.WriteMessage("Password= ");
            Password = Console.ReadLine();

        }

   

       

        public void ListarUser()
        {
            Utility.WriteTitle("Listagem de Users","\n");
            Utility.WriteMessage($"User ID: {Id}", "\n");
            Utility.WriteMessage($"Name: {Name}", "\n");
            Utility.WriteMessage($"Department: {Department}", "\n");
            Utility.WriteMessage($"Registration Date: {RegistrationDate}", "\n");
            Utility.WriteMessage($"Username: {Username}", "\n");
            Utility.WriteMessage($"Password: {Password}", "\n");


        }



        #endregion
    }
}
