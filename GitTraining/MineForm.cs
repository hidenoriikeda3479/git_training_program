using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    /// <summary>
    /// メイン画面
    /// </summary>
    public partial class MineForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MineForm()
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
            // 年齢算出画面を初期化
            var ageForm = new AgeForm();

            // 年齢算出画面を表示
            // ShowDialogは開かれた画面が閉じられるまで親画面操作を禁止します
            // 処理としても↓で一時停止状態になります。
            // 子画面が閉じられると、その結果を受け取ることができます。
            var result = ageForm.ShowDialog();

            // 画面の処理結果を参照
            // 年齢算出がOKの場合にのみ、条件分岐内の処理を実行
            if (result == DialogResult.OK)
            {
                // 画面で算出した年齢を、プロパティ経由で取得
                var age = ageForm.ResultAge;

                // 取得した年齢を結合して出力
                lblAge.Text = $"{age}歳";
            }
            // 処理結果がOK以外なら
            else
            {
                MessageBox.Show("年齢の算出に失敗しました");

                // 年齢の表示を空文字でクリア
                lblAge.Text = string.Empty;
            }
        }

        /// <summary>
        /// 名前編集クリックイベント
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントに関する情報</param>
        private void btnName_Click(object sender, EventArgs e)
        {

            var nameForm = new NameForm();
            var result = nameForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                var name = nameForm.Resultname;
                lblName.Text = $"{name}";
            }

            
            // TODO:子画面のテキストボックス（名前）を入力し、その結果を親画面に反映

            // 画面を初期化

            // 画面をShowDialogで開く

            // 画面の入力結果を受け取る

            // 入力結果に基づいて入力内容をメイン画面に反映する。
        }

        /// <summary>
        /// 備考編集クリックイベント
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントに関する情報</param>
        private void btnRemarks_Click(object sender, EventArgs e)
        {
            // TODO:子画面のテキストボックス（備考）を入力し、その結果を親画面に反映

            // 画面を初期化

            // 画面をShowDialogで開く

            // 画面の入力結果を受け取る

            // 入力結果に基づいて入力内容をメイン画面に反映する。
        }
    }
}
