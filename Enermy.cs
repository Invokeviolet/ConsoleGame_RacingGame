using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔레이싱_3차
{
    internal class Enermy
    {
        public int x;
        public int y;

        public Enermy(int xpos, int ypos)
        {
            x = xpos;
            y = ypos;
        }
        public void Update()
        {

        }
        public void Render() 
        {            
            y = this.y + 1;
            Console.SetCursorPosition(x, y); //커서의 위치
            Console.Write("●"); //출력

            if (y == 28) //y축이 10일때 y, x값 초기화
            {
                Random random = new Random();
                y = 0;
                x = random.Next(1, 10); //x 값은 랜덤으로 초기화
            }
           
        }
    }
}
