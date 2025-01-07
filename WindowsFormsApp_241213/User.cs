using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_241213
{
    internal class User : Character
    {
        public void Attack()
        { 
        }
        public void Defend()
        {
        }
        //int money;
        //public int Payment(int money)
        //{
        //    return this.money -= money;
        //}
        //public void ChoiceDrink()
        //{
        //}
        //public void GetDrink()
        //{ 
        //}
        //public void GetChange(int money)
        //{
        //    int change = money - VendingMachine.price;
        //}
    }
    internal class Wizard : User
    { 
    }

    internal class Warrior : User
    {
    }
}

//사용자
//클래스 - 사용자
//속성 - 돈
//기능 - 돈 내기, 음료 선택, 음료 받기, 거스름돈 받기
