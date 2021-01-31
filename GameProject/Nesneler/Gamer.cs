using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Nesneler
{
    class Gamer 
        
    {
        public Gamer(int id,string Adi,string Soyadi,int Yas,string tcNo,string Nick)
        {
            Id = id;
            FirstName = Adi;
            Surname = Soyadi;
            Age = Yas;
            TcNo = tcNo;
            NickName = Nick;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age{ get; set; }
        public string TcNo { get; set; }
        public string NickName { get; set; }
    }
}
