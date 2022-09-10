using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔레이싱_3차
{
    internal class Player
    {
        //플레이어
        public int x;
        public int y;
        public Player(int xpos, int ypos)
        {
            x = xpos;
            y = ypos;
        }

        public void Render()
        {            
            Console.SetCursorPosition(x, y);
            Console.Write("金"); // 초기 위치값에 플레이어를 출력
        }
        public void MoveRight() 
        {            
            x = this.x + 1;
            Console.SetCursorPosition(x, y);
            Console.Write("金");
            if (x >= 30) { x = 30; } //플레이어가 맵범위 벗어나면 위치 초기화
        }
        public void MoveLeft()
        {            
            x = this.x - 1;
            Console.SetCursorPosition(x, y);
            Console.Write("金");            
            if (x <= 2) { x = 2; }
        }
       
    }
}
