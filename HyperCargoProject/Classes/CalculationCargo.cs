using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperCargoProject.UsersControl;

namespace HyperCargoProject.Classes
{
    class CalculationCargo
    {

        static int intVolume = 0;
        const int minVolume = 2;
        // денег за 1 км
        const int kmlitres = 150;
        // минимальный заказ
        const int minSummZakaz = 1250;
        static int price = 0;

        public static void FindCity(int Lenght, int Width, int Height, string FirstCity, string SecondCity)
        {
            int km = 0;
            if((FirstCity == "Казань" && SecondCity == "Москва") || (FirstCity == "Москва" && SecondCity == "Казань"))
            {
                km = 872;
                CalcCargo(Lenght, Width, Height, km);
            }
            else
            {
                MessageBox.Show("В каком-то из этих городов нет терминала нашей компании");
            }
        }

        public static void CalcCargo(int Lenght, int Width, int Height, int km)
        {
            if (minVolume < intVolume)
            {
                MessageBox.Show("Груз должен быть больше, чем 2 кубических метров");
            }
            else
            {
                intVolume = Lenght * Width * Height;
                price = (intVolume + minSummZakaz + kmlitres);
                ucCalculatonCargo.Result = price;
                intVolume = 0;
            }
        }
    }
}
