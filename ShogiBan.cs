using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookEditor
{
    public partial class ShogiBan : Form
    {
        Book clsBook = new Book();
        BookItem BookData;

        public ShogiBan()
        {
            InitializeComponent();
            
            #region 駒の背面透明化
            // 盤面
            labelBoard.Controls.Add(label11);
            labelBoard.Controls.Add(label12);
            labelBoard.Controls.Add(label13);
            labelBoard.Controls.Add(label14);
            labelBoard.Controls.Add(label15);
            labelBoard.Controls.Add(label16);
            labelBoard.Controls.Add(label17);
            labelBoard.Controls.Add(label18);
            labelBoard.Controls.Add(label19);
            labelBoard.Controls.Add(label21);
            labelBoard.Controls.Add(label22);
            labelBoard.Controls.Add(label23);
            labelBoard.Controls.Add(label24);
            labelBoard.Controls.Add(label25);
            labelBoard.Controls.Add(label26);
            labelBoard.Controls.Add(label27);
            labelBoard.Controls.Add(label28);
            labelBoard.Controls.Add(label29);
            labelBoard.Controls.Add(label31);
            labelBoard.Controls.Add(label32);
            labelBoard.Controls.Add(label33);
            labelBoard.Controls.Add(label34);
            labelBoard.Controls.Add(label35);
            labelBoard.Controls.Add(label36);
            labelBoard.Controls.Add(label37);
            labelBoard.Controls.Add(label38);
            labelBoard.Controls.Add(label39);
            labelBoard.Controls.Add(label41);
            labelBoard.Controls.Add(label42);
            labelBoard.Controls.Add(label43);
            labelBoard.Controls.Add(label44);
            labelBoard.Controls.Add(label45);
            labelBoard.Controls.Add(label46);
            labelBoard.Controls.Add(label47);
            labelBoard.Controls.Add(label48);
            labelBoard.Controls.Add(label49);
            labelBoard.Controls.Add(label51);
            labelBoard.Controls.Add(label52);
            labelBoard.Controls.Add(label53);
            labelBoard.Controls.Add(label54);
            labelBoard.Controls.Add(label55);
            labelBoard.Controls.Add(label56);
            labelBoard.Controls.Add(label57);
            labelBoard.Controls.Add(label58);
            labelBoard.Controls.Add(label59);
            labelBoard.Controls.Add(label61);
            labelBoard.Controls.Add(label62);
            labelBoard.Controls.Add(label63);
            labelBoard.Controls.Add(label64);
            labelBoard.Controls.Add(label65);
            labelBoard.Controls.Add(label66);
            labelBoard.Controls.Add(label67);
            labelBoard.Controls.Add(label68);
            labelBoard.Controls.Add(label69);
            labelBoard.Controls.Add(label71);
            labelBoard.Controls.Add(label72);
            labelBoard.Controls.Add(label73);
            labelBoard.Controls.Add(label74);
            labelBoard.Controls.Add(label75);
            labelBoard.Controls.Add(label76);
            labelBoard.Controls.Add(label77);
            labelBoard.Controls.Add(label78);
            labelBoard.Controls.Add(label79);
            labelBoard.Controls.Add(label81);
            labelBoard.Controls.Add(label82);
            labelBoard.Controls.Add(label83);
            labelBoard.Controls.Add(label84);
            labelBoard.Controls.Add(label85);
            labelBoard.Controls.Add(label86);
            labelBoard.Controls.Add(label87);
            labelBoard.Controls.Add(label88);
            labelBoard.Controls.Add(label89);
            labelBoard.Controls.Add(label91);
            labelBoard.Controls.Add(label92);
            labelBoard.Controls.Add(label93);
            labelBoard.Controls.Add(label94);
            labelBoard.Controls.Add(label95);
            labelBoard.Controls.Add(label96);
            labelBoard.Controls.Add(label97);
            labelBoard.Controls.Add(label98);
            labelBoard.Controls.Add(label99);
            // 駒台
            labelFHand.Controls.Add(labelF_Hand_P);
            labelFHand.Controls.Add(labelF_Hand_P_Num);
            labelFHand.Controls.Add(labelF_Hand_L);
            labelFHand.Controls.Add(labelF_Hand_L_Num);
            labelFHand.Controls.Add(labelF_Hand_K);
            labelFHand.Controls.Add(labelF_Hand_K_Num);
            labelFHand.Controls.Add(labelF_Hand_S);
            labelFHand.Controls.Add(labelF_Hand_S_Num);
            labelFHand.Controls.Add(labelF_Hand_G);
            labelFHand.Controls.Add(labelF_Hand_G_Num);
            labelFHand.Controls.Add(labelF_Hand_B);
            labelFHand.Controls.Add(labelF_Hand_B_Num);
            labelFHand.Controls.Add(labelF_Hand_R);
            labelFHand.Controls.Add(labelF_Hand_R_Num);
            // 駒台
            labelEHand.Controls.Add(labelE_Hand_P);
            labelEHand.Controls.Add(labelE_Hand_P_Num);
            labelEHand.Controls.Add(labelE_Hand_L);
            labelEHand.Controls.Add(labelE_Hand_L_Num);
            labelEHand.Controls.Add(labelE_Hand_K);
            labelEHand.Controls.Add(labelE_Hand_K_Num);
            labelEHand.Controls.Add(labelE_Hand_S);
            labelEHand.Controls.Add(labelE_Hand_S_Num);
            labelEHand.Controls.Add(labelE_Hand_G);
            labelEHand.Controls.Add(labelE_Hand_G_Num);
            labelEHand.Controls.Add(labelE_Hand_B);
            labelEHand.Controls.Add(labelE_Hand_B_Num);
            labelEHand.Controls.Add(labelE_Hand_R);
            labelEHand.Controls.Add(labelE_Hand_R_Num);
            #endregion

            // 初期配置
            Review("lnsgkgsnl/1r5b1/ppppppppp/9/9/9/PPPPPPPPP/1B5R1/LNSGKGSNL");
            ReviewHandPiece("-");
            clsBook.BookRead();
            txtBoxSfen.Text = "lnsgkgsnl/1r5b1/ppppppppp/9/9/9/PPPPPPPPP/1B5R1/LNSGKGSNL - b 1";
        }

        #region 盤面再表示
        /// <summary>
        /// 盤面再表示
        /// </summary>
        /// <param name="sfen"></param>
        private void Review(string Sfen)
        {
            string data = Sfen;
            // 駒無し
            data = data.Replace("1", "e");
            data = data.Replace("2", "ee");
            data = data.Replace("3", "eee");
            data = data.Replace("4", "eeee");
            data = data.Replace("5", "eeeee");
            data = data.Replace("6", "eeeeee");
            data = data.Replace("7", "eeeeeee");
            data = data.Replace("8", "eeeeeeee");
            data = data.Replace("9", "eeeeeeeee");
            // 成駒
            data = data.Replace("+P", "T");
            data = data.Replace("+p", "t");
            data = data.Replace("+L", "V");
            data = data.Replace("+l", "v");
            data = data.Replace("+N", "W");
            data = data.Replace("+n", "w");
            data = data.Replace("+S", "X");
            data = data.Replace("+s", "x");
            data = data.Replace("+R", "Y");
            data = data.Replace("+r", "y");
            data = data.Replace("+B", "Z");
            data = data.Replace("+b", "z");

            string[] dan = data.Split('/');

            // 各位置に画像を設定
            // １一　→　９一
            label11.Image = GetImage(dan[0].Substring(8, 1));
            label21.Image = GetImage(dan[0].Substring(7, 1));
            label31.Image = GetImage(dan[0].Substring(6, 1));
            label41.Image = GetImage(dan[0].Substring(5, 1));
            label51.Image = GetImage(dan[0].Substring(4, 1));
            label61.Image = GetImage(dan[0].Substring(3, 1));
            label71.Image = GetImage(dan[0].Substring(2, 1));
            label81.Image = GetImage(dan[0].Substring(1, 1));
            label91.Image = GetImage(dan[0].Substring(0, 1));
            // １二　→　９二
            label12.Image = GetImage(dan[1].Substring(8, 1));
            label22.Image = GetImage(dan[1].Substring(7, 1));
            label32.Image = GetImage(dan[1].Substring(6, 1));
            label42.Image = GetImage(dan[1].Substring(5, 1));
            label52.Image = GetImage(dan[1].Substring(4, 1));
            label62.Image = GetImage(dan[1].Substring(3, 1));
            label72.Image = GetImage(dan[1].Substring(2, 1));
            label82.Image = GetImage(dan[1].Substring(1, 1));
            label92.Image = GetImage(dan[1].Substring(0, 1));
            // １三　→　９三
            label13.Image = GetImage(dan[2].Substring(8, 1));
            label23.Image = GetImage(dan[2].Substring(7, 1));
            label33.Image = GetImage(dan[2].Substring(6, 1));
            label43.Image = GetImage(dan[2].Substring(5, 1));
            label53.Image = GetImage(dan[2].Substring(4, 1));
            label63.Image = GetImage(dan[2].Substring(3, 1));
            label73.Image = GetImage(dan[2].Substring(2, 1));
            label83.Image = GetImage(dan[2].Substring(1, 1));
            label93.Image = GetImage(dan[2].Substring(0, 1));
            // １四　→　９四
            label14.Image = GetImage(dan[3].Substring(8, 1));
            label24.Image = GetImage(dan[3].Substring(7, 1));
            label34.Image = GetImage(dan[3].Substring(6, 1));
            label44.Image = GetImage(dan[3].Substring(5, 1));
            label54.Image = GetImage(dan[3].Substring(4, 1));
            label64.Image = GetImage(dan[3].Substring(3, 1));
            label74.Image = GetImage(dan[3].Substring(2, 1));
            label84.Image = GetImage(dan[3].Substring(1, 1));
            label94.Image = GetImage(dan[3].Substring(0, 1));
            // １五　→　９五
            label15.Image = GetImage(dan[4].Substring(8, 1));
            label25.Image = GetImage(dan[4].Substring(7, 1));
            label35.Image = GetImage(dan[4].Substring(6, 1));
            label45.Image = GetImage(dan[4].Substring(5, 1));
            label55.Image = GetImage(dan[4].Substring(4, 1));
            label65.Image = GetImage(dan[4].Substring(3, 1));
            label75.Image = GetImage(dan[4].Substring(2, 1));
            label85.Image = GetImage(dan[4].Substring(1, 1));
            label95.Image = GetImage(dan[4].Substring(0, 1));
            // １六　→　９六
            label16.Image = GetImage(dan[5].Substring(8, 1));
            label26.Image = GetImage(dan[5].Substring(7, 1));
            label36.Image = GetImage(dan[5].Substring(6, 1));
            label46.Image = GetImage(dan[5].Substring(5, 1));
            label56.Image = GetImage(dan[5].Substring(4, 1));
            label66.Image = GetImage(dan[5].Substring(3, 1));
            label76.Image = GetImage(dan[5].Substring(2, 1));
            label86.Image = GetImage(dan[5].Substring(1, 1));
            label96.Image = GetImage(dan[5].Substring(0, 1));
            // １七　→　９七
            label17.Image = GetImage(dan[6].Substring(8, 1));
            label27.Image = GetImage(dan[6].Substring(7, 1));
            label37.Image = GetImage(dan[6].Substring(6, 1));
            label47.Image = GetImage(dan[6].Substring(5, 1));
            label57.Image = GetImage(dan[6].Substring(4, 1));
            label67.Image = GetImage(dan[6].Substring(3, 1));
            label77.Image = GetImage(dan[6].Substring(2, 1));
            label87.Image = GetImage(dan[6].Substring(1, 1));
            label97.Image = GetImage(dan[6].Substring(0, 1));
            // １八　→　９八
            label18.Image = GetImage(dan[7].Substring(8, 1));
            label28.Image = GetImage(dan[7].Substring(7, 1));
            label38.Image = GetImage(dan[7].Substring(6, 1));
            label48.Image = GetImage(dan[7].Substring(5, 1));
            label58.Image = GetImage(dan[7].Substring(4, 1));
            label68.Image = GetImage(dan[7].Substring(3, 1));
            label78.Image = GetImage(dan[7].Substring(2, 1));
            label88.Image = GetImage(dan[7].Substring(1, 1));
            label98.Image = GetImage(dan[7].Substring(0, 1));
            // １九　→　９九
            label19.Image = GetImage(dan[8].Substring(8, 1));
            label29.Image = GetImage(dan[8].Substring(7, 1));
            label39.Image = GetImage(dan[8].Substring(6, 1));
            label49.Image = GetImage(dan[8].Substring(5, 1));
            label59.Image = GetImage(dan[8].Substring(4, 1));
            label69.Image = GetImage(dan[8].Substring(3, 1));
            label79.Image = GetImage(dan[8].Substring(2, 1));
            label89.Image = GetImage(dan[8].Substring(1, 1));
            label99.Image = GetImage(dan[8].Substring(0, 1));
        }
        #endregion

        #region 駒の画像設定
        /// <summary>
        /// 画像取得
        /// </summary>
        /// <param name="peice"></param>
        /// <returns></returns>
        private Image GetImage(string peice)
        {
            Image img = null;
            if (peice == "P")
            {
                img = Properties.Resources.f_pawn;
            }
            else if (peice == "p")
            {
                img = Properties.Resources.e_pawn;
            }
            else if (peice == "L")
            {
                img = Properties.Resources.f_lance;
            }
            else if (peice == "l")
            {
                img = Properties.Resources.e_lance;
            }
            else if (peice == "N")
            {
                img = Properties.Resources.f_knight;
            }
            else if (peice == "n")
            {
                img = Properties.Resources.e_knight;
            }
            else if (peice == "S")
            {
                img = Properties.Resources.f_silver;
            }
            else if (peice == "s")
            {
                img = Properties.Resources.e_silver;
            }
            else if (peice == "G")
            {
                img = Properties.Resources.f_gold;
            }
            else if (peice == "g")
            {
                img = Properties.Resources.e_gold;
            }
            else if (peice == "R")
            {
                img = Properties.Resources.f_rook;
            }
            else if (peice == "r")
            {
                img = Properties.Resources.e_rook;
            }
            else if (peice == "B")
            {
                img = Properties.Resources.f_bishop;
            }
            else if (peice == "b")
            {
                img = Properties.Resources.e_bishop;
            }
            else if (peice == "K")
            {
                img = Properties.Resources.f_king;
            }
            else if (peice == "k")
            {
                img = Properties.Resources.e_king;
            }
            else if (peice == "T")
            {
                img = Properties.Resources.f_pro_pawn;
            }
            else if (peice == "t")
            {
                img = Properties.Resources.e_pro_pawn;
            }
            else if (peice == "V")
            {
                img = Properties.Resources.f_pro_lance;
            }
            else if (peice == "v")
            {
                img = Properties.Resources.e_pro_lance;
            }
            else if (peice == "W")
            {
                img = Properties.Resources.f_pro_knight;
            }
            else if (peice == "w")
            {
                img = Properties.Resources.e_pro_knight;
            }
            else if (peice == "X")
            {
                img = Properties.Resources.f_pro_silver;
            }
            else if (peice == "x")
            {
                img = Properties.Resources.e_pro_silver;
            }
            else if (peice == "Y")
            {
                img = Properties.Resources.f_pro_rook;
            }
            else if (peice == "y")
            {
                img = Properties.Resources.e_pro_rook;
            }
            else if (peice == "Z")
            {
                img = Properties.Resources.f_pro_bishop;
            }
            else if (peice == "z")
            {
                img = Properties.Resources.e_pro_bishop;
            }
            return img;
        }
        #endregion

        #region 持駒画像の設定
        private void ReviewHandPiece(string HandPiece)
        {
            int F_rook = 0;
            int F_bishop = 0;
            int F_gold = 0;
            int F_silver = 0;
            int F_knight = 0;
            int F_lance = 0;
            int F_pawn = 0;
            int E_rook = 0;
            int E_bishop = 0;
            int E_gold = 0;
            int E_silver = 0;
            int E_knight = 0;
            int E_lance = 0;
            int E_pawn = 0;

            int F_rook_index = HandPiece.IndexOf("R");
            int F_bishop_index = HandPiece.IndexOf("B");
            int F_gold_index = HandPiece.IndexOf("G");
            int F_silver_index = HandPiece.IndexOf("S");
            int F_knight_index = HandPiece.IndexOf("N");
            int F_lance_index = HandPiece.IndexOf("L");
            int F_pawn_index = HandPiece.IndexOf("P");
            int E_rook_index = HandPiece.IndexOf("r");
            int E_bishop_index = HandPiece.IndexOf("b");
            int E_gold_index = HandPiece.IndexOf("g");
            int E_silver_index = HandPiece.IndexOf("s");
            int E_knight_index = HandPiece.IndexOf("n");
            int E_lance_index = HandPiece.IndexOf("l");
            int E_pawn_index = HandPiece.IndexOf("p");

            // 持ち駒の内容把握
            if (HandPiece != "-")
            {
                // 先手：飛車
                if (F_rook_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_rook_index - 1, 1), out F_rook)))
                    {
                        F_rook = 1;
                    }
                }
                else if (F_rook_index == 0)
                {
                    F_rook = 1;
                }
                // 先手：角
                if (F_bishop_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_bishop_index - 1, 1), out F_bishop)))
                    {
                        F_bishop = 1;
                    }
                }
                else if (F_bishop_index == 0)
                {
                    F_bishop = 1;
                }
                // 先手：金
                if (F_gold_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_gold_index - 1, 1), out F_gold)))
                    {
                        F_gold = 1;
                    }
                }
                else if (F_gold_index == 0)
                {
                    F_gold = 1;
                }
                // 先手：銀
                if (F_silver_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_silver_index - 1, 1), out F_silver)))
                    {
                        F_silver = 1;
                    }
                }
                else if (F_silver_index == 0)
                {
                    F_silver = 1;
                }
                // 先手：桂
                if (F_knight_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_knight_index - 1, 1), out F_knight)))
                    {
                        F_knight = 1;
                    }
                }
                else if (F_knight_index == 0)
                {
                    F_knight = 1;
                }
                // 先手：香
                if (F_lance_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_lance_index - 1, 1), out F_lance)))
                    {
                        F_lance = 1;
                    }
                }
                else if (F_lance_index == 0)
                {
                    F_lance = 1;
                }
                // 先手：歩
                if (F_pawn_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(F_pawn_index - 1, 1), out F_pawn)))
                    {
                        F_pawn = 1;
                    }
                }
                else if (F_pawn_index == 0)
                {
                    F_pawn = 1;
                }
                // 後手：飛車
                if (E_rook_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_rook_index - 1, 1), out E_rook)))
                    {
                        E_rook = 1;
                    }
                }
                else if (E_rook_index == 0)
                {
                    E_rook = 1;
                }
                // 後手：角
                if (E_bishop_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_bishop_index - 1, 1), out E_bishop)))
                    {
                        E_bishop = 1;
                    }
                }
                else if (E_bishop_index == 0)
                {
                    E_bishop = 1;
                }
                // 後手：金
                if (E_gold_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_gold_index - 1, 1), out E_gold)))
                    {
                        E_gold = 1;
                    }
                }
                else if (E_gold_index == 0)
                {
                    E_gold = 1;
                }
                // 後手：銀
                if (E_silver_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_silver_index - 1, 1), out E_silver)))
                    {
                        E_silver = 1;
                    }
                }
                else if (E_silver_index == 0)
                {
                    E_silver = 1;
                }
                // 後手：桂
                if (E_knight_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_knight_index - 1, 1), out E_knight)))
                    {
                        E_knight = 1;
                    }
                }
                else if (E_knight_index == 0)
                {
                    E_knight = 1;
                }
                // 後手：香
                if (E_lance_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_lance_index - 1, 1), out E_lance)))
                    {
                        E_lance = 1;
                    }
                }
                else if (F_lance_index == 0)
                {
                    E_lance = 1;
                }
                // 後手：歩
                if (E_pawn_index > 0)
                {
                    if (!(int.TryParse(HandPiece.Substring(E_pawn_index - 1, 1), out E_pawn)))
                    {
                        E_pawn = 1;
                    }
                }
                else if (E_pawn_index == 0)
                {
                    E_pawn = 1;
                }
            }

            // 持駒の表示
            // 先手：飛車
            if (F_rook > 0)
            {
                labelF_Hand_R.Image = Properties.Resources.f_rook;
                labelF_Hand_R_Num.Text = F_rook.ToString();
            }
            else
            {
                labelF_Hand_R.Image = null;
                labelF_Hand_R_Num.Text = string.Empty;
            }
            // 先手：角
            if (F_bishop> 0)
            {
                labelF_Hand_B.Image = Properties.Resources.f_bishop;
                labelF_Hand_B_Num.Text = F_bishop.ToString();
            }
            else
            {
                labelF_Hand_B.Image = null;
                labelF_Hand_B_Num.Text = string.Empty;
            }
            // 先手：金
            if (F_gold > 0)
            {
                labelF_Hand_G.Image = Properties.Resources.f_gold;
                labelF_Hand_G_Num.Text = F_gold.ToString();
            }
            else
            {
                labelF_Hand_G.Image = null;
                labelF_Hand_G_Num.Text = string.Empty;
            }
            // 先手：銀
            if (F_silver > 0)
            {
                labelF_Hand_S.Image = Properties.Resources.f_silver;
                labelF_Hand_S_Num.Text = F_silver.ToString();
            }
            else
            {
                labelF_Hand_S.Image = null;
                labelF_Hand_S_Num.Text = string.Empty;
            }
            // 先手：桂
            if (F_knight > 0)
            {
                labelF_Hand_K.Image = Properties.Resources.f_knight;
                labelF_Hand_K_Num.Text = F_knight.ToString();
            }
            else
            {
                labelF_Hand_K.Image = null;
                labelF_Hand_K_Num.Text = string.Empty;
            }
            // 先手：香
            if (F_lance > 0)
            {
                labelF_Hand_L.Image = Properties.Resources.f_lance;
                labelF_Hand_L_Num.Text = F_lance.ToString();
            }
            else
            {
                labelF_Hand_L.Image = null;
                labelF_Hand_L_Num.Text = string.Empty;
            }
            // 先手：歩
            if (F_pawn > 0)
            {
                labelF_Hand_P.Image = Properties.Resources.f_pawn;
                labelF_Hand_P_Num.Text = F_pawn.ToString();
            }
            else
            {
                labelF_Hand_P.Image = null;
                labelF_Hand_P_Num.Text = string.Empty;
            }
            // 後手：飛車
            if (E_rook > 0)
            {
                labelE_Hand_R.Image = Properties.Resources.e_rook;
                labelE_Hand_R_Num.Text = E_rook.ToString();
            }
            else
            {
                labelE_Hand_R.Image = null;
                labelE_Hand_R_Num.Text = string.Empty;
            }
            // 後手：角
            if (E_bishop > 0)
            {
                labelE_Hand_B.Image = Properties.Resources.e_bishop;
                labelE_Hand_B_Num.Text = E_bishop.ToString();
            }
            else
            {
                labelE_Hand_B.Image = null;
                labelE_Hand_B_Num.Text = string.Empty;
            }
            // 後手：金
            if (E_gold > 0)
            {
                labelE_Hand_G.Image = Properties.Resources.e_gold;
                labelE_Hand_G_Num.Text = E_gold.ToString();
            }
            else
            {
                labelE_Hand_G.Image = null;
                labelE_Hand_G_Num.Text = string.Empty;
            }
            // 後手：銀
            if (E_silver > 0)
            {
                labelE_Hand_S.Image = Properties.Resources.e_silver;
                labelE_Hand_S_Num.Text = E_silver.ToString();
            }
            else
            {
                labelE_Hand_S.Image = null;
                labelE_Hand_S_Num.Text = string.Empty;
            }
            // 後手：桂
            if (E_knight > 0)
            {
                labelE_Hand_K.Image = Properties.Resources.e_knight;
                labelE_Hand_K_Num.Text = E_knight.ToString();
            }
            else
            {
                labelE_Hand_K.Image = null;
                labelE_Hand_K_Num.Text = string.Empty;
            }
            // 後手：香
            if (E_lance > 0)
            {
                labelE_Hand_L.Image = Properties.Resources.e_lance;
                labelE_Hand_L_Num.Text = E_lance.ToString();
            }
            else
            {
                labelE_Hand_L.Image = null;
                labelE_Hand_L_Num.Text = string.Empty;
            }
            // 後手：歩
            if (E_pawn > 0)
            {
                labelE_Hand_P.Image = Properties.Resources.e_pawn;
                labelE_Hand_P_Num.Text = E_pawn.ToString();
            }
            else
            {
                labelE_Hand_P.Image = null;
                labelE_Hand_P_Num.Text = string.Empty;
            }
        }
        #endregion

        #region 候補手表示
        /// <summary>
        /// 候補手の表示
        /// </summary>
        /// <param name="SfenMove"></param>
        /// <returns></returns>
        private string StringMove(string SfenMove)
        {
            string BeforePosition = string.Empty;
            string AfterPosition = string.Empty;

            BeforePosition = PiecePosition(SfenMove.Substring(0, 2));
            AfterPosition = PiecePosition(SfenMove.Substring(2, 2));

            return BeforePosition + "→" + AfterPosition;
        }

        /// <summary>
        /// 候補手変換
        /// </summary>
        /// <param name="Position"></param>
        /// <returns></returns>
        private string PiecePosition(string Position)
        {
            string ColumnPosition = string.Empty;
            string RowPosition = string.Empty;
            // 行
            if (Position.Substring(0, 1) == "1")
            {
                ColumnPosition = "１";
            }
            else if (Position.Substring(0, 1) == "2")
            {
                ColumnPosition = "２";
            }
            else if (Position.Substring(0, 1) == "3")
            {
                ColumnPosition = "３";
            }
            else if (Position.Substring(0, 1) == "4")
            {
                ColumnPosition = "４";
            }
            else if (Position.Substring(0, 1) == "5")
            {
                ColumnPosition = "５";
            }
            else if (Position.Substring(0, 1) == "6")
            {
                ColumnPosition = "６";
            }
            else if (Position.Substring(0, 1) == "7")
            {
                ColumnPosition = "７";
            }
            else if (Position.Substring(0, 1) == "8")
            {
                ColumnPosition = "８";
            }
            else if (Position.Substring(0, 1) == "9")
            {
                ColumnPosition = "９";
            }
            // 段
            if (Position.Substring(1, 1) == "a")
            {
                RowPosition = "一";
            }
            else if (Position.Substring(1, 1) == "b")
            {
                RowPosition = "二";
            }
            else if (Position.Substring(1, 1) == "c")
            {
                RowPosition = "三";
            }
            else if (Position.Substring(1, 1) == "d")
            {
                RowPosition = "四";
            }
            else if (Position.Substring(1, 1) == "e")
            {
                RowPosition = "五";
            }
            else if (Position.Substring(1, 1) == "f")
            {
                RowPosition = "六";
            }
            else if (Position.Substring(1, 1) == "g")
            {
                RowPosition = "七";
            }
            else if (Position.Substring(1, 1) == "h")
            {
                RowPosition = "八";
            }
            else if (Position.Substring(1, 1) == "i")
            {
                RowPosition = "九";
            }

            return ColumnPosition + RowPosition;
        }
        #endregion

        #region 候補手の指手先の色変更
        /// <summary>
        /// 候補手の指手先の色変更
        /// </summary>
        /// <param name="Move"></param>
        private void ChangeColor(string Move)
        {
            string Before = Move.Substring(0, 2);
            string After = Move.Substring(2, 2);
            // 各位置に画像を設定
            label11.BackColor = (Before == "1a") ? Color.GreenYellow : (After == "1a") ? Color.Yellow : Color.Transparent;
            label21.BackColor = (Before == "2a") ? Color.GreenYellow : (After == "2a") ? Color.Yellow : Color.Transparent;
            label31.BackColor = (Before == "3a") ? Color.GreenYellow : (After == "3a") ? Color.Yellow : Color.Transparent;
            label41.BackColor = (Before == "4a") ? Color.GreenYellow : (After == "4a") ? Color.Yellow : Color.Transparent;
            label51.BackColor = (Before == "5a") ? Color.GreenYellow : (After == "5a") ? Color.Yellow : Color.Transparent;
            label61.BackColor = (Before == "6a") ? Color.GreenYellow : (After == "6a") ? Color.Yellow : Color.Transparent;
            label71.BackColor = (Before == "7a") ? Color.GreenYellow : (After == "7a") ? Color.Yellow : Color.Transparent;
            label81.BackColor = (Before == "8a") ? Color.GreenYellow : (After == "8a") ? Color.Yellow : Color.Transparent;
            label91.BackColor = (Before == "9a") ? Color.GreenYellow : (After == "9a") ? Color.Yellow : Color.Transparent;
            label12.BackColor = (Before == "1b") ? Color.GreenYellow : (After == "1b") ? Color.Yellow : Color.Transparent;
            label22.BackColor = (Before == "2b") ? Color.GreenYellow : (After == "2b") ? Color.Yellow : Color.Transparent;
            label32.BackColor = (Before == "3b") ? Color.GreenYellow : (After == "3b") ? Color.Yellow : Color.Transparent;
            label42.BackColor = (Before == "4b") ? Color.GreenYellow : (After == "4b") ? Color.Yellow : Color.Transparent;
            label52.BackColor = (Before == "5b") ? Color.GreenYellow : (After == "5b") ? Color.Yellow : Color.Transparent;
            label62.BackColor = (Before == "6b") ? Color.GreenYellow : (After == "6b") ? Color.Yellow : Color.Transparent;
            label72.BackColor = (Before == "7b") ? Color.GreenYellow : (After == "7b") ? Color.Yellow : Color.Transparent;
            label82.BackColor = (Before == "8b") ? Color.GreenYellow : (After == "8b") ? Color.Yellow : Color.Transparent;
            label92.BackColor = (Before == "9b") ? Color.GreenYellow : (After == "9b") ? Color.Yellow : Color.Transparent;
            label13.BackColor = (Before == "1c") ? Color.GreenYellow : (After == "1c") ? Color.Yellow : Color.Transparent;
            label23.BackColor = (Before == "2c") ? Color.GreenYellow : (After == "2c") ? Color.Yellow : Color.Transparent;
            label33.BackColor = (Before == "3c") ? Color.GreenYellow : (After == "3c") ? Color.Yellow : Color.Transparent;
            label43.BackColor = (Before == "4c") ? Color.GreenYellow : (After == "4c") ? Color.Yellow : Color.Transparent;
            label53.BackColor = (Before == "5c") ? Color.GreenYellow : (After == "5c") ? Color.Yellow : Color.Transparent;
            label63.BackColor = (Before == "6c") ? Color.GreenYellow : (After == "6c") ? Color.Yellow : Color.Transparent;
            label73.BackColor = (Before == "7c") ? Color.GreenYellow : (After == "7c") ? Color.Yellow : Color.Transparent;
            label83.BackColor = (Before == "8c") ? Color.GreenYellow : (After == "8c") ? Color.Yellow : Color.Transparent;
            label93.BackColor = (Before == "9c") ? Color.GreenYellow : (After == "9c") ? Color.Yellow : Color.Transparent;
            label14.BackColor = (Before == "1d") ? Color.GreenYellow : (After == "1d") ? Color.Yellow : Color.Transparent;
            label24.BackColor = (Before == "2d") ? Color.GreenYellow : (After == "2d") ? Color.Yellow : Color.Transparent;
            label34.BackColor = (Before == "3d") ? Color.GreenYellow : (After == "3d") ? Color.Yellow : Color.Transparent;
            label44.BackColor = (Before == "4d") ? Color.GreenYellow : (After == "4d") ? Color.Yellow : Color.Transparent;
            label54.BackColor = (Before == "5d") ? Color.GreenYellow : (After == "5d") ? Color.Yellow : Color.Transparent;
            label64.BackColor = (Before == "6d") ? Color.GreenYellow : (After == "6d") ? Color.Yellow : Color.Transparent;
            label74.BackColor = (Before == "7d") ? Color.GreenYellow : (After == "7d") ? Color.Yellow : Color.Transparent;
            label84.BackColor = (Before == "8d") ? Color.GreenYellow : (After == "8d") ? Color.Yellow : Color.Transparent;
            label94.BackColor = (Before == "9d") ? Color.GreenYellow : (After == "9d") ? Color.Yellow : Color.Transparent;
            label15.BackColor = (Before == "1e") ? Color.GreenYellow : (After == "1e") ? Color.Yellow : Color.Transparent;
            label25.BackColor = (Before == "2e") ? Color.GreenYellow : (After == "2e") ? Color.Yellow : Color.Transparent;
            label35.BackColor = (Before == "3e") ? Color.GreenYellow : (After == "3e") ? Color.Yellow : Color.Transparent;
            label45.BackColor = (Before == "4e") ? Color.GreenYellow : (After == "4e") ? Color.Yellow : Color.Transparent;
            label55.BackColor = (Before == "5e") ? Color.GreenYellow : (After == "5e") ? Color.Yellow : Color.Transparent;
            label65.BackColor = (Before == "6e") ? Color.GreenYellow : (After == "6e") ? Color.Yellow : Color.Transparent;
            label75.BackColor = (Before == "7e") ? Color.GreenYellow : (After == "7e") ? Color.Yellow : Color.Transparent;
            label85.BackColor = (Before == "8e") ? Color.GreenYellow : (After == "8e") ? Color.Yellow : Color.Transparent;
            label95.BackColor = (Before == "9e") ? Color.GreenYellow : (After == "9e") ? Color.Yellow : Color.Transparent;
            label16.BackColor = (Before == "1f") ? Color.GreenYellow : (After == "1f") ? Color.Yellow : Color.Transparent;
            label26.BackColor = (Before == "2f") ? Color.GreenYellow : (After == "2f") ? Color.Yellow : Color.Transparent;
            label36.BackColor = (Before == "3f") ? Color.GreenYellow : (After == "3f") ? Color.Yellow : Color.Transparent;
            label46.BackColor = (Before == "4f") ? Color.GreenYellow : (After == "4f") ? Color.Yellow : Color.Transparent;
            label56.BackColor = (Before == "5f") ? Color.GreenYellow : (After == "5f") ? Color.Yellow : Color.Transparent;
            label66.BackColor = (Before == "6f") ? Color.GreenYellow : (After == "6f") ? Color.Yellow : Color.Transparent;
            label76.BackColor = (Before == "7f") ? Color.GreenYellow : (After == "7f") ? Color.Yellow : Color.Transparent;
            label86.BackColor = (Before == "8f") ? Color.GreenYellow : (After == "8f") ? Color.Yellow : Color.Transparent;
            label96.BackColor = (Before == "9f") ? Color.GreenYellow : (After == "9f") ? Color.Yellow : Color.Transparent;
            label17.BackColor = (Before == "1g") ? Color.GreenYellow : (After == "1g") ? Color.Yellow : Color.Transparent;
            label27.BackColor = (Before == "2g") ? Color.GreenYellow : (After == "2g") ? Color.Yellow : Color.Transparent;
            label37.BackColor = (Before == "3g") ? Color.GreenYellow : (After == "3g") ? Color.Yellow : Color.Transparent;
            label47.BackColor = (Before == "4g") ? Color.GreenYellow : (After == "4g") ? Color.Yellow : Color.Transparent;
            label57.BackColor = (Before == "5g") ? Color.GreenYellow : (After == "5g") ? Color.Yellow : Color.Transparent;
            label67.BackColor = (Before == "6g") ? Color.GreenYellow : (After == "6g") ? Color.Yellow : Color.Transparent;
            label77.BackColor = (Before == "7g") ? Color.GreenYellow : (After == "7g") ? Color.Yellow : Color.Transparent;
            label87.BackColor = (Before == "8g") ? Color.GreenYellow : (After == "8g") ? Color.Yellow : Color.Transparent;
            label97.BackColor = (Before == "9g") ? Color.GreenYellow : (After == "9g") ? Color.Yellow : Color.Transparent;
            label18.BackColor = (Before == "1h") ? Color.GreenYellow : (After == "1h") ? Color.Yellow : Color.Transparent;
            label28.BackColor = (Before == "2h") ? Color.GreenYellow : (After == "2h") ? Color.Yellow : Color.Transparent;
            label38.BackColor = (Before == "3h") ? Color.GreenYellow : (After == "3h") ? Color.Yellow : Color.Transparent;
            label48.BackColor = (Before == "4h") ? Color.GreenYellow : (After == "4h") ? Color.Yellow : Color.Transparent;
            label58.BackColor = (Before == "5h") ? Color.GreenYellow : (After == "5h") ? Color.Yellow : Color.Transparent;
            label68.BackColor = (Before == "6h") ? Color.GreenYellow : (After == "6h") ? Color.Yellow : Color.Transparent;
            label78.BackColor = (Before == "7h") ? Color.GreenYellow : (After == "7h") ? Color.Yellow : Color.Transparent;
            label88.BackColor = (Before == "8h") ? Color.GreenYellow : (After == "8h") ? Color.Yellow : Color.Transparent;
            label98.BackColor = (Before == "9h") ? Color.GreenYellow : (After == "9h") ? Color.Yellow : Color.Transparent;
            label19.BackColor = (Before == "1i") ? Color.GreenYellow : (After == "1i") ? Color.Yellow : Color.Transparent;
            label29.BackColor = (Before == "2i") ? Color.GreenYellow : (After == "2i") ? Color.Yellow : Color.Transparent;
            label39.BackColor = (Before == "3i") ? Color.GreenYellow : (After == "3i") ? Color.Yellow : Color.Transparent;
            label49.BackColor = (Before == "4i") ? Color.GreenYellow : (After == "4i") ? Color.Yellow : Color.Transparent;
            label59.BackColor = (Before == "5i") ? Color.GreenYellow : (After == "5i") ? Color.Yellow : Color.Transparent;
            label69.BackColor = (Before == "6i") ? Color.GreenYellow : (After == "6i") ? Color.Yellow : Color.Transparent;
            label79.BackColor = (Before == "7i") ? Color.GreenYellow : (After == "7i") ? Color.Yellow : Color.Transparent;
            label89.BackColor = (Before == "8i") ? Color.GreenYellow : (After == "8i") ? Color.Yellow : Color.Transparent;
            label99.BackColor = (Before == "9i") ? Color.GreenYellow : (After == "9i") ? Color.Yellow : Color.Transparent;
        }
        #endregion

        /// <summary>
        /// 定跡ファイル読込（インデックス指定）
        /// </summary>
        /// <param name="IndexNo"></param>
        private void BookReadIndex(int IndexNo)
        {
            btnOutRec.Visible = true;
            try
            {
                // 情報取得
                BookData = clsBook.Kyokumen(IndexNo);
                // 取得値の表示
                // 局面の表示
                Review(BookData.Sfen);
                // 持駒の表示
                ReviewHandPiece(BookData.HandPiece);
                // 手番
                textBoxTeban.Text = (BookData.Teban.Equals("b")) ? "先手" : "後手";
                // 手数
                textBoxCount.Text = BookData.Count.ToString();
                // 候補手
                txtBoxMove.Text = StringMove(BookData.Move);
                ChangeColor(BookData.Move);
                // 候補手に対する応手
                txtBoxNextMove.Text = StringMove(BookData.NextMove);
                // 評価値
                txtBoxValue.Text = BookData.Value;

                // 評価値のテキストボックスの色を変化させる(山内 2016/06/05)
                if (Convert.ToInt32(txtBoxValue.Text) > 1)
                {
                    
                    txtBoxValue.BackColor = Color.LightGreen;
                }
                else if (Convert.ToInt32(txtBoxValue.Text) < 0)
                {
                    txtBoxValue.BackColor = Color.LightPink;
                }

                // 探索の深さ
                txtBoxDepth.Text = BookData.Depth;
                // 使用回数
                txtBoxUseCount.Text = BookData.UseCount;
                // sfen 　
                // SFEN文字列に手番と手数表示(山内 2016/06/03)
                //txtBoxSfen.Text = BookData.Sfen
                txtBoxSfen.Text = "sfen " + BookData.Sfen + " " + BookData.Teban + " " + BookData.HandPiece + " " +  BookData.Count;

                // コメント編集エリア追加(山内 2016/06/05)
                txtBoxComment.Text = BookData.Comment;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("定跡ファイル読み込みエラー！" + Environment.NewLine + ex.ToString());
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexNo = 0;
            if (int.TryParse(txtBoxIndex.Text, out indexNo))
            {
                indexNo--;
            }
            else
            {
                indexNo = 0;
                txtBoxIndex.Text = "1";
            }
            BookReadIndex(indexNo);
        }

        private void buttonBefore_Click(object sender, EventArgs e)
        {
            int indexNo = 0;
            if (int.TryParse(txtBoxIndex.Text, out indexNo))
            {
                indexNo--;
                BookReadIndex(indexNo - 1);
                txtBoxIndex.Text = indexNo.ToString();
            }
            else
            {
                MessageBox.Show("データNOに数値を入力してください。");
            }
        }

        private void buttonAfter_Click(object sender, EventArgs e)
        {
            int indexNo = 0;
            if (int.TryParse(txtBoxIndex.Text, out indexNo))
            {
                indexNo++;
                BookReadIndex(indexNo - 1);
                txtBoxIndex.Text = indexNo.ToString();
            }
            else
            {
                MessageBox.Show("データNOに数値を入力してください。");
            }
        }

        private void btnCountBefore_Click(object sender, EventArgs e)
        {
            int Count = 0;
            if (int.TryParse(textBoxCount.Text, out Count))
            {
                if (Count == 1)
                {
                    MessageBox.Show("手数に１より前はありません。");
                    return;
                }
                else
                {
                    Count--;
                }
            }
            else
            {
                MessageBox.Show("手数に数値を入力してください。");
                return;
            }
            int IndexNo = clsBook.GetIndexNo_Count(Count);
            if (IndexNo > 0)
            {
                BookReadIndex(IndexNo - 1);
                txtBoxIndex.Text = IndexNo.ToString();
            }
            else
            {
                MessageBox.Show("指定した手数は見つかりませんでした。");
            }
        }

        private void btnCountAfter_Click(object sender, EventArgs e)
        {
            int Count = 0;
            if (int.TryParse(textBoxCount.Text, out Count))
            {
                Count++;
            }
            else
            {
                MessageBox.Show("手数に数値を入力してください。");
                return;
            }

            int IndexNo = clsBook.GetIndexNo_Count(Count);
            if (IndexNo > 0)
            {
                BookReadIndex(IndexNo);
                txtBoxIndex.Text = IndexNo.ToString();
            }
            else
            {
                MessageBox.Show("指定した手数は見つかりませんでした。");
            }
        }

        private void ShogiBan_Load(object sender, EventArgs e)
        {

        }

        // 出力ボタンとSFENレコード出力機能追加(山内 2016/06/04)
        // レコード読み込んでいないときは非表示
        private void btnOutRec_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxIndex.Text) == false)
            {
                btnOutRec.Visible = true;
                string filePath = "C:/Users/Hiroyuki/BookEditTool/bin/Release/newbook.db";
                string strKaigyo = "\r\n";
                string strSpace = " ";

                // コメント欄から改行を除去する処理を追加(山内 2016/06/04)
                // 動作テスト txtBoxComment.Text = txtBoxComment.Text.Replace(Environment.NewLine, "");
                // string strNextmove = strKaigyo + BookData.Move + strSpace + BookData.NextMove + strSpace + txtBoxValue.Text + strSpace + txtBoxDepth.Text + strSpace + txtBoxUseCount.Text + " //" + txtBoxComment.Text + strKaigyo;

                string strNextmove = strKaigyo + BookData.Move + strSpace + BookData.NextMove + strSpace + txtBoxValue.Text + strSpace + txtBoxDepth.Text + strSpace + txtBoxUseCount.Text + " //" + txtBoxComment.Text.Replace(Environment.NewLine, "") + strKaigyo;


                // trueの場合は追記、falseの場合は更新　
                StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("shift_jis"));
                sw.Write(txtBoxSfen.Text);
                sw.Write(strNextmove);
//                sw.Write(BookData.Move);
//                sw.Write(strSpace);
//                sw.Write(BookData.NextMove);
//                sw.Write(strSpace);
//                sw.Write(txtBoxValue.Text);
//                sw.Write(strSpace);
//                sw.Write(txtBoxDepth.Text);
//                sw.Write(strSpace);
//                sw.Write(txtBoxUseCount.Text);
//                sw.Write(strKaigyo);

                sw.Close();
            }
            else
            {
                btnOutRec.Visible = false;
            }

        }
    }
}
