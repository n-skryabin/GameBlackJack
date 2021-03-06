﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBlackJack
{
    class Player
    {
        static public int I;
        static private int sum = 0;
        public static List<Card> Hand = new List<Card>();
        Game gm = new Game();
        Random rd = new Random();
        Deck dc = new Deck();

        public static int Sum { get => sum; set => sum = value; }
      

        public void Extradition() //выдача карты
        {                           
            TakeKard();
            if (Hand[I] != null)
            {
                Console.WriteLine("Your card: {0} {1}", Hand[I].Suit, Hand[I].Face);
                I++;
            }
        }

        public void TakeKard() //берем карту 
        {
            Hand.Add(dc.DrowCard());         
        }

        public void Result() //считаем результат
        {
            for (int i = 0; i < Hand.Count; i++)
            {
                if ((int)Hand[i].Face == 0)
                    Sum += 11;
                else
                    if ((int)Hand[i].Face <= 8 && (int)Hand[i].Face > 0)
                        Sum += (int)Hand[i].Face + 1;
                    else
                        Sum += 10;
            }
            Console.Write("Player score: {0}\n\n", Sum);
        }
    }
}
