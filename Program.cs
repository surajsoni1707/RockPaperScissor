using System;

namespace RockPaperScissor
{
    
    class Program
    {
        static int compScore = 0;
        static int userScore=0;
        static int tie = 0;
        Random rnd = new Random();
        public  int GetRandomumber()
        {
            return rnd.Next(1, 4);



        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            String name1 = name.ToUpper();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\tHello "+name+", Lets play Rock Paper Scissor");
            Console.WriteLine("\tTotal Rounds: 5");
            Console.WriteLine();
           
            int userCoice = 0;
            int compChoice = 0;
            for (int i = 0; i < 5; i++)
            {
               userCoice = p.GetUserChoice();
               compChoice = p.GetRandomumber();
                Console.WriteLine();
                p.GetResult(compChoice, userCoice);
                Console.WriteLine("\t\tRounds Remaining: "+(4-i));
                
            }
            if(Program.compScore>Program.userScore)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\tCOMPUTER WON THE GAME!!!");
            }
            else if (Program.compScore < Program.userScore)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\tCONGRATULATIONS {0}, YOU WON THE GAME!!!",name1);
            }
            else
                Console.WriteLine("\t\t\tIT's TIE!!!");
        }

        //Get User Choice
        public int GetUserChoice()
        {
            Console.WriteLine("\tEnter Your Choice:");
            Console.WriteLine("\t\t\tEnter 1 for Rock\n\t\t\tEnter 2 for Paper\n\t\t\tEnter 3 For Scissor");
            int uc = Convert.ToInt32(Console.ReadLine());
            if(uc<0 || uc>3)
            {
                Console.WriteLine("\t\tinvalid choice");
                
                return GetUserChoice();
            }
            return uc;
        }

        public void GetResult(int compCh,int userch )
        {
            if(compCh==1 && userch==1)
            {
                Program.tie++;
                Console.Write("Computer: Rock \t\t User: Rock");
                Console.WriteLine("\tit's Tie");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore+"\t Tie: "+Program.tie);
            }
            else if (compCh == 1 && userch == 2)
            {
                Program.userScore++;

                Console.Write("Computer: Rock \t\t User: Paper");
                Console.WriteLine("\tUser Won!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }
            else if (compCh == 1 && userch == 3)
            {
                Program.compScore++;

                Console.Write("Computer: Rock \t\t User: Scissor");
                Console.WriteLine("\tComputer Won!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }

            else if (compCh == 2 && userch == 1)
            {
                Program.compScore++;

                Console.Write("Computer: Paper \t\t User: Rock");
                Console.WriteLine("\tComputer Won!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }
            else if (compCh == 2 && userch == 2)
            {

                Program.tie++;
                Console.Write("Computer: Paper \t\t User: Paper");
                Console.WriteLine("\tIt's Tie!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }
            else if (compCh == 2 && userch == 3)
            {
                Program.userScore++;

                Console.Write("Computer: Paper \t\t User: Scissor");
                Console.WriteLine("\tUser Won!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }
            else if (compCh == 3 && userch == 1)
            {
                Program.userScore++;

                Console.Write("Computer: Scissor \t\t User: Rock");
                Console.WriteLine("\tUser Won!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }
            else if (compCh == 3 && userch == 2)
            {
                Program.userScore++;

                Console.Write("Computer: Scissor \t\t User: Paper");
                Console.WriteLine("\tUser Won!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }
            else if (compCh == 3 && userch == 3)
            {

                Program.tie++;
                Console.Write("Computer: Scissor \t\t User: Scissor");
                Console.WriteLine("\tIt's Tie!!!");
                Console.Write("Computer Score:" + Program.compScore + "\t\tUser Score:" + Program.userScore + "\t Tie: " + Program.tie);
            }

        }
    }
}
