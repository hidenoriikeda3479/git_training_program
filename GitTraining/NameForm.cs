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
    public partial class NameForm : Form
    {

        public string Resultname { get; private set; }
        public NameForm()
        {
            InitializeComponent();
        }

        private void btnName2_Click(object sender, EventArgs e)
        {

            string name= txtName.Text;

            if (txtName.Text == "")
            {
                MessageBox.Show("何も入力されてないんごねぇ");

                DialogResult = DialogResult.No;
                return;    
            }
            DialogResult = DialogResult.OK;

            // 年齢の算出結果を親画面に受け渡すためのプロパティに格納
            Resultname = name;

        }
    }
}
