using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        public void Attack(int damage)
        {
            Console.WriteLine($"I attacked for {damage}!");

        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"I attacked with {weapon} for {damage}!");

        }

        public void Attack(int damage, string weapon, int hitTimes)
        {
            int totalDamage = damage * hitTimes;
            Console.WriteLine($"I attacked with {damage} {hitTimes} times for {totalDamage}!");
        }

        //Using return method example
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}