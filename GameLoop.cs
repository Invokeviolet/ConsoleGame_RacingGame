using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 콘솔레이싱_3차
{
    internal class GameLoop
    {
        Player playerPos;
        Score scorePos;
        Heart heartPos;
        Heart heartPos_2;
        Heart heartPos_3;
        Enermy enermyPos;
        Enermy enermyPos_2;
        Enermy enermyPos_3;
        GamePrint gameprint;
        Random random = new Random();
        int score = 0;
        bool isNeedRefresh;

        int pxpos = 0; // 플레이어
        int pypos = 0;
        int hxpos = 0; //하트
        int hypos = 0;
        int hxpos_2 = 10; 
        int hypos_2 = 0;
        int hxpos_3 = 20; 
        int hypos_3 = 0;
        int expos = 28; // 적
        int eypos = 1;
        int expos_2 = 14; 
        int eypos_2 = 1;
        int expos_3 = 4; 
        int eypos_3 = 1;
        int sxpos = 35; // 점수
        int sypos = 1;
        
        
        public void Awake() 
        {
            Random random = new Random();
            Console.SetWindowSize(50, 30); //세로, 가로
            Console.BufferWidth = Console.WindowWidth = 50; //가로
            Console.BufferHeight = Console.WindowHeight = 30; //세로

            playerPos = new Player(15, 27);
            scorePos = new Score(40, 1);
            heartPos = new Heart(10, 0);
            heartPos_2 = new Heart(random.Next(2, 25), 0);
            heartPos_3 = new Heart(random.Next(2, 25), 0);
            enermyPos = new Enermy(20, 1);
            enermyPos_2 = new Enermy(random.Next(2, 25), 0);
            enermyPos_3 = new Enermy(random.Next(10, 25), 0);
            gameprint = new GamePrint();
        }
        public void Update() 
        {
            
            gameprint.Start(); //시작
            Console.CursorVisible = false; //커서가 표시될건지?            
            /*long oldTime = 0;
            long curTime; // 현재 틱
            curTime = System.Environment.TickCount;*/

            Console.SetCursorPosition(pxpos, pypos); // 플레이어 커서 위치
            Console.SetCursorPosition(expos, eypos); // 적 커서 위치
            Console.SetCursorPosition(hxpos, hypos); // 하트 커서 위치
            Console.SetCursorPosition(hxpos_2, hypos_2); // 하트 커서 위치
            Console.SetCursorPosition(hxpos_3, hypos_3); // 하트 커서 위치
            Console.SetCursorPosition(sxpos, sypos); // 점수 커서 위치    

            while (true) 
            {
                gameprint.Load(); //길
                heartPos.Update(); // 하트
                //heartPos.Update_2();
                
                enermyPos.Render(); // 적
                enermyPos_2.Render();
                enermyPos_3.Render();
                playerPos.Render(); //플레이어
                Console.SetCursorPosition(sxpos, sypos);
                Console.WriteLine("Score : {0}", score); //점수 : 0
                int enermies_posx = random.Next(0, 10); // 적 여러마리 (랜덤값)
                int[] enermies_X = new int[enermies_posx];
                for (int i = 0; i < enermies_posx; i++)
                {
                    enermies_X[i] = random.Next(25);                    
                }

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

                /*if (curTime - oldTime > 1000)
                {                    
                    oldTime = curTime;
                }*/

                /*Console.WriteLine("hxpos : " + hxpos);
                Console.WriteLine("pxpos : " + pxpos);
                Console.WriteLine("hypos : " + hypos);
                Console.WriteLine("pypos : " + pypos);*/
                pxpos = playerPos.x;
                pypos = playerPos.y;
                hxpos = heartPos.x;
                hypos = heartPos.y;
                hxpos_2 = heartPos_2.x;
                hypos_2 = heartPos_2.y;
                hxpos_3 = heartPos_3.x;
                hypos_3 = heartPos_3.y;
                expos = enermyPos.x;
                eypos = enermyPos.y;
                expos_2 = enermyPos_2.x;
                eypos_2 = enermyPos_2.y;
                expos_3 = enermyPos_3.x;
                eypos_3 = enermyPos_3.y;

                if ((hxpos == pxpos) && (hypos == pypos)) //하트와 충돌 체크
                {
                    Console.SetCursorPosition(sxpos, sypos);
                    Console.Write("Score : {0}", score += 100, " "); //점수 + 100

                    if (score == 1000) { gameprint.Victory(); } //1000점 달성 시 승리
                }
                if ((hxpos == expos) || (hxpos_2 == expos) || (hxpos_3 == expos)) // 적 위치와 하트 위치가 겹칠 경우 초기화
                {
                    hxpos = 0;
                    hxpos = random.Next(2, 40);                   
                }
                if ((expos == hxpos) || (expos_2 == hxpos) || (expos_3 == hxpos))
                {
                    eypos = 0;
                    expos = random.Next(2, 40);
                }

                if (hypos == 28) //y축 범위 초과시 x, y값초기화
                {
                    hypos = 0;
                    hxpos = random.Next(40);
                }                
                if (eypos == 28 )
                {
                    eypos = 0;                    
                    expos = random.Next(40);                   
                }                
                if ((expos == pxpos) && (eypos == pypos)) //적과 충돌 체크
                {
                    Console.Clear();
                    gameprint.Over();
                }                
                if (Console.KeyAvailable) //키 입력이 되었을때만
                {
                    ConsoleKeyInfo Key = Console.ReadKey();

                    switch (Key.Key)
                    {
                        case ConsoleKey.LeftArrow: //왼                            
                            playerPos.MoveLeft();
                            break;
                        case ConsoleKey.RightArrow: //오른                            
                            playerPos.MoveRight();
                            break;
                    }
                    /*if (Console.KeyAvailable) //키 입력이 되었을때만
                    {
                        ConsoleKeyInfo Key = Console.ReadKey();

                        switch (Key.Key)
                        {
                            case ConsoleKey.LeftArrow: //왼
                                if (pxpos <= 3)
                                {
                                    pxpos = 3;
                                }
                                else
                                {
                                    playerPos.MoveLeft();
                                }
                                break;
                            case ConsoleKey.RightArrow: //오른
                                if (pxpos >= 28)
                                {
                                    pxpos = 28;
                                }
                                else
                                {
                                    playerPos.MoveRight();
                                }
                                break;
                        }*/

                    }
                    Thread.Sleep(100);
                isNeedRefresh = true;                
            }            
        }
        public void Render() 
        {
        }
    }
}
