using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1BeadandoMagyarkartya.BKDH50.AsbothNoemi.mogel
{
    enum Szinek
    {
        Hsziv = 1,
        Level = 2,
        Tok = 3,
        Makk = 4
    }
    enum Szam
    {
       X=0,
       Also=1,
       Felso=2,
       Kiraly=3,
       Asz=4,
       VII=7,
       VIII=8,
       IX=9
    }
    
    internal class Card
    {
        public int Number { get; private set; }

        //32 lapos
        /*11, 12, 13, 14-gyel a piros,
          21, 22,23, 24 értékekkel a zöld,
          31, 32, 33, 34-gyel a makk,
         41, 42, 43, 44 értékkel atök
        és szinenként 7-10(10-est 0-val jelöltem)*/
        public PictureBox PictureBox { get; private set; }
        public Card (int Num, PictureBox pictureBox)
        {
            Number = Num;
            PictureBox = pictureBox;
        }
        public Szinek GetSzin()
        {
            int szin = Number / 10;
            return (Szinek)szin;
        }
        public Szam GetSzam()
        { 
            int szam = Number% 10;
            return (Szam)szam;
        }
    }

}
