using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }
        public Grid(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[rows][];
            for(int i=0;i<Rows;i++)
            {
                Cells[i] = new Cell[Columns];
                for(int j=0;j<Columns;j++)
                {
                    Cell newCell = new ConsoleApplication1.Cell();
                    Cells[i][j] = newCell;
                }
            }
        }
        public void ToggleCell(int x,int y,bool isAlive)
        {
            Cells[x][y].IsAlive = isAlive;
        }
        public void Evolve()
        {
            int zivi = 0;
            for (int i=0;i<Rows;i++)
            {
                for(int j=0;j<Columns;j++)
                {
                    if(i==0||i==Columns-1)
                    {
                        if ((Cells[i][j + 1].IsAlive) || (Cells[i + 1][j + 1].IsAlive) || (Cells[i + 1][j].IsAlive))
                            ++zivi;
                    }

                }
            }
        }
    }
}
