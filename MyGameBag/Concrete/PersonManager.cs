using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBag
{
    public class PersonManager : IUsersService
    {
        private ICheckPerson _checkPerson;
        public PersonManager(ICheckPerson checkPerson)
        {
            _checkPerson = checkPerson;
        }

        public void Add(Person person)
        {
            if (_checkPerson.CheckPerson(person))
            {
                Console.WriteLine(person.Name + " " + person.Surname + " da aramıza katıldı. HOŞGELDİN!!");
            } 
            else
            {
                throw new Exception("Kullanıcı bulunamadı"); //uyarı kutucuğu
            }
            
        }

        public void Delete(Person person)
        {
            Console.WriteLine(person.Name + person.Surname + " aramızdan ayrıldı :(");
        }

        public void Update(Person person)
        {
            Console.WriteLine(person.Name + person.Surname + " kendini güncelledi :)");
        }

    }
}
