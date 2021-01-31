using GameProject.Nesneler;
using GameProject.Soyutlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Somutlar
{
    class GamerManager : IGamerService
    {
        public List<int> count = new List<int>();
        public void Add(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                
            }
            
        }

        public void Delete(List<Gamer> gamers)
        {
            throw new NotImplementedException();
        }

        public void Update(List<Gamer> gamers)
        {
            throw new NotImplementedException();
        }

        internal void Add(List<Gamer> gamers)
        {
            throw new NotImplementedException();
        }
    }
}
