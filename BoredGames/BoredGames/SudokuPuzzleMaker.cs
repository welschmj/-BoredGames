using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoredGames
{
    class SudokuPuzzleMaker
    {
        public int[,] puzzle = new int[9,9];
        long num_tries = 0;
        long num_things = 0;
        Random rand = new Random();
        public void generate()
        {
            

            for(int i=0;i<9;i++)
            {
                for(int j=0;j<9;j++)
                {
                    puzzle[i,j] = 0;
                }
            }

            try_square(0,0);

            Console.WriteLine();

            return;
        }

        public bool try_square(int x,int y)
        {
            num_things++;
            bool[] possible = new bool[10] { false, true, true, true, true, true, true, true, true, true };

            int square_x = x / 3;
            int square_y = y / 3;

            bool goBack = true;

            int num = 0;

            for (int i = 0; i < x; i++ )
            {
                if(possible[puzzle[i,y]])
                {
                    possible[puzzle[i, y]] = false;

                }
            }

            for (int i = 0; i < y; i++ )
            {
                if(possible[puzzle[x,i]])
                {
                    possible[puzzle[x, i]] = false;
                }
            }

            for (int i = 0; i < 3; i++ )
            {
                for (int j = 0; j < 3; j++)
                {
                    if (possible[puzzle[((3 * square_x) + i),((3 * square_y) + j)]])
                    {
                        possible[puzzle[((3 * square_x) + i), ((3 * square_y) + j)]] = false;
                    }
                }
            }

            for (int i = 0; i < 10; i++ )
            {
                if(possible[i])
                {
                    goBack = false;
                }
            }

            if (goBack)
            {
                puzzle[x, y] = 0;
                return false;
            }

            else
            {
                while(!goBack)
                {
                    num_tries++;
                    num = rand.Next(1,10);

                    if (possible[num])
                    {
                        puzzle[x,y] = num;
                        if (x == 8 && y == 8)
                        {
                            //          cout << "PUZZLE FOUND" << endl;
                            return true;
                        }
                        else if (x < 8)
                        {
                            if (try_square(x + 1, y) == false)
                            {
                                possible[num] = false;
                                puzzle[x,y] = 0;
                            }
                            else
                                return true;
                        }
                        else
                        {
                            if (try_square(0, y + 1) == false)
                            {
                                possible[num] = false;
                                puzzle[x,y] = 0;
                            }
                            else
                                return true;
                        }
                    }
                    goBack = true;
                    for (int i = 0; i < 10; i++)
                    {
                        if (possible[i])
                        {
                            goBack = false;
                        }
                           
                    }

                    

                }
                return false;
            }

                
        }



    }
}
