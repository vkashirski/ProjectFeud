using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinkiFeud
{
    public partial class MazeFinale : Form
    {

        //Initializing the player
        MazePlayer currentPlayer;
        // Initializing all Maze Variables
        int row, col;
        int cellWidth, cellCount, dir;
        Graph[,] theGraph;
        Stack theStack;
        Random rand;
        Graphics g;
        Pen blackPen, whitePen;
        int x1, y1, x2, y2;
        int poppedVal;
        int flag;
        Brush endBrushMarker;

        private void MazeFinale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                currentPlayer.moveUp(Left,Top,Width,Height);
            }
            else if (e.KeyCode == Keys.Down)
            {
                currentPlayer.moveDown(Left, Top, Width, Height);
            }
            else if (e.KeyCode == Keys.Left)
            {
                currentPlayer.moveLeft(Left, Top, Width, Height);
            }
            else if (e.KeyCode == Keys.Right)
            {
                currentPlayer.moveRight(Left, Top, Width, Height);
            }
            Invalidate();

        }

        public MazeFinale()
        {
            InitializeComponent();
            //DoubleBuffered for no flickering
            this.DoubleBuffered = true;
            //Get the player from the previous form
            currentPlayer = new MazePlayer(ChooseGame.player.Points, ChooseGame.player.Name, ChooseGame.player.difficulty, ChooseGame.player.PlayerIcon,this.Location);
            //Initialize Maze variables
            cellWidth = 107;
            theStack = new Stack();
            rand = new Random();
            cellCount = 0;          
            blackPen = new Pen(Color.DarkOrange);
            whitePen = new Pen(Color.DarkBlue);
            endBrushMarker = new SolidBrush(Color.Green);
            flag = 0;
            blackPen.Width = 10;
            whitePen.Width = 10;
                row = Convert.ToInt32(6);
                col = Convert.ToInt32(12);
        }

        private void MazeFinale_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DarkBlue);
            initializeGraph();
            
            x1 = 0;
            y1 = 0;
            x2 = cellWidth;
            y2 = 0;
            g = e.Graphics;
            currentPlayer.Draw(g);
            for (int i = 0; i < theGraph.GetLength(0) + 1; i++)
            {
                for (int j = 0; j < theGraph.GetLength(1); j++)
                {
                    if (flag == 0) g.DrawLine(blackPen, x1, y1, x2, y2);
                    x1 = x2;
                    x2 += cellWidth;
                }
                y1 = y2 += cellWidth;
                x1 = 0;
                x2 = cellWidth;
            }
            
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = cellWidth;

            for (int i = 0; i < theGraph.GetLength(0); i++)
            {
                for (int j = 0; j < theGraph.GetLength(1) + 1; j++)
                {
                    if (flag == 0) g.DrawLine(blackPen, x1, y1, x2, y2);
                    x1 = x2 += cellWidth;
                }
                y1 = y2;
                y2 += cellWidth;
                x1 = x2 = 0;
                
            }

            if (flag == 0) {

                
                traverseGraph(0, 0, 1);
            }

            flag++;
            pickRandomEnd(g, new Point(x1, y1));

        }
        private void initializeGraph()
        {
            theGraph = new Graph[row, col];

            for (int i = 0; i < theGraph.GetLength(0); i++)
            {
                for (int j = 0; j < theGraph.GetLength(1); j++)
                {
                    theGraph[i, j] = new Graph();
                    theGraph[i, j].visited = false;
                    theGraph[i, j].up = theGraph[i, j].down = theGraph[i, j].left = theGraph[i, j].right = false;
                    theGraph[i, j].cellNumber = ++cellCount;
                }
            }
        }
        public void pickRandomEnd(Graphics g, Point p)
        {
            x1 = p.X;
            y1 = p.Y;   
            g.FillRectangle(endBrushMarker, x1, y1, 108, 108);
        }
        //Traversing the graph and applying white places where it will be open
        private void traverseGraph(int r, int c, int cellNumber)
        {
            theStack.push(cellNumber);
            theGraph[r, c].visited = true;

            do
            {
                if (theGraph[r, c].up == true && theGraph[r, c].down == true && theGraph[r, c].left == true && theGraph[r, c].right == true)
                {
                    poppedVal = theStack.pop();
                    
                    return;
                }
                else
                {
                    dir = rand.Next(1, 5);
                    try
                    {
                        if (dir == 1 && theGraph[r, c].up == false)
                        {
                            theGraph[r, c].up = true;
                            if (theGraph[r - 1, c].visited == false)
                            {
                                x1 = (c * cellWidth) + 1;
                                y1 = y2 = (r * cellWidth);
                                x2 = x1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r - 1, c, theGraph[r - 1, c].cellNumber);
                            }
                        }
                        else if (dir == 2 && theGraph[r, c].right == false)
                        {
                            theGraph[r, c].right = true;
                            if (theGraph[r, c + 1].visited == false)
                            {
                                x1 = x2 = (c + 1) * cellWidth;
                                y1 = (r * cellWidth) + 1;
                                y2 = y1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r, c + 1, theGraph[r, c + 1].cellNumber);
                            }
                        }
                        else if (dir == 3 && theGraph[r, c].down == false)
                        {
                            theGraph[r, c].down = true;
                            if (theGraph[r + 1, c].visited == false)
                            {
                                x1 = (c * cellWidth) + 1;
                                y1 = y2 = (r + 1) * cellWidth;
                                x2 = x1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r + 1, c, theGraph[r + 1, c].cellNumber);
                            }
                        }
                        else if (dir == 4 && theGraph[r, c].left == false)
                        {
                            theGraph[r, c].left = true;
                            if (theGraph[r, c - 1].visited == false)
                            {
                                x1 = x2 = c * cellWidth;
                                y1 = (r * cellWidth) + 1;
                                y2 = y1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r, c - 1, theGraph[r, c - 1].cellNumber);
                            }
                        }
                    }
                    catch (Exception e) {
                     
                    }
                }
            } while (true);
        }

        //Graph Data Structure
        class Graph
        {
            public bool visited, up, down, left, right;
            public int cellNumber;
        }


        //Stack Data Structure
        class Stack
        {
            public int[] theStack;
            int top;

            public Stack()
            {
                top = 0;
                theStack = new int[10];
            }

            public void push(int num)
            {
                if (top < theStack.Length) theStack[top++] = num;

                else
                {
                    int[] temp = new int[top + 10];
                    for (int i = 0; i < theStack.Length; i++) temp[i] = theStack[i];

                    theStack = temp;
                    theStack[top++] = num;
                }
            }

            public int pop()
            {
                if (top > 0) return theStack[--top];

                else return -1;
            }
        }
    }
}
