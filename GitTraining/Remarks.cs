using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 備考入力画面
    /// </summary>
    public partial class Remarks : Form
    {
        /// <summary>
        /// 備考入力結果
        /// </summary>
        public string ResultRemarks { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Remarks()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 備考入力完了クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            // 入力欄から入力結果を格納
            string Remarkstext = textBox1.Text;

            //入力欄が空文字もしくはnullの場合
            if (string.IsNullOrEmpty(Remarkstext))
            {
                MessageBox.Show("文字を入力してください!");

                // 備考入力結果にNoを設定する
                // DialogResultに値を設定すると処理終了後、自動的に画面が閉じられます
                DialogResult = DialogResult.No;
            }

            // 備考入力結果にOKを設定する
            // DialogResultに値を設定すると処理終了後、自動的に画面が閉じられます
            DialogResult = DialogResult.OK;

            // 備考の入力結果を親画面に受け渡すためのプロパティに格納
            ResultRemarks = Remarkstext;
            
        }
    }
}
