using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePuzzle6
{
    public partial class Form1 : Form
    {

        public PuzzleMap pMap {set; get;}
        private BasicActor actor;
        private static int GENERATION_SIZE = 50;
        private static int TURN_LIMIT = 400;
        private List<List<BasicActor>> actorLists = new List<List<BasicActor>>();
        private List<BasicActor> drawList = new List<BasicActor>();
        private Random rand;


        public Form1(PuzzleMap pMap, BasicActor topActor)
        {
            this.pMap = pMap;
            actor = topActor;
            InitializeComponent();
            rand = new Random();
            initialize();
        }

        private int curStartPosition = 0;
        private int startRow = 5;
        private int toRow = 25;
        private int startOffset = 5;
        private Color[] rainbowBitches;
        private void initialize()
        {

            //mking.io
            rainbowBitches = Rainbow(171);

            List<List<BasicActor>> a, c, b, e, d, g, i, h, k, m, l, o, n, p, s, r, u, t, w, v, y;

            int[] aArray = { 72, 125, 59, 10, 159, 34, 100, 65, 97, 122, 146, 153 };
            int[] cArray = { 108 };
            int[] bArray = { 132 };
            int[] eArray = { 102, 90, 149, 77, 137, 139, 27, 88, 25, 37, 113, 15, 52, 157, 3, 50, 134, 115, 1, 79 };
            int[] dArray = { 44, 70, 76, 161, 74, 131 };
            int[] gArray = { 55, 118, 30, 128, 93, 12, 142, 6 };
            int[] iArray = { 156, 13 };
            int[] hArray = { 163 };
            int[] kArray = { 101 };
            int[] mArray = { 99 };
            int[] lArray = { 155, 36, 151, 150 };
            int[] oArray = { 18, 56, 7, 94, 130, 105, 169, 67, 119, 129, 45, 41, 84, 143, 31 };
            int[] nArray = { 58, 121, 160, 63, 144, 57, 69, 120, 96, 24, 136, 8, 32, 49, 112, 87, 9, 145, 0, 73, 95, 47, 33 };
            int[] pArray = { 22};
            int[] sArray = { 78, 124 };
            int[] rArray = { 66, 140, 4, 116, 61, 91, 165, 80, 53, 28, 109 };
            int[] uArray = { 42, 19, 62, 170, 68, 106, 164, 21, 85 };
            int[] tArray = { 38, 166, 81, 148 };
            int[] wArray = { 46 };
            int[] vArray = { 26, 89, 14, 51, 2, 138, 114 };
            int[] yArray = { 17, 40, 110, 133, 168, 104, 126, 83 };

            
            
            a = makeList('a', aArray);
            c = makeList('c', cArray);
            b = makeList('b', bArray);
            e = makeList('e', eArray);
            d = makeList('d', dArray);
            g = makeList('g', gArray);
            i = makeList('i', iArray);
            h = makeList('h', hArray);
            k = makeList('k', kArray);
            m = makeList('m', mArray);
            l = makeList('l', lArray);
            o = makeList('o', oArray);
            n = makeList('n', nArray);
            p = makeList('p', pArray);
            s = makeList('s', sArray);
            r = makeList('r', rArray);
            u = makeList('u', uArray);
            t = makeList('t', tArray);
            w = makeList('w', wArray);
            v = makeList('v', vArray);
            y = makeList('y', yArray);

            actorLists = a;
            a.AddRange(c);
            a.AddRange(b);
            a.AddRange(e);
            a.AddRange(d);
            a.AddRange(g);
            a.AddRange(i);
            a.AddRange(h);
            a.AddRange(k);
            a.AddRange(m);
            a.AddRange(l);
            a.AddRange(o);
            a.AddRange(n);
            a.AddRange(p);
            a.AddRange(s);
            a.AddRange(r);
            a.AddRange(u);
            a.AddRange(t);
            a.AddRange(w);
            a.AddRange(v);
            a.AddRange(y);
        }
        //This godforsaken abomination courtesy of Matthew King, mking.io. May the lord have mercy on his soul.
        static Color[] Rainbow(int steps)
        {
            return Enumerable.Range(0, steps).Select(i => (Convert.ToInt32(Math.Floor(5f / steps * i)) % 6) == 0 ? Color.FromArgb(255, Convert.ToInt32(255), Convert.ToInt32(255 * ((5f / steps * i) - Math.Floor(5f / steps * i))), 0) : (Convert.ToInt32(Math.Floor(5f / steps * i)) % 6) == 1 ? Color.FromArgb(255, Convert.ToInt32(255 * (1 - ((5f / steps * i) - Math.Floor(5f / steps * i)))), Convert.ToInt32(255), 0) : (Convert.ToInt32(Math.Floor(5f / steps * i)) % 6) == 2 ? Color.FromArgb(255, 0, Convert.ToInt32(255), Convert.ToInt32(255 * ((5f / steps * i) - Math.Floor(5f / steps * i)))) : (Convert.ToInt32(Math.Floor(5f / steps * i)) % 6) == 3 ? Color.FromArgb(255, 0, Convert.ToInt32(255 * (1 - ((5f / steps * i) - Math.Floor(5f / steps * i)))), Convert.ToInt32(255)) : (Convert.ToInt32(Math.Floor(5f / steps * i)) % 6) == 4 ? Color.FromArgb(255, Convert.ToInt32(255 * ((5f / steps * i) - Math.Floor(5f / steps * i))), 0, Convert.ToInt32(255)) : Color.FromArgb(255, Convert.ToInt32(255), 0, Convert.ToInt32(255 * (1 - ((5f / steps * i) - Math.Floor(5f / steps * i)))))).ToArray();
        }

        private List<List<BasicActor>> makeList(char ch, int[] positions)
        {
            List<List<BasicActor>> ret = new List<List<BasicActor>>(positions.Length);
            foreach (int to in positions)
            {
                ret.Add(makeActorList(to, ch));
                curStartPosition++;
            }
            return ret;
        }


        private List<BasicActor> makeActorList(int to, char ch)
        {
            List<BasicActor> ret = new List<BasicActor>(GENERATION_SIZE);
            for (int i = 0; i < GENERATION_SIZE; i++)
            {
                ret.Add(new BasicActor(curStartPosition + startOffset, startRow, to + startOffset, toRow, TURN_LIMIT, ch, pMap, rainbowBitches[to], rand));
            }
            return ret;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if( pMap != null )
                pMap.draw(e);
            if (drawList != null)
                for (int i = 0; i < drawList.Count; i++)
                    if( drawList.ElementAt(i) != null )
                    drawList.ElementAt(i).draw(e);
        }

        public void resetMap( PuzzleMap pMap, BasicActor topActor)
        {
            this.pMap = pMap;
            actor = topActor;
            updateText();
            this.Refresh();
        }

        private void oneTurn_Click(object sender, EventArgs e)
        {
            pMap.tick();
            updateText();
            this.Refresh();
        }

        private void updateText()
        {
            drawList.Sort();
            String status = "";
            for (int i = 0; i < 5; i++)
            {
                BasicActor a = (BasicActor)drawList.ElementAt(i);
                status = status + "Fitness: " + a.fitness + ", X: " + a.position().X + ", Y: " + a.position().Y + "\n";
            }
                this.statusText.Text = status;
        }

        private List<BasicActor> breed(List<BasicActor> old)
        {
            List<BasicActor> ret = new List<BasicActor>(GENERATION_SIZE);
            for (int i = 0; i < GENERATION_SIZE / 10; i++)
            {
                for (int n = 0; n < GENERATION_SIZE / 10; n++)
                {
                    ret.Add(((BasicActor)old.ElementAt(i)).breed(old.ElementAt(n)));
                }
            }
            return ret;
        }

        private void doGeneration_Click(object sender, EventArgs e)
        {
            do
            {
                List<List<BasicActor>> newGen = new List<List<BasicActor>>();
                //breedButton_Click(sender, e);
                foreach (List<BasicActor> aList in actorLists)
                {

                    newGen.Add(breedList(aList));
                    foreach (BasicActor b in newGen.Last())
                    {
                        b.finishGeneration();
                    }
                }
                
                actorLists = newGen;
                DrawBestOfEveryChar();

                this.Refresh();
            } while (repeatBox.Checked);

        }
        private void DrawBestOfEveryChar()
        {
            drawList = new List<BasicActor>();
            foreach( List<BasicActor> actors in actorLists) {
                actors.Sort();
                drawList.Add(actors.ElementAt(0));
            }
        }

        private void breedButton_Click(object sender, EventArgs e)
        {
            drawList = breed(drawList);
        }
        private List<BasicActor> breedList(List<BasicActor> old)
        {
            List<BasicActor> ret = new List<BasicActor>();
            for (int i = 0; i < GENERATION_SIZE / 10; i++)
            {
                for (int n = 0; n < GENERATION_SIZE / 10; n++)
                {
                    ret.Add(((BasicActor)old.ElementAt(i)).breed(old.ElementAt(n)));
                }
            }
            return ret;
        }
    }
}
