using GameProject.Nesneler;
using GameProject.Somutlar;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer(123, "Serdar", "Aktolga", 56, "42356273", "Cacik");
            Gamer gamer2 = new Gamer(124, "Tuna", "Tavus", 21, "31534653", "Mutasyon Tuna");
        
        List<Gamer> gamers = new List<Gamer>(){ gamer1, gamer2 };
        
        GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamers);
        }
    }
}
