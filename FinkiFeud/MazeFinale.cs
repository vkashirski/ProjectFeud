using System;
using System.Collections.Generic;
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
        Point finishPoint;
        Brush endBrushMarker;
        bool isDrawn = false;
        Point startLocation;

        //Generated maze
        List<PointF> blackMaze;
        List<PointF> whiteMaze;

        //The borders of the panel
        int top, left, height, width;
        bool allowRight, allowLeft, allowDown, allowUp = false;
        int newX, newY;

        //Time
        private static int Time=30;
        public static int passedTime;
        public static bool atEnd = false;

        bool windowAllowed = true;
        public MazeFinale()
        {
            InitializeComponent();
            //DoubleBuffered for no flickering
            DoubleBuffered = true;

            startLocation = new Point(18, 18);
            finishPoint = new Point(1184, 550);
            //default window borders
            top = 10;
            left = 10;
            width = Width - left - 30;
            height = Height - top - 50;

            if (ChooseGame.windowedMode == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                windowAllowed = false;
                
                //window borders when in full screen.
                newX = this.Width/4;
                newY = this.Height/3;
                startLocation = new Point(18+newX, 18+newY);
                finishPoint = new Point(1184+newX, 550+newY);
                top += newX;
                left += newY;
                width += newY;
                height += newX;
            }

            //Get the player from the previous form
            currentPlayer = new MazePlayer(ChooseGame.player.Points, ChooseGame.player.Name, ChooseGame.player.difficulty, ChooseGame.player.PlayerIcon, startLocation);
            
            

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
            whiteMaze = new List<PointF>();
            blackMaze = new List<PointF>();
           
            

            //Start the timer
            passedTime = 0;
            lbTime.Text = Time.ToString();
            mazeTimer.Interval = 1000;
            mazeTimer.Start();


        }

        private void checkEnd()
        {
            if (currentPlayer.Location.X > finishPoint.X+10 && currentPlayer.Location.Y > finishPoint.Y)
            {
                atEnd = true;
            }
        }

        private void mazeTimer_Tick(object sender, EventArgs e)
        {
            
            if (atEnd)
            {
                this.Close();
            }
            passedTime++;
            lbTime.Text = (Time - passedTime).ToString();
            if (passedTime == Time)
            {
                this.Close();
            }

            if (passedTime < 10)
            {
                lbTime.ForeColor = Color.Red;
            }
            
        }


        private void GenerateRandomMaze()
        {
            initializeGraph();
            x1 = 0;
            y1 = 0;
            x2 = cellWidth;
            y2 = 0;

            for (int i = 0; i < theGraph.GetLength(0) + 1; i++)
            {
                for (int j = 0; j < theGraph.GetLength(1); j++)
                {
                    if (flag == 0)
                    {
                        if (windowAllowed)
                        {
                            blackMaze.Add(new PointF(x1, y1 + 10));
                            blackMaze.Add(new PointF(x2, y2 + 10));
                        }
                        else
                        {
                            blackMaze.Add(new PointF(x1+newX, y1 + 10+newY));
                            blackMaze.Add(new PointF(x2+newX, y2 + 10+newY));
                        }
                    }
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
                    if (flag == 0)
                    {
                        if (windowAllowed)
                        {
                            blackMaze.Add(new PointF(x1, y1 + 10));
                            blackMaze.Add(new PointF(x2, y2 + 10));
                        }
                        else
                        {
                            blackMaze.Add(new PointF(x1+newX, y1 + 10+newY));
                            blackMaze.Add(new PointF(x2+newX, y2 + 10+newY));
                        }
                    }
                    x1 = x2 += cellWidth;
                }
                y1 = y2;
                y2 += cellWidth;
                x1 = x2 = 0;

            }

            if (flag == 0)
            {
                traverseGraph(0, 0, 1);
            }
            isDrawn = true;
            flag++;

        }

        private void MazeFinale_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.DarkBlue);
            GenerateRandomMaze();
            if (isDrawn == true)//isDrawn is true if the GenerateRandomMaze is finished
            {
                for (int i = 0; i < blackMaze.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        
                            g.DrawLine(blackPen, blackMaze[i], blackMaze[i - 1]);
                        
                    }


                }
                for (int i = 0; i < whiteMaze.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                            g.DrawLine(whitePen, whiteMaze[i], whiteMaze[i - 1]);                       
                    }
                }
                g.FillRectangle(endBrushMarker, finishPoint.X, finishPoint.Y, 94, 94);


                currentPlayer.Draw(g);
            }
            checkEnd();
        }


        //Initializing the graph for the Maze that needs to be traveresed
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

                                x1 = (c * cellWidth) + 5;
                                y1 = y2 = (r * cellWidth) + 10;
                                x2 = x1 + cellWidth - 10;
                                if (windowAllowed)
                                {
                                    whiteMaze.Add(new PointF(x1, y1));
                                    whiteMaze.Add(new PointF(x2, y2));
                                }
                                else
                                {
                                    whiteMaze.Add(new PointF(x1+newX, y1+newY));
                                    whiteMaze.Add(new PointF(x2+newX, y2+newY));
                                }

                                traverseGraph(r - 1, c, theGraph[r - 1, c].cellNumber);
                            }
                        }
                        else if (dir == 2 && theGraph[r, c].right == false)
                        {
                            theGraph[r, c].right = true;
                            if (theGraph[r, c + 1].visited == false)
                            {
                                x1 = x2 = (c + 1) * cellWidth;
                                y1 = (r * cellWidth) + 15;
                                y2 = y1 + cellWidth - 10;
                                if (windowAllowed)
                                {
                                    whiteMaze.Add(new PointF(x1, y1));
                                    whiteMaze.Add(new PointF(x2, y2));
                                }
                                else
                                {
                                    whiteMaze.Add(new PointF(x1 + newX, y1 + newY));
                                    whiteMaze.Add(new PointF(x2 + newX, y2 + newY));
                                }
                                traverseGraph(r, c + 1, theGraph[r, c + 1].cellNumber);
                            }
                        }
                        else if (dir == 3 && theGraph[r, c].down == false)
                        {
                            theGraph[r, c].down = true;
                            if (theGraph[r + 1, c].visited == false)
                            {
                                x1 = (c * cellWidth) + 5;
                                y1 = y2 = (r + 1) * cellWidth + 10;
                                x2 = x1 + cellWidth - 10;
                                if (windowAllowed)
                                {
                                    whiteMaze.Add(new PointF(x1, y1));
                                    whiteMaze.Add(new PointF(x2, y2));
                                }
                                else
                                {
                                    whiteMaze.Add(new PointF(x1 + newX, y1 + newY));
                                    whiteMaze.Add(new PointF(x2 + newX, y2 + newY));
                                }
                                traverseGraph(r + 1, c, theGraph[r + 1, c].cellNumber);
                            }
                        }
                        else if (dir == 4 && theGraph[r, c].left == false)
                        {
                            theGraph[r, c].left = true;
                            if (theGraph[r, c - 1].visited == false)
                            {
                                x1 = x2 = c * cellWidth;
                                y1 = (r * cellWidth) + 15;
                                y2 = y1 + cellWidth - 10;
                                if (windowAllowed)
                                {
                                    whiteMaze.Add(new PointF(x1, y1));
                                    whiteMaze.Add(new PointF(x2, y2));
                                }
                                else
                                {
                                    whiteMaze.Add(new PointF(x1 + newX, y1 + newY));
                                    whiteMaze.Add(new PointF(x2 + newX, y2 + newY));
                                }
                                traverseGraph(r, c - 1, theGraph[r, c - 1].cellNumber);
                            }
                        }
                    }
                    catch (Exception e)
                    {

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

        private void resetAllow()
        {
            allowRight = false;
            allowUp = false;
            allowLeft = false;
            allowDown = false;

        }

        //Move the player when he clicked a key
        private void MazeFinale_KeyDown(object sender, KeyEventArgs e)
        {
            isColliding(currentPlayer.Location);

            if (e.KeyCode == Keys.Up && allowUp)
            {
                currentPlayer.moveUp(left, top, width, height);
            }
            else if (e.KeyCode == Keys.Down && allowDown)
            {
                currentPlayer.moveDown(left, top, width, height);
            }
            else if (e.KeyCode == Keys.Left && allowLeft)
            {
                currentPlayer.moveLeft(left, top, width, height);
            }
            else if (e.KeyCode == Keys.Right && allowRight)
            {
                currentPlayer.moveRight(left, top, width, height);
            }

            //Needed in order for next time you want to move the function isColliding sets which ways you can move
            resetAllow();
            Invalidate();
        }


        //Check if you're allowed to move at that location
        private void isColliding(Point currentLocation)
        {
            foreach (PointF p in whiteMaze)
            {
                    if ((currentLocation.X - 18 == p.X && currentLocation.Y - 3 == p.Y) || (currentLocation.X - 13 == p.X && currentLocation.Y + 94 == p.Y))
                    {
                        allowLeft = true;

                    }
                    else if ((currentLocation.X + 89 == p.X && currentLocation.Y - 3 == p.Y) || (currentLocation.X + 89 == p.X && currentLocation.Y + 94 == p.Y))
                    {
                        allowRight = true;
                    }
                    else if ((currentLocation.X - 13 == p.X && currentLocation.Y + 99 == p.Y) || (currentLocation.X + 84 == p.X && currentLocation.Y + 99 == p.Y))
                    {
                        allowDown = true;

                    }
                    else if ((currentLocation.X - 13 == p.X && currentLocation.Y - 8 == p.Y) || (currentLocation.X + 84 == p.X && currentLocation.Y - 8 == p.Y))
                    {
                        allowUp = true;

                    }
                
            }

        }
    }
}
