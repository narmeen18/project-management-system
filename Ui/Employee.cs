using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui
{
    class Employee
    {
        private int id;
        private string name;
        private string nic;
        private string status;
        private string salary;
        private byte[] image;


        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        public string Nic
        {
            get
            {
                return this.nic;
            }
            set
            {
                nic = value;
            }
        }
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                status = value;
            }
        }

        public string Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                salary = value;
            }
        }

        public byte[] Image
        {
            get
            {
                return this.image;
            }
            set
            {
                image = value;
            }
        }

    }
}

