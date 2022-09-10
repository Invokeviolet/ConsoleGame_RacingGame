using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔레이싱_3차
{
    internal class Heart
    {
        public int x;
        public int y;
        int dir;
        public Heart(int xpos, int ypos) //x, y 위치값 초기화
        {
            x = xpos;
            y = ypos;

        }
        public void Update()
        {
            Console.Clear();
            y = this.y + 1; //이동 y+1
            Console.SetCursorPosition(x, y);
            Console.Write("♡");

            if (y == 28) //y축의 값이 맵 최대값을 벗어날때 
            {
                Random random = new Random();
                y = 0; // y = 0 값으로 초기화
                x = random.Next(1, 20); //x 값을 랜덤으로 초기화
            }            
        }
        public void Update_2()
        {
            int dir = 0;
            Console.Clear();
            y = this.y + 1; //이동 y+1
            Console.SetCursorPosition(x, y);
            switch (dir)
            {
                case 0:
                    Console.WriteLine(" ");
                    Console.WriteLine("♡          ♡");
                    break;
                case 1:
                    Console.WriteLine(" ");
                    Console.Write("          ♡          ♡");
                    break;
                case 2:
                    Console.WriteLine(" ");
                    Console.Write("        ♡       ♡      ");
                    break;
                case 3:
                    Console.WriteLine(" ");
                    Console.Write("      ♡            ♡ ");
                    break;
                case 4:
                    Console.WriteLine(" ");
                    Console.WriteLine("    ♡      ♡ ");
                    break;
                case 5:
                    Console.WriteLine(" ");
                    Console.WriteLine("    ♡                  ♡");
                    break;
                case 6:
                    Console.WriteLine(" ");
                    Console.WriteLine(" ♡     ♡          ");
                    break;
            }
            if (y == 28) //y축의 값이 맵 최대값을 벗어날때 
            {
                Random random = new Random();
                y = 0; // y = 0 값으로 초기화
                x = random.Next(1, 20); //x 값을 랜덤으로 초기화
            }
        }
        
    }
}
