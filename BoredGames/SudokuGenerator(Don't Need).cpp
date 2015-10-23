#include <cstdlib>
#include <iostream>

bool try_square(int x, int y);

using namespace std;

int sudoku[9][9];
long num_tries = 0;
long num_things = 0;

int main()
{
  srand(time(NULL));

//  for (int zz = 0; zz < 1000000; zz++)
//  {
  for (int i = 0; i < 9; i++)
  {
    for (int j = 0; j < 9; j++)
      sudoku[i][j] = 0;
  }
  
  try_square(0,0);
  
  cout << endl;
  
  for (int i = 0; i < 9; i+= 3)
  {
    for (int j = 0; j < 9; j+= 3)
    {
      cout << sudoku[i][j] << " ";
      cout << sudoku[i][j + 1] << " ";
      cout << sudoku[i][j + 2] << "  ";
    }
    cout << endl;
    for (int j = 0; j < 9; j+= 3)
    {
      cout << sudoku[i+1][j] << " ";
      cout << sudoku[i+1][j + 1] << " ";
      cout << sudoku[i+1][j + 2] << "  ";
    }
    cout << endl;
    for (int j = 0; j < 9; j+= 3)
    {
      cout << sudoku[i+2][j] << " ";
      cout << sudoku[i+2][j + 1] << " ";
      cout << sudoku[i+2][j + 2] << "  ";
    }
    cout << endl << endl;
  }
  
  
  
  /*for (int i = 0; i < 9; i++)
  {
    for (int j = 0; j < 9; j++)
      cout << sudoku[i][j] << " ";
    cout << endl;
  }*/
//  cout << endl;
  //cout << num_tries << endl << num_things << endl << endl;
//  }
  
  return EXIT_SUCCESS;
}

bool try_square(int x, int y)
{
  num_things ++;
  bool possible[10] = {false,true,true,true,true,true,true,true,true,true};
  //10 so if the sudoku square says "0" then it doesn't mess stuff up
  
  int square_x = x/3;
  int square_y = y/3;
  
  bool goback = true;
  
  int num = 0;
  
  //int[9] impossible = {-1,-1,-1,-1,-1,-1,-1,-1,-1};
  //int num_impossible = 0;
  
  for (int i = 0; i < x; i++)
  {
    if (possible[sudoku[i][y]])
    {
      //cout << "COLUMN FOUND " << sudoku[i][y] << endl;
      possible[sudoku[i][y]] = false;
    }
  }
  
  for (int i = 0; i < y; i++)
  {
    if (possible[sudoku[x][i]])
    {
      //cout << "ROW FOUND " << sudoku[x][i] << endl;
      possible[sudoku[x][i]] = false;
    }
  }
  
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      if (possible[sudoku[(3 * square_x) + i][(3 * square_y) + j]])
      {
        possible[sudoku[(3 * square_x) + i][(3 * square_y) + j]] = false;
      }
    }
  }
  
  for (int i = 0; i < 10; i++)
  {
    if (possible[i])
      goback = false;
  }
  
  if (goback)
  {
    sudoku[x][y] = 0;
    return false;
  }
  else
  {
    while (!goback)
    {
      num_tries ++;
      num = rand() % 9 + 1;
      
      //cout << x << "\t" << y << "\t" << num << endl;
      if (possible[num])
      {
        sudoku[x][y] = num;
        if (x == 8 && y == 8)
        {
//          cout << "PUZZLE FOUND" << endl;
          return true;
        }
        else if (x < 8)
        {
          if (try_square(x+1, y) == false)
          {
            possible[num] = false;
            sudoku[x][y] = 0;
          }
          else
            return true;
        }
        else
        {
          if (try_square(0, y+1) == false)
          {
            possible[num] = false;
            sudoku[x][y] = 0;
          }
          else
            return true;
        }
      }
      
      goback = true;
      for (int i = 0; i < 10; i++)
      {
        if (possible[i])
          goback = false;
      }
    }
    return false;
  }
}
