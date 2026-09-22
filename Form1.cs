using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormOgretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgretici_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Bu bir Buton nesnesidir.\n\n" +
            "Programlarda belirli bir işlemi başlatmak için kullanılır.\n" +
            "Üzerine tıklandığında Click olayı çalışır.",
                "Buton",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                        MessageBox.Show(
                "Bu bir CheckBox nesnesidir.\n\n" +
                "Bir seçeneğin seçilip seçilmediğini belirtmek için kullanılır. " +
                "Birden fazla CheckBox aynı anda seçilebilir.",
                "CheckBox",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void cmbOgretici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Bu bir DateTimePicker nesnesidir.\n\n" +
    "Kullanıcının tarih ve saat seçmesini sağlar.",
    "DateTimePicker",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
    );
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Bu bir GroupBox nesnesidir.\n\n" +
    "Kontrolleri belirli gruplar içerisinde düzenlemek için kullanılır. " +
    "Formun daha anlaşılır görünmesini sağlar.",
    "GroupBox",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Bu bir ListBox nesnesidir.\n\n" +
    "Seçenekleri açık bir liste halinde göstermek ve kullanıcının " +
    "bu seçeneklerden seçim yapmasını sağlamak için kullanılır.",
    "ListBox",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }

        private void menuStripNedirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Bu bir MenuStrip nesnesidir.\n\n" +
    "Program içerisinde menü başlıkları ve alt menüler oluşturmak için kullanılır.",
    "MenuStrip",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Bu bir PictureBox nesnesidir.\n\n" +
    "Form üzerinde resim veya görsel göstermek için kullanılır.",
    "PictureBox",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }
    }
}
