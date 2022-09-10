using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔레이싱_3차
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLoop gl = new GameLoop();
            gl.Awake();
            gl.Update();
            gl.Render();

        }
    }
}
