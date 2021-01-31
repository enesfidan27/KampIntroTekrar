using GameProject.Nesneler;
using GameProject.Soyutlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Somutlar
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TcNo == "31534653" && gamer.FirstName == "Tuna" && gamer.Surname == "Tavus" && gamer.Age ==21)
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.Surname+" "+ "Doğrulama Başarılı!");
                return true; 
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.Surname + " > Doğrulama Geçersiz");
            }
            return false;
        }
    }
}
