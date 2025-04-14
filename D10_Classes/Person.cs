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
            get { return name; }
            set { city = value; }
        }

        #endregion


        #region Auto-implemented

        public string VAT { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        #endregion

        #region Bodied-expression

        #endregion


        #endregion

        #region Constructors

        #endregion

        #region Methods

        #endregion


    }
}
