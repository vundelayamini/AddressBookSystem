﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddNewContact
{
    interface IContact
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);

    }
}
