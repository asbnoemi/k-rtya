using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Prog1BeadandoMagyarkartya.BKDH50.AsbothNoemi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Prog1BeadandoMagyarkartya.BKDH50.AsbothNoemi.mogel
{

    public class CardHandler
    {
        Random rnd = new Random();
        const string PICTURE_PATH = "pic";
        Form1 form;
        private Card[,] cards;
        public CardHandler(Form1 form1)
        {
            form = form1;
            cards = new Card[8, 4]
                {
                    {
                        new Card(11, form.szivasz),
                        new Card(21, form.levelasz),
                        new Card(31, form.makkasz),
                        new Card(41, form.tokasz)
                    },
                    {
                        new Card(12, form.szivkiraly),
                        new Card(22, form.levelkiraly),
                        new Card(32, form.makkiraly),
                        new Card(42, form.tokkiraly)
                    },
                    {
                        new Card(13, form.szivfelo),
                        new Card(23, form.levelfelso),
                        new Card(33, form.makkfelso),
                        new Card(43, form.tokfelso)
                    },
                    {
                        new Card(14, form.szivalso),
                        new Card(24, form.levelalso),
                        new Card(34, form.makkalso),
                        new Card(44, form.tokalso)
                    },
                    {
                        new Card(10, form.szivx),
                        new Card(20, form.levelx),
                        new Card(30, form.tokx),
                        new Card(40, form.tokx)
                    },
                    {
                        new Card(19, form.szivix),
                        new Card(29, form.levelx),
                        new Card(39, form.makkix),
                        new Card(49, form.tokix)
                    },
                    {
                        new Card(18, form.szivviii),
                        new Card(28, form.levelviii),
                        new Card(38, form.tokviii),
                        new Card(48, form.tokviii)
                    },
                    {
                        new Card(17, form.szivvii),
                        new Card(27, form.levelvii),
                        new Card(37, form.makkvii),
                        new Card(47, form.tökvii)
                    }
                };
        }

      

        public void exchangeCard(int X1, int Y1, int X2, int Y2)
        {
            Card k1 = cards[Y1, X1];
            Card k2 = cards[Y2, X2];
            form.label3.Text = "cserélt poziciok "+X1+","+Y1+" - "+X2+","+Y2;
            Point p = k1.PictureBox.Location;
            k1.PictureBox.Location = k2.PictureBox.Location;
            k2.PictureBox.Location = p;
            form.Refresh();
            cards[Y1, X1] = k2;
            cards[Y1, X2] = k1;
            form.Refresh();
        }
        public int[] RandomPoint()
        {
            
            int x1 = rnd.Next(0, 3);
            int y1 = rnd.Next(0, 7);
            return new int[] { x1, y1 };
        }
        public int[] test(int raw, int column)
        {
            if (raw > 0)
            {
                if (!check(cards[raw - 1, column].Number, cards[raw, column].Number))
                {
                    return new int[] { raw - 1, column };
                }
                else if (raw < 8)
                {
                    if (!check(cards[raw + 1, column].Number, cards[raw, column].Number))
                    {
                        return new int[] { raw + 1, column };
                    }
                    else if (column > 0)
                    {
                        if (!check(cards[raw, column - 1].Number, cards[raw, column].Number))
                        {
                            return new int[] { raw, column - 1 };
                        }
                        else if (column < 4)
                        {
                            if (!check(cards[raw, column + 1].Number, cards[raw, column].Number))
                            {
                                return new int[] { raw, column + 1 };
                            }
                        }
                        else if (raw > 0 && column > 0)
                        {
                            if (!check(cards[raw - 1, column - 1].Number, cards[raw, column].Number))
                            {
                                return new int[] { raw - 1, column - 1 };
                            }
                        }
                        else if (raw < 8 && column < 4)
                        {
                            if (!check(cards[raw + 1, column + 1].Number, cards[raw, column].Number))
                            {
                                return new int[] { raw + 1, column + 1 };
                            }
                        }
                        else if (raw < 8 && column > 0)
                        {
                            if (!check(cards[raw + 1, column - 1].Number, cards[raw, column].Number))
                            {
                                return new int[] { raw + 1, column - 1 };
                            }
                        }
                        else if (raw > 0 && column < 4)
                        {
                            if (!check(cards[raw - 1, column + 1].Number, cards[raw, column].Number))
                            {
                                return new int[] { raw - 1, column + 1 };
                            }
                        }
                    }
                }
            }
            return  null;
        }


        bool check(int x1, int x2)
        {
            bool rt = (!(x1 /10== x2 /10 ) && !(x1 %10== x2%10 ));
            return rt;

        }
    }          
}
        