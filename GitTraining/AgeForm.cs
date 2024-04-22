using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 年齢算出画面
    /// </summary>
    public partial class AgeForm : Form
    {
        /// <summary>
        /// 年齢算出結果
        /// </summary>
        /// <remarks>
        /// このプロパティは親画面に値を返すとき使います。
        /// </remarks>
        public int ResultAge { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AgeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 年齢算出クリックイベント
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントに関する情報</param>
        private void btnAge_Click(object sender, EventArgs e)
        {
            // DateTimePicker から誕生日を取得
            DateTime birthDate = dtpBirthday.Value;

            // 現在の日付を取得
            DateTime today = DateTime.Today;

            // 年齢の基本計算
            int age = today.Year - birthDate.Year;

            // 今日の日付が誕生日より前なら、1歳引く
            if (birthDate > today.AddYears(-age))
                age--;

            // 年齢値が不正の場合は、エラーメッセージを表示する
            if (age < 0)
            {
                MessageBox.Show("過去日付を入力してください");

                // 算出成功結果にNGを設定する
                // 画面が閉じられたときにこの結果が戻り値として渡されます
                // DialogResultに値を設定すると処理終了後、自動的に画面が閉じられます
                DialogResult = DialogResult.No;
                return;
            }

            // 算出成功結果にOKを設定する
            // DialogResultに値を設定すると処理終了後、自動的に画面が閉じられます
            DialogResult = DialogResult.OK;

            // 年齢の算出結果を親画面に受け渡すためのプロパティに格納
            ResultAge = age;
        }
    }
}
