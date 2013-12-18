using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePuzzle6
{
    public class BasicActor : IActor, IComparable<BasicActor>
    {
        public static float MUTATION_CHANCE = .05f; 
        private int x, y, toX, toY, turnLimit, startX, startY = 0;
        private PuzzleMap pMap;
        public List<Turn> turnList {get; set;}
        private Font font;
        private char letter;
        public Brush brush, transBrush;
        private int curTurn = 0;
        public float fitness {get; set;}
        private Random rand;
        private Color colour;
        private Queue<Rectangle> prevSquares;
        public bool showRoute { get; set; }

        public class Turn {

            public int direction { get; set; }

            public Turn(int direction)
            {
                if (direction < 1 || direction > 9)
                    throw new InvalidOperationException("Tried to make a turn with direction: " + direction);

                this.direction = direction;
            }
        }
        public BasicActor(int x, int y, int toX, int toY, int turnLimit, char letter, PuzzleMap pMap, Color colour, Random rand )
        {
            showRoute = false;
            prevSquares = new Queue<Rectangle>();
            this.startX = x;
            this.startY = y;
            this.colour = colour;
            fitness = 0f;
            brush = new SolidBrush(colour);
            Color c = Color.FromArgb( 50 , colour.R,colour.G,colour.B );
            transBrush = new SolidBrush(c);
            this.turnLimit = turnLimit;
            this.letter = letter;
            this.font = new Font(FontFamily.GenericMonospace,6);
            this.x = x;
            this.y = y;
            this.toX = toX;
            this.toY = toY;

            this.rand = rand;

            this.pMap = pMap;
            pMap.addActor(this, x, y);
            turnList = new List<Turn>(turnLimit);

            for (int i = 0; i < turnLimit; i++)
            {
                turnList.Add(new Turn(rand.Next(8) + 1));

            }
        }

        public void finishGeneration()
        {
            for (int i = curTurn; i < turnLimit; i++)
                tick();
        }

        public void tick()
        {
            float curDist = curDistance();
            if( curDist != 0)
                pMap.moveActor(this, turnList[curTurn].direction);
            
            curDist = curDistance();
            if (curDist == 0)
                fitness += 1;
            else
                fitness -= curDist;


            curTurn++;
            if (curTurn == turnList.Capacity)
                if (curDist == 0)
                    fitness += 5000;
        }

        public BasicActor breed(IActor other)
        {
            BasicActor a = this;
            BasicActor b = (BasicActor)other;
            List<Turn> newTurnList = new List<Turn>(turnLimit);

            for (int i = 0; i < turnLimit; i++)
            {
                float next = (float)rand.NextDouble();
                if(next < (1 - MUTATION_CHANCE / 2 ))
                    newTurnList.Add(new Turn( a.turnList.ElementAt(i).direction));
                else if(next < 1 - MUTATION_CHANCE )
                    newTurnList.Add(new Turn(b.turnList.ElementAt(i).direction ));
                else
                    newTurnList.Add(new Turn( rand.Next(8) + 1));
            }
            
            BasicActor ret = new BasicActor(startX,startY, toX, toY, turnLimit, letter, pMap, colour, rand );
            ret.turnList = newTurnList;
            return ret;
        }
        
        public void draw(PaintEventArgs e)
        {
            foreach( Rectangle r in prevSquares) {
                e.Graphics.FillRectangle(transBrush, r);
            }
            e.Graphics.DrawString(letter.ToString(), font, brush, new PointF(position().X * pMap.gridSize + pMap.xOffset, position().Y * pMap.gridSize + pMap.yOffset));
        }
        public void setPosition(int x, int y)
        {
            if (showRoute)
            {
                prevSquares.Enqueue(new Rectangle(new Point(position().X * pMap.gridSize + pMap.xOffset, position().Y * pMap.gridSize + pMap.yOffset), new System.Drawing.Size(pMap.gridSize, pMap.gridSize)));

                if (prevSquares.Count > 50)
                    prevSquares.Dequeue();
            }
            this.x = x;
            this.y = y;
        }
        public Point position()
        {
            return new Point(x, y);
        }

        public float curDistance()
        {
            return Math.Abs(x - toX) + Math.Abs(y - toY);
        }
        public int CompareTo(BasicActor other)
        {
            return -1*this.fitness.CompareTo(other.fitness);
        }
    }
}
