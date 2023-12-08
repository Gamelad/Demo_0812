using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LatexGloves.Forms.MaterialForm;

namespace LatexGloves.Forms
{
    public partial class AddUpdate : Form
    {
        public AddUpdate()
        {
            InitializeComponent();
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    box_Image.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить изображение: " + ex.Message);
                }
            }
        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {
            DataTable dataTable = db_Connect.fromDB("select*from MaterialType");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (box_Type.Items.Contains(dataTable.Rows[i][1].ToString()) == false)
                {
                    box_Type.Items.Add(dataTable.Rows[i][1].ToString());
                }
            }
            if (AddUpdateClass.Select == "Update")
            {
                btn_Delete.Visible = true;
            }
        }
    }
}
