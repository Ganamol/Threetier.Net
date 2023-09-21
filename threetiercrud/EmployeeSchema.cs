using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace threetiercrud
{
    public class EmployeeSchema
    {
        private string _Name;
        private string _Address;
        private int _Age;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
      
        
    }
}