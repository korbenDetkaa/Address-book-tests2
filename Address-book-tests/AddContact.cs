﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_tests
{
    class AddContact
    {
        private string firstname;
        private string lastname;
        
        public AddContact(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;   
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
    }
}
