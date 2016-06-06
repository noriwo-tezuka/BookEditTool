using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEditor
{
    public class BookItem
    {
        public int Count { get; set; }
        public string Sfen { get; set; }
        public string HandPiece { get; set; }
        public string Teban { get; set; }
        public string Move { get; set; }
        public string NextMove { get; set; }
        public string Value { get; set; }
        public string Depth { get; set; }
        public string UseCount { get; set; }
        // コメント編集エリア追加(山内 2016/06/05)
        public string Comment { get; set; }
    }

    class Book
    {
        string FileName = "orgbook.db";
        List<BookItem> BookData = new List<BookItem> { };

        public bool BookRead()
        {
            string Alldata = string.Empty;
            string data = string.Empty;
            string[] info;
            BookItem SubData = new BookItem();

            using (StreamReader sr = new StreamReader(FileName, Encoding.GetEncoding("Shift_JIS")))
            {
                string[] Data = new string[] { };
                string text = string.Empty;
                bool sfenOK = false;
                int intCommentPosition = 0;
                while (sr.Peek() > 0)
                {
                    // 読込
                    text = sr.ReadLine();
                    if ((text.Length == 0) || (text.Substring(0, 1).Equals("#")))
                    {
                        continue;
                    }
                    // 局面か確認
                    if (text.Substring(0, 5).Equals("sfen "))
                    {
                        Data = text.Split(' ');
                        if (Data.Length == 5)
                        {
                            sfenOK = true;
                        }
                        else
                        {
                            sfenOK = false;
                        }
                    }
                    else
                    {
                        if (sfenOK)
                        {
                            SubData = new BookItem();
                            // 局面データの登録
                            SubData.Sfen = Data[1];                 // 局面(sfen)
                            SubData.Teban = Data[2];                // 手番
                            SubData.HandPiece = Data[3];            // 持駒
                            SubData.Count = int.Parse(Data[4]);     // 手数

                            // 局面に対するデータ取得
                            info = text.Split(' ');
                            intCommentPosition = text.IndexOf("//");
                            SubData.Move = info[0];             // 候補手
                            SubData.NextMove = info[1];         // 候補手に対する応手
                            SubData.Value = info[2];            // 評価値
                            SubData.Depth = info[3];            // 探索の深さ
                            SubData.UseCount = info[4];         // 使用回数

                            // コメント編集エリア追加(山内 2016/06/05)
                            if (intCommentPosition >= 0)
                            {
                                SubData.Comment = text.Substring(intCommentPosition + 2).Trim();          // コメント
                            }
                            else
                            {
                                SubData.Comment = string.Empty;
                            }

                            // 局面とデータを登録
                            BookData.Add(SubData);
                        }
                    }

                }
            }
            BookData.Sort((a, b) => a.Count - b.Count);
            return true;
        }

        /// <summary>
        /// 指定したINDEXの局面情報を取得する
        /// </summary>
        /// <param name="BookIndex"></param>
        /// <returns></returns>
        public BookItem Kyokumen(int BookIndex)
        {
            return BookData[BookIndex];
        }

        public int GetIndexNo_Count(int Count)
        {
            for(int i = 0; i< BookData.Count; i++)
            {
                if (BookData[i].Count == Count)
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }
}
