using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePuzzle6
{
    static class Program
    {

        private static Form1 form;
        private static PuzzleMap pMap;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pMap = new PuzzleMap(200, 40, 8);
            

            BasicActor a = new BasicActor(1, 1, 10, 10, 100, 'a', pMap, Color.Red, new Random() );
            form = new Form1(pMap, a );
            Application.Run(form);

            form.pMap = pMap;
            form.Refresh();

        }


    }
}
