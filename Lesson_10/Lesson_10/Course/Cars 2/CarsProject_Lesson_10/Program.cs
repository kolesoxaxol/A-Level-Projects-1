using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarClass;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;
            ConsoleKeyInfo pressedKey;

            bool flag = true;
            int carCount = 0;
            bool insurance = false;
            int carryingCapacity = 0;
            int carCapacity = 0;
            int mileage = 0;
            int price;

            while (flag)
            {
                Console.Write("Укажите тип добавляемого автомобиля 1 - грузовик, 2 - минивен: ");
                pressedKey = Console.ReadKey();
                string carType;

                switch (pressedKey.Key.ToString())
                {
                    case "D1":
                        carType = "truck";
                        break;

                    case "D2":
                        carType = "minivan";
                        break;

                    default:
                        carType = "truck";
                        break;
                }
                Console.WriteLine();

                Console.Write("Введите модель автомобиля: ");
                string modele = Console.ReadLine().Trim();

                Console.Write("Введите цвет автомобиля: ");
                string color = Console.ReadLine().Trim();

                string carryingCapacityStr;

                string carCapacityStr;

                switch (carType)
                {
                    case "truck":
                        do
                        {
                            Console.Write("Введите грузоподъёмность автомобиля: ");
                            carryingCapacityStr = Console.ReadLine();
                        } while (!int.TryParse(carryingCapacityStr, out carryingCapacity));

                        Console.Write("Укажите наличие страховки \"YES\" или \"NO\": ");
                        string insuranceLine = Console.ReadLine().Trim();

                        switch (insuranceLine)
                        {
                            case "YES":
                                insurance = true;
                                break;

                            case "NO":
                                insurance = false;
                                break;

                            default:
                                insurance = false;
                                break;
                        }


                        string mileageStr;

                        do
                        {
                            Console.Write("Введите пробег автомобиля: ");
                            mileageStr = Console.ReadLine();
                        } while (!int.TryParse(mileageStr, out mileage));

                        break;

                    case "minivan":
                        do
                        {
                            Console.Write("Введите вместительность пассажиров автомобиля: ");
                            carCapacityStr = Console.ReadLine();
                        } while (!int.TryParse(carCapacityStr, out carCapacity));
                        break;
                }

                string priceStr;

                do
                {
                    Console.Write("Введите цену автомобиля: ");
                    priceStr = Console.ReadLine();
                } while (!int.TryParse(priceStr, out price));

                switch (carType)
                {
                    case "truck":
                        Truck truck = new Truck(modele, color, carryingCapacity, insurance, mileage, price);
                        CarsKeeper.AddCar(truck);
                        break;

                    case "minivan":
                        Minivan minivan = new Minivan(modele, color, carCapacity, price);
                        CarsKeeper.AddCar(minivan);
                        break;
                }

                Console.WriteLine("Автомобиль добавлен.");
                Console.WriteLine(new string('-', 50));
                
                carCount++;

                if (carCount >= 3) // магические числа в коде выноси это в отдельную переменую с самодокументируемым названием
                {
                    Console.WriteLine("Максимальный лимит в магазине - 3 автомобиля.");
                    break;
                }
            }

            Console.WriteLine("Желаете просмотреть все автомобили? Нажмите \"Y\" - ДА, \"N\" - НЕТ.");
            pressedKey = Console.ReadKey(true);

            switch (pressedKey.Key.ToString())
            {
                case "Y":
                    var savedCars = CarsKeeper.GetCars;

                    foreach (Car myCar in savedCars)
                    {
                        Console.WriteLine($"Название автомобиля: {myCar.Modele}, Тип автомобиля: {myCar.Type}, Цвет автомобиля: {myCar.Color}, Цена автомобиля: {myCar.Price}$, Текущая скидка на автомобиль: {myCar.Discount}%");
                       // попрбуй еще string.Format для вывода строк чисто для расширения кругозора
                    }
                    break;

                case "N":
                    break;
            }

            Console.ReadKey();
        }
    }
}
