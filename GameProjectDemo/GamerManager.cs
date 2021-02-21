using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class GamerManager
    {
        public void Register (Gamer gamer) 
        {
            Console.WriteLine("Kullanıcı kaydedildi.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi.");
        }
        public void Delete (Gamer gamer )
        {
            Console.WriteLine("Kullanıcı silindi.");
        }
    }
}
