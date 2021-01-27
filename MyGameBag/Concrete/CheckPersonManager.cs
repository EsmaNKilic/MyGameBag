using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBag
{
    public class CheckPersonManager : ICheckPerson
    {
        public bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
