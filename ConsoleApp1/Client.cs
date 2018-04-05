using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Client
    {
        private string name;
        private string surname;

        private Client(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
