using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText
{
    public class Creatures
    {
        //public Creatures(string Name, int Hp, int Atk)
        //{
        //    List<string> Creatures = ["Spider"];
        //    Hp = 5;
        //    Atk = 1;
        //}

        List<string> WeakNames = ["Spider", "Slime", "Thug"]; 
        int WeakHP = 5;
        int WeakAtk = 1;

        public void RngWeakName()
        {

        }


        public List<string> Name { get; set; }
        int Hp { get; set; }
        int atk { get; set; }
    }
}
