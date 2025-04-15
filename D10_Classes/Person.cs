using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D10_Classes
{
    internal class Person
    {

        #region Fields (variáveis privadas das propriedades)

        private string name;
        private string city;
        private string country;

        #endregion

        #region Propeties

        #region Classic

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        #endregion


        #region Auto-implemented

        public long VAT { get; set; }
        public int ID { get; set; }

        public string Adress { get; set; }
        public string Phone { get; set; }

        #endregion

        #region Bodied-expression
        public string Country
        {
            get => country;                 // '=>'lambda operator   
            set => country = value;
        }
        #endregion


        #endregion

        #region Constructors
        public Person()
        {
            ID = 0;
            Name = "";
           // VAT = string.Empty;
            Adress = "";
            City = "";
            Country = "";
        }
        public Person(int id, string name, long vat, string phone, string adress, string city, string country)
        {
            ID = id;
            Name = name;
            VAT = vat;
            Phone = phone;
            Adress = adress;
            City = city;
            Country = country;

        }
        public Person(int id, string name)
        {
            ID = id;
            Name = Name;
        }
        #endregion

        #region Methods (public internal)

        public void PersonReadData()
        {



            //Utility.WriteTitle("Person- Read data");
            //Utility.WriteMessage("ID: ","" ,"");
            // ID = Convert.ToInt16(Console.ReadLine());
            // implementar validação com tryparse
            /*

             bool valid;
             int id;
             do
             {
                 Console.Clear();
                 Utility.WriteTitle("Person- Read data");
                 Utility.WriteMessage("ID: ", "", "");
                 valid = int.TryParse(Console.ReadLine(), out id);
             }
             while (valid != true);

             Utility.WriteMessage("Name: ");
             Name = Console.ReadLine();
             Utility.WriteMessage("VAT: ");
             VAT = Console.ReadLine();
             Utility.WriteMessage("Phone: ");
             Phone = Console.ReadLine();
             Utility.WriteMessage("Adress: ");
             Adress = Console.ReadLine();
             Utility.WriteMessage("City: ");
             City = Console.ReadLine();
             Utility.WriteMessage("Country: ");
             Country = Console.ReadLine();
            */
        }
        public void PersonWriteData()
        {

            Utility.WriteTitle("Person- Write data");
            Utility.WriteMessage($"ID: {ID}", "", "\n");
            Utility.WriteMessage($"Name: {Name}", "", "\n");
            Utility.WriteMessage($"Vat: {VAT}", "", "\n");
            Utility.WriteMessage($"phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Adress: {Adress}", "", "\n");
            Utility.WriteMessage($"City: {City}", "", "\n");
            Utility.WriteMessage($"Country: {Country}", "", "\n");



        }
        #endregion


        public int ValidadeID()
        {
            int id;
            while (true)
            {
                Utility.WriteMessage("ID: ", "");
                string input = Console.ReadLine();
                if (int.TryParse(input, out id))
                {
                    return id;
                }
                else
                {
                    Utility.WriteErrorMessage("IS tem de ser número inteiro!", "\n");
                }

            }
        }


        public void PersonReadDataWithValidation()
        {
            Utility.WriteTitle("Person - read data with validation", "");

            ID = ValidadeID();

            Utility.WriteMessage("Name= ");
            Name = Console.ReadLine();

            VAT = ValidateVAT();

            Utility.WriteMessage("Phone= ");
            Phone = Console.ReadLine();

            Utility.WriteMessage("Address= ");
            Adress = Console.ReadLine();

            Utility.WriteMessage("City= ");
            City = Console.ReadLine();

            Utility.WriteMessage("Country= ");
            Country = Console.ReadLine();
        }
        public long ValidateVAT()
        {
            long vat;
            while (true)
            {
                Utility.WriteMessage("VAT: ", "");
                string input = Console.ReadLine();
                if (long.TryParse(input, out vat))
                {
                    if (input.Length == 9)
                    {
                        return vat;
                    }
                    else
                    {
                        Utility.WriteErrorMessage("O VAT deve ter apenas 9 números!","\n","\n");
                    }
                }
                else
                {
                    Utility.WriteErrorMessage("O VAT deve ter apenas 9 números!", "\n", "\n");
                }

            }


        }
    }
}
