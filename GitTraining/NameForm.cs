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
    /// 名前画面
    /// </summary>
    public partial class NameForm : Form
    {
        /// <summary>
        /// 名前編集
        /// </summary>
        public string ResultName { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 名前編集イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            // 何も入力されていな場合、エラーメッセージを表示する
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("何も入力されていません");

                // 入力の成否
                DialogResult = DialogResult.No;
                return;
            }

            // 入力成功時に自動で画面を閉じる
            DialogResult = DialogResult.OK;

            // 名前の入力結果を親画面に受け渡すためのプロパティに格納
            ResultName = name;
        }
    }
}
