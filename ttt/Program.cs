using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    class Program
    {
        public static int[,] Field = new int[3, 3];
        public static int n = 3;
        public static string str = "";

        static void Main(string[] args)
        {
            int x = 1;
            InitClearField();

            while (!CheckWin())
            {
                if (WhoseTurn(x))
                {
                    PlayerTurn();
                    x++;
                    str = "Игрок";
                }
                else
                {
                    EasyComputerTurn();
                    x--;
                    str = "Компьютер";
                }
                PaintField();
            }
        }

        public static void PaintField()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Field[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static Array PlayerTurn()
        {
            Console.WriteLine("vvedi");
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            Field[k, l] = 1;
            return Field;
        }

        public static Array InitClearField()
        {
            int[,] Field = { { 0,0,0},{ 0,0,0},{ 0,0,0} };
            return Field;
        }

        //public Array ComputerTurn()
        //{

        //    return Field;
        //}

        public static Array EasyComputerTurn()
        {
            int[,] dublicateField = new int[3, 3];
            dublicateField = Field;
            List<int> ParsedArray = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ParsedArray.Add(Field[i, j]);
                }
            }
            Random rnd = new Random();
            int value = rnd.Next(ParsedArray.Count);

            if (ParsedArray[value] == 0)
            {
                ParsedArray[value] = 2;
            }
            else
            {
                while (ParsedArray[value] != 0)
                {
                    value = rnd.Next(ParsedArray.Count);
                }
                ParsedArray[value] = 2;
            }

            int nom = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dublicateField[i,j] = ParsedArray[nom];
                    nom++;
                }
            }
            Field = dublicateField;
            return Field;
        }

        //public static bool GameCondition() //есть ли свободное место для совершения хода
        //{
        //    int count = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (Field[i, j] != 0)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static bool WhoseTurn(int x)
        {
            if (x==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckWin()
        {
            // проверка на ничью
            if (Field[0, 0] > 0 && Field[0, 1] > 0 && Field[0, 2] > 0 &&
                Field[1, 0] > 0 && Field[1, 1] > 0 && Field[1, 2] > 0 &&
                Field[2, 0] > 0 && Field[2, 1] > 0 && Field[2, 2] > 0)
            {

                //MessageBox.Show("Пользователи завершили игру ничьей");
                //drawgame += 1;
                //allgame += 1;

                //Restart();
                Console.WriteLine("ничья");
                Console.ReadLine();
                return true;
            }

            // проверка на выигрыш
            //строки
            if (((Field[0, 0] == Field[0, 1] && Field[0, 1] == Field[0, 2])
                && (Field[0, 0] > 0))
                //&& Field[0, 1] > 0
                //&& Field[0, 2] > 0))
               ||
               ((Field[1, 0] == Field[1, 1] && Field[1, 1] == Field[1, 2])
                && (Field[1, 0] > 0))
                //&& Field[1, 1] > 0
                //&& Field[1, 2] > 0))
               ||
               ((Field[2, 0] == Field[2, 1] && Field[2, 1] == Field[2, 2])
                && (Field[2, 0] > 0))
                //&& Field[2, 1] > 0
                //&& Field[2, 2] > 0))
                

               ||
               //столбцы
               ((Field[0, 0] == Field[1, 0] && Field[1, 0] == Field[2, 0])
                && (Field[0, 0] > 0))
                //&& Field[1, 0] > 0
                //&& Field[2, 0] > 0))
               ||
               ((Field[0, 1] == Field[1, 1] && Field[1, 1] == Field[2, 1])
                && (Field[0, 1] > 0))
                //&& Field[1, 1] > 0
                //&& Field[2, 1] > 0))
               ||
               ((Field[0, 2] == Field[1, 2] && Field[1, 2] == Field[2, 2])
                && (Field[0, 2] > 0))
                //&& Field[1, 2] > 0
                //&& Field[2, 2] > 0))


               ||
               //диагонали
               ((Field[0, 0] == Field[1, 1] && Field[1, 1] == Field[2, 2])
                && (Field[0, 0] > 0))
                //&& Field[1, 1] > 0
                //&& Field[2, 2] > 0))
               ||
               ((Field[0, 2] == Field[1, 1] && Field[1, 1] == Field[2, 0])
                && (Field[0, 2] > 0)))
                //&& Field[1, 1] > 0
                //&& Field[2, 0] > 0)))
            {
                Console.WriteLine("внимание, победил  " + str);
                Console.ReadLine();
                return true;
                //if (next) //проверить чей ход, того объявить победителем
                //{
                //    MessageBox.Show("Выиграл пользователь играющий O");
                //    win1 += 1;
                //}
                //else
                //{
                //    MessageBox.Show("Выиграл пользователь играющий X");
                //    win2 += 1;
                //}
                //allgame += 1;
                //Restart();
            }
            else
            {
                return false;
            }
        }

    }
}
