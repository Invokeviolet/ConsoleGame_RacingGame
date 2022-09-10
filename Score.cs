using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔레이싱_3차
{
    internal class Score
    {
        public int x;
        public int y;

        public int score = 0; //점수 초기값
        public Score(int xpos, int ypos) //x, y 위치값 초기화
        {
            x = xpos;
            y = ypos;
        }
        public void scoreSet()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Score : {0}", score); //점수 : 0

        }
    }
}
