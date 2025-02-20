﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCard A1 = new CarCard("A1", "BMW Z8", 250, 4.7, 400, 4941, 8, 6600);
            CarCard A2 = new CarCard("A2", "MG Xpower SV Club Sport", 230, 4.2, 465, 4997, 8, 6450);
            CarCard A3 = new CarCard("A3", "Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500);
            CarCard A4 = new CarCard("A4", "Viper GTS", 285, 4.6, 411, 7990, 10, 5100);
            CarCard B1 = new CarCard("B1", "Ford GT", 325, 3.3, 550, 5403, 8, 5250);
            CarCard B2 = new CarCard("B2", "TVR Sagaris", 300, 3.9, 3966, 400, 8, 7000);
            CarCard B3 = new CarCard("B3", "Range Rover Sport", 225, 7.6, 390, 4197, 8, 5750);
            CarCard B4 = new CarCard("B4", "Rindspeed Chopster", 290, 4.4, 600, 4511, 8, 6700);
            CarCard C1 = new CarCard("C1", "Maserati Spyder", 283, 5.0, 390, 4244, 8, 7000);
            CarCard C2 = new CarCard("C2", "Toyota Celia", 205, 8.7, 143, 1794, 4, 6400);
            CarCard C3 = new CarCard("C3", "Porsche 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
            CarCard C4 = new CarCard("C4", "Corvette Coupe", 281, 5.2, 344, 5665, 8, 5400);
            CarCard D1 = new CarCard("D1", "Audi RS4", 250, 4.8, 420, 4163, 8, 7800);
            CarCard D2 = new CarCard("D2", "Audi RS 6 Plus", 280, 4.6, 480, 4172, 8, 6400);
            CarCard D3 = new CarCard("D3", "Nissan 350 Z", 250, 5.9, 280, 3498, 6, 6200);
            CarCard D4 = new CarCard("D4", "Mercedes CLK DTM AMG", 320, 4.0, 582, 5439, 8, 6100);
            CarCard E1 = new CarCard("E1", "Aston Martin V8 Vantage", 280, 5.0, 4282, 385, 8, 7000);
            CarCard E2 = new CarCard("E2", "Ferrari F50", 325, 3.9, 521, 4700, 12, 8500);
            CarCard E3 = new CarCard("E3", "BMW 645 Ci", 250, 5.6, 333, 4398, 7, 6100);
            CarCard E4 = new CarCard("E4", "Bentley Azure", 241, 6.7, 6750, 388, 8, 4000);
            CarCard F1 = new CarCard("F1", "Opel Astra Coupe 2.0", 245, 7.5, 192, 1998, 4, 5400);
            CarCard F2 = new CarCard("F2", "VW Golf R32", 248, 6.2, 250, 3189, 6, 6300);
            CarCard F3 = new CarCard("F3", "Chrysler Crossfire", 250, 6.9, 218, 3199, 6, 5700);
            CarCard F4 = new CarCard("F4", "Fisker Tramonto", 325, 3.6, 610, 5439, 8, 6100);
            CarCard G1 = new CarCard("G1", "Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750);
            CarCard G2 = new CarCard("G2", "Mercedes-Benz SL 500", 250, 6.3, 4966, 306, 8, 5600);
            CarCard G3 = new CarCard("G3", "Alfa Romeo Brera", 248, 6.3, 260, 3195, 6, 6200);
            CarCard G4 = new CarCard("G4", "Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250);
            CarCard H1 = new CarCard("H1", "BMW Z4", 250, 5.9, 2979, 231, 6, 5900);
            CarCard H2 = new CarCard("H2", "Alfa Romeo GT", 243, 6.7, 240, 3179, 6, 6400);
            CarCard H3 = new CarCard("H3", "Pontiac GTO", 280, 5.7, 5970, 400, 8, 5200);
            CarCard H4 = new CarCard("H4", "BMW M5", 250, 4.7, 4999, 507, 10, 7750);


            //WriteLine(C4.Compare(A3, CarCard.category.hp));
            List<CarCard> list = new List<CarCard>();
            for (int i = 1; i <= 8; i++)
            {
                switch (i)
                {
                    case 1:
                        list.Add(A1);
                        list.Add(A2);
                        list.Add(A3);
                        list.Add(A4);
                        break;
                    case 2:
                        list.Add(B1);
                        list.Add(B2);
                        list.Add(B3);
                        list.Add(B4);
                        break;
                    case 3:
                        list.Add(C1);
                        list.Add(C2);
                        list.Add(C3);
                        list.Add(C4);
                        break;
                    case 4:
                        list.Add(D1);
                        list.Add(D2);
                        list.Add(D3);
                        list.Add(D4);
                        break;
                    case 5:
                        list.Add(E1);
                        list.Add(E2);
                        list.Add(E3);
                        list.Add(E4);
                        break;
                    case 6:
                        list.Add(F1);
                        list.Add(F2);
                        list.Add(F3);
                        list.Add(F4);
                        break;
                    case 7:
                        list.Add(G1);
                        list.Add(G2);
                        list.Add(G3);
                        list.Add(G4);
                        break;
                    case 8:
                        list.Add(H1);
                        list.Add(H2);
                        list.Add(H3);
                        list.Add(H4);
                        break;

                }
            }
            Deck d = new Deck(list);
            //Console.ReadLine();

            CarCard car = new CarCard("", "", 0, 0, 0, 0, 0, 0);
            Random rand = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int a = rand.Next(0, list.Count);
                int b = rand.Next(0, list.Count);
                car = list[a];
                list[a] = list[b];
                list[b] = car;
            }

            d.updateDeck(list);
            Console.WriteLine(d.ToString());
            Console.ReadLine();
        }
    }
}
