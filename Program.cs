using System;

namespace Project_AP_PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapPacMan = @"XXXXXXXXXXXXXXXXXXXXXXXXXXXX
                              X         XX    XX         X
                              X XXXX XX XX XX XX XX XXXX X
                              X XXXX XX XX XX XX XX XXXX X
                              X      XX    XX    XX      X
                              X XXXX XXXXX XX XXXXX XXXX X
                              X XXXX XXXXX XX XXXXX XXXX X
                              X XX         XX         XX X
                              X XX XXXX XXXXXXXX XXXX XX X
                              X XX XXXX XXXXXXXX XXXX XX X
                                                          
                              X XXXX XX XXX--XXX XX XXXX X
                              X XXXX XX X      X XX XXXX X
                              X XXXX XX X      X XX XXXX X
                              X      XX X      X XX      X
                              X XXXX XX XXXXXXXX XX XXXX X
                              X XXXX XX          XX XXXX X
                              X   XX XX XXXXXXXX XX XX   X
                              XXX XX XX XXXXXXXX XX XX XXX
                              XXX XX       XX       XX XXX
                                  XX XXXXX XX XXXXX XX    
                              X XXXX XXXXX XX XXXXX XXXX X
                              X XXXX XX          XX XXXX X
                              X      XX XX XX XX XX      X
                              X XX XXXX XX XX XX XXXX XX X
                              X XX XXXX XX XX XX XXXX XX X
                              X XX      XX    XX      XX X
                              X XXXXXXX XXXXXXXX XXXXXXX X
                              X XXXXXXX XXXXXXXX XXXXXXX X
                              X                          X
                              XXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            var barisMap = mapPacMan.Split(System.Environment.NewLine);
            barisMap = barisMap.Skip(1).ToArray();
            for (int jumlahBaris = 0; jumlahBaris < barisMap.Length; jumlahBaris++)
            {
                var baris = barisMap[jumlahBaris];
                for (int jumlahKolom = 0; jumlahKolom < baris.Length; jumlahKolom++)
                {
                    var jumlahSel = baris[jumlahKolom];
                    if (jumlahSel == 'X')
                        Console.Write($"({jumlahKolom}, {jumlahBaris})\n");
                }
            }
            Console.ReadKey();
        }
        
        //public static void eat()
        //{
        //    var points = 0;
        //    var my_score = 0;
        //    var lives = 3;
        //    while (lives != 0)
        //    {
        //        if(pacman == cherry)
        //        {
        //            my_score = points + 400;
        //        }
        //    }
            
        //}
    }
}