using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMemory
{
    class PlayingField
    {
        public readonly Quadrate[,] quadrates;
        public List<int> ListOfColors = new List<int>();

        public PlayingField()
        {
            Random rand = new Random();
            quadrates = new Quadrate[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    quadrates[i, j] = new Quadrate(i * 200, j * 200, rand.Next(0, 8));

            GenerateListPfColors();
        }

        private void GenerateListPfColors()
        {
            int i, j;
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    ListOfColors.Add(quadrates[i, j].NumOfColor);

            int buf;
            Random rand = new Random();

            for(int c = 0; c < 30; c++)
            {
                i = rand.Next(0, 8);
                j = rand.Next(0, 8);
                buf = ListOfColors[i];
                ListOfColors[i] = ListOfColors[j];
                ListOfColors[j] = buf;
            }
        }
    }
}
