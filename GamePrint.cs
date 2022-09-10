using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔레이싱_3차
{
    internal class GamePrint
    {
        public int x;
        public int y;
        public void Start()
        {
            Console.WriteLine(" [ S T A R T ] ");
            Console.WriteLine(" 아무 키나 누르세요. ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Over()
        {
            Console.Clear();
            Console.WriteLine(" [ G A M E O V E R ] ");
            Console.WriteLine(" 아무 키나 누르세요. ");
            Console.ReadKey();
            
        }
        public void Victory()
        {
            Console.Clear();
            Console.WriteLine(" [ W I N ] ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Map()
        {
            for (int j = 1; j < 29; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.WriteLine("□");

                Console.SetCursorPosition(30, j);
                Console.WriteLine("□");

            }
            Console.SetCursorPosition(0, 0);
            Console.Write("□□□□□□□□□□□□□□□□");

            Console.SetCursorPosition(0, 29);
            Console.Write("□□□□□□□□□□□□□□□□");
        }
        public void Load()
        {
            for (int i = 0; i < 1; i++)
            {
                y = this.y + 1; //이동 y+1
                if (y > 50) { y = 0; }
                Console.SetCursorPosition(0, y);
                Console.Write("■");
                Console.SetCursorPosition(30, y);
                Console.Write("■");

                if (y == 28) //y축이 10일때 y, x값 초기화
                {
                    y = 0;                    
                }
            }
        }
    }
}
