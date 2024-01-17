using System;

namespace _2D_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[4, 5] // y = 4, x = 5 [y,x]
            {
                {3, 0, 0, 0, 0},
                {0, 0, 1, 1, 1},
                {1, 0, 0, 0, 0},
                {1, 0, 1, 1, 2}
            };


            void CurrentMap() // 맵의 현재 상태를 보여줌
            {
                Console.WriteLine("-- MAP --");
                for (int y = 0; y < map.GetLength(0); y++) // map.GetLength(0) = 4
                {
                    for (int x = 0; x < map.GetLength(1); x++) // map.GetLength(1) = 5
                    {
                        Console.Write($"{map[y, x]} ");
                    }
                    Console.WriteLine("");

                }
                Console.WriteLine("");
            }

            int x = 0; // 좌표 x = 0 ~ 4 , y = 0 ~ 3
            int y = 0;

            void MoveRight()
            {
                if (x >= map.GetLength(1) - 1)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                if (map[y, x + 1] == 1)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                map[y, x] = 0;
                x++;
                map[y, x] = 3;

                CurrentMap();
            }

            void MoveLeft()
            {
                if (x <= 0)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                if (map[y, x - 1] == 1)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                map[y, x] = 0;
                x--;
                map[y, x] = 3;

                CurrentMap();
            }

            void MoveUp()
            {
                if (y <= 0)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                if (map[y - 1, x] == 1)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                map[y, x] = 0;
                y--;
                map[y, x] = 3;

                CurrentMap();
            }

            void MoveDown()
            {
                if (y >= map.GetLength(0) - 1)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                if (map[y + 1, x] == 1)
                {
                    Console.WriteLine("움직일 수 없습니다\n");
                    CurrentMap();
                    return;
                }

                map[y, x] = 0;
                y++;
                map[y, x] = 3;

                CurrentMap();
            }

            Console.WriteLine("Game Start");
            //Console.WriteLine("-- MAP --");
            CurrentMap();           
            
            while (x != 4 || y != 3)
            {
                Console.WriteLine("움직일 방향을 입력하세요.\n현재 좌표를 확인하시려면 Space를 누르세요.");                
                ConsoleKeyInfo key;
                key = Console.ReadKey();                
                Console.WriteLine("");

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        MoveRight();
                        break;

                    case ConsoleKey.LeftArrow:
                        MoveLeft();
                        break;

                    case ConsoleKey.UpArrow:
                        MoveUp();
                        break;

                    case ConsoleKey.DownArrow:
                        MoveDown();
                        break;

                    case ConsoleKey.Spacebar:
                        Console.WriteLine($"현재 플레이어의 좌표는 [{y}, {x}]입니다.\n");                        
                        break;

                    default:
                        Console.WriteLine("알맞은 키를 입력하세요.\n");
                        break;
                }
                
                if(x == 4 && y == 3)
                {
                    Console.WriteLine("**********목표에 도착했습니다!**********\n게임을 종료합니다.");
                }
            }            
                        
            
        }

    }
}