using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_241213
{
    internal class VendingMachine
    {
        int machineMoney;
        int price;
        int drink;
        public int GetMoney(int money)
        {
            return machineMoney += money;
        }
        public void GiveDrink()
        { 
        }
        public void GiveChange()
        {
        }
        public void AddDrink()
        {
        }
        public void AddMoney()
        {
        }
    }
}

//자판기
//클래스 - 자판기
//속성 - 돈, 가격, 거스름돈, 음료 재고
//기능 - 돈 받기, 음료 주기, 거스름돈 주기, 음료 재고 추가, 돈 추가
