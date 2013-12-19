using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePuzzle6
{
    public interface IActor
    {
        void tick();
        void draw(PaintEventArgs e);
        Point position();
        void setPosition(int x, int y);
        void finishGeneration();

        float fitness { get; set; }
    }
}
