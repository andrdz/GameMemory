using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            graph1 = DrawPanel.CreateGraphics();
            graph2 = PanelColors.CreateGraphics();
        }

        private Graphics graph1;
        private Graphics graph2;
        private PlayingField field;
        private int sec = 5;
        private int SelectedColor;
        private int fixPositionI = -1;
        private int fixPositionJ = -1;
        private bool GameStarted = false;
        private int[,] SelectedPositions = new int[3, 3];
        private int SelectedDifficultyLevel = -1;
        private int indexOfSelectedPanelColor;

        private void Draw()
        {
            int x, y;
            Pen p = new Pen(Color.Black, 5);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    x = field.quadrates[i, j].X;
                    y = field.quadrates[i, j].Y;
                    SwitchColors(graph1, field.quadrates[i, j].NumOfColor, x, y, 198, 198);
                    DrawBorder();
                }
        }

        private void SwitchColors(Graphics graph, int color, int x, int y, int width, int height)
        {
            switch (color)
            {
                case 0:
                    graph.FillRectangle(Brushes.Gray, x, y, width, height);
                    break;
                case 1:
                    graph.FillRectangle(Brushes.Red, x, y, width, height);
                    break;
                case 2:
                    graph.FillRectangle(Brushes.Green, x, y, width, height);
                    break;
                case 3:
                    graph.FillRectangle(Brushes.Blue, x, y, width, height);
                    break;
                case 4:
                    graph.FillRectangle(Brushes.Yellow, x, y, width, height);
                    break;
                case 5:
                    graph.FillRectangle(Brushes.Orange, x, y, width, height);
                    break;
                case 6:
                    graph.FillRectangle(Brushes.Violet, x, y, width, height);
                    break;
                case 7:
                    graph.FillRectangle(Brushes.Aqua, x, y, width, height);
                    break;
                case 8:
                    graph.FillRectangle(Brushes.White, x, y, width, height);
                    break;
            }
        }

        private void DrawBorder()
        {
            int x, y;
            Pen p = new Pen(Color.Black, 5);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    x = field.quadrates[i, j].X;
                    y = field.quadrates[i, j].Y;
                    graph1.DrawRectangle(p, x, y, 200, 200);
                }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            SwitchColors(graph2, 8, 0, 0, 330, 38);
            fixPositionI = -1;
            fixPositionJ = -1;
            GameStarted = false;
            GameTimer.Stop();
            sec = 5;
            indexOfSelectedPanelColor = 0;
            field = new PlayingField();
            Draw();
            TimerLabel.Text = sec.ToString();
            TimerLabel.Visible = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    SelectedPositions[i, j] = 8;
            StartGameButton.Text = "RESTART";
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                TimerLabel.Visible = false;
                DifficultyLevelBox.Visible = false;
                DifficultyLevelBox.SelectedIndex = -1;
                graph1.FillRectangle(Brushes.White, 0, 0, 600, 600);
                DrawBorder();
                DrawPanelColors();
                GameStarted = true;
                GameTimer.Stop();
            }
            else
            {
                sec--;
                TimerLabel.Text = sec.ToString();
            }
        }

        private void DrawPanelColors()
        {
            SwitchColors(graph2, 8, 0, 0, 330, 38);

            Pen p = new Pen(Color.Black, 3);
            for (int i = 0; i < field.ListOfColors.Count; i++)
            {
                SwitchColors(graph2, field.ListOfColors[i], i * 30 + i * 3, 2, 30, 30);
                if (i == indexOfSelectedPanelColor)
                {
                    graph2.DrawRectangle(p, i * 30 + i * 3, 2, 30, 30);
                    SelectedColor = field.ListOfColors[i];
                }
            }
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((fixPositionI != e.X / 200 || fixPositionJ != e.Y / 200) && GameStarted == true)
            {
                if (fixPositionI != -1 && fixPositionJ != -1)
                    SwitchColors(graph1, SelectedPositions[fixPositionI, fixPositionJ], (fixPositionI * 200) + 3, (fixPositionJ * 200) + 3, 195, 195);
                fixPositionI = e.X / 200;
                fixPositionJ = e.Y / 200;
                SwitchColors(graph1, SelectedColor, (fixPositionI * 200) + 3, (fixPositionJ * 200) + 3, 195, 195);
            }
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameStarted == true)
            {
                if (SelectedPositions[fixPositionI, fixPositionJ] != 8 && SelectedDifficultyLevel == 0)
                {
                    field.ListOfColors.Add(SelectedPositions[fixPositionI, fixPositionJ]);
                    SelectedPositions[fixPositionI, fixPositionJ] = 8;
                }

                if (SelectedPositions[fixPositionI, fixPositionJ] == 8)
                {
                    SwitchColors(graph1, SelectedColor, (fixPositionI * 200) + 3, (fixPositionJ * 200) + 3, 195, 195);
                    SelectedPositions[fixPositionI, fixPositionJ] = SelectedColor;
                    field.ListOfColors.RemoveAt(indexOfSelectedPanelColor);
                    indexOfSelectedPanelColor = 0;
                    DrawPanelColors();
                }
            }

            if (GameStarted == true)
            {
                if (field.ListOfColors.Count == 0)
                {
                    GameStarted = false;
                    int i = 0, j;
                    bool GameResult = true;
                    while (i < 3 && GameResult == true)
                    {
                        j = 0;
                        while (j < 3 && GameResult == true)
                        {
                            if (field.quadrates[i, j].NumOfColor != SelectedPositions[i, j])
                                GameResult = false;
                            j++;
                        }
                        i++;
                    }
                    if (GameResult == true)
                    {
                        MessageBox.Show("Congratulations!");
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                        Draw();
                    }
                    StartGameButton.Text = "START";
                    StartGameButton.Enabled = false;
                    DifficultyLevelBox.Visible = true;
                    DifficultyLevelBox.Text = "---Select difficulty level---";
                }
            }
        }

        private void DifficultyLevelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DifficultyLevelBox.SelectedIndex != -1)
            {
                StartGameButton.Enabled = true;
                SelectedDifficultyLevel = DifficultyLevelBox.SelectedIndex;
            }
        }

        private void PanelColors_MouseClick(object sender, MouseEventArgs e)
        {
            if (SelectedDifficultyLevel == 0)
            {
                if (e.X / (30 + 3) < field.ListOfColors.Count)
                    indexOfSelectedPanelColor = e.X / (30 + 3);
                DrawPanelColors();
                SwitchColors(graph1, SelectedColor, (fixPositionI * 200) + 3, (fixPositionJ * 200) + 3, 195, 195);
            }
        }
    }
}
