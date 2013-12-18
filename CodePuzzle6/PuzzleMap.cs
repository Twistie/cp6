using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePuzzle6
{
    public class PuzzleMap
    {
        public int xSize { get; set; }
        public int ySize { get; set; }

        public int xOffset, yOffset;

        public LinkedList<IActor>[,] map;

        public int gridSize { get; set; }

        protected Point[] horLines;
        protected Point[] verLines;

        private Pen pen;

        public PuzzleMap(int sizeX, int sizeY, int gridSize)
        {
            this.pen = new Pen(new SolidBrush(Color.White), 1);
            xOffset = 20;
            yOffset = 20;
            int curX = xOffset;
            int curY = yOffset;
            this.xSize = sizeX;
            this.ySize = sizeY;
            this.gridSize = gridSize;
            map = new LinkedList<IActor>[xSize, ySize];

            for (int i = 0; i < xSize; i++)
            {
                for (int n = 0; n < ySize; n++)
                {
                    map[i, n] = new LinkedList<IActor>();
                }
            }

                this.horLines = new Point[(sizeY * 2)];
            this.verLines = new Point[(sizeX * 2)];

            for (int i = 0; i < sizeY * 2; i++)
            {
                this.horLines[i] = new Point(curX, curY);
                curX += gridSize * sizeX;//right
                i++;
                this.horLines[i] = new Point(curX, curY);
                curY += gridSize;//down
                i++;
                this.horLines[i] = new Point(curX, curY);
                curX -= gridSize * sizeX; //left
                i++;
                this.horLines[i] = new Point(curX, curY);
                curY += gridSize; //down
            }

            curX = xOffset;
            curY = yOffset;

            for (int i = 0; i < sizeX * 2; i++)
            {
                this.verLines[i] = new Point(curX, curY);
                curY += gridSize * sizeY;//down
                i++;
                this.verLines[i] = new Point(curX, curY);
                curX += gridSize;//right
                i++;
                this.verLines[i] = new Point(curX, curY);
                curY -= gridSize * sizeY; //up
                i++;
                this.verLines[i] = new Point(curX, curY);
                curX += gridSize; //right
            }
        }

        public void moveActor(IActor actor, int i)
        {
            int yDiff = 0;
            int xDiff = 0;

            if (i < 4)
                yDiff = -1;
            else if (i > 6)
                yDiff = 1;

            if (i % 3 == 1)
                xDiff = -1;
            else if (i % 3 == 0)
                xDiff = 1;

            map[actor.position().X, actor.position().Y].Remove(actor);

            int newX, newY;
            newX = Math.Min(Math.Max(0, actor.position().X + xDiff), xSize - 1);
            newY = Math.Min(Math.Max(0, actor.position().Y + yDiff), ySize - 1);
            actor.setPosition(newX,newY );

            map[newX, newY].AddLast(actor);
        }

        public void addActor(IActor actor, int x, int y)
        {
            map[x, y].AddLast(actor);
        }

        public void draw(PaintEventArgs e)
        {
            e.Graphics.DrawLines(pen, horLines);
            e.Graphics.DrawLines(pen, verLines);
            foreach (LinkedList<IActor> actorList in map)
            {
                foreach (IActor actor in actorList)
                {
//                    actor.draw(e);
                }
            }
        }

        public void tick()
        {
            LinkedList<IActor> actorsToTick = new LinkedList<IActor>();
            foreach( LinkedList<IActor> actorList in map ) {
                foreach (IActor actor in actorList)
                {
                    actorsToTick.AddLast(actor);
                }
            }

            foreach( IActor actor in actorsToTick )
                actor.tick();
        }
    }
}
