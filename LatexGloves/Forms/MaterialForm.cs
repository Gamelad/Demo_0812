using LatexGloves.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatexGloves.Forms
{
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
        }
        
        private void MaterialForm_Load(object sender, EventArgs e)
        {
            box_Filter.Items.Add("Все типы");
            DataTable dataTable = db_Connect.fromDB("select*from MaterialType");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (box_Filter.Items.Contains(dataTable.Rows[i][1].ToString()) == false)
                {
                    box_Filter.Items.Add(dataTable.Rows[i][1].ToString());
                }
            }
            uc_Load();
        }
        /// <summary>
        /// метод для отображения, поиска, сортировки и фильтрации UC
        /// </summary>
        private void uc_Load()
        {
            try
            {
                int result = 0;
                pnl_Material.Controls.Clear();
                DataTable dataTable = db_Connect.fromDB($"execute sp_Load '{box_Filter.SelectedItem}','{box_Sort.SelectedIndex}','{box_Search.Text}'");
                for (int i = 0;i < dataTable.Rows.Count;i++)
                {
                    uc_Material uc = new uc_Material();
                    uc_Material.uc_id = (int)dataTable.Rows[i][0];
                    pnl_Material.Controls.Add(uc);
                    result++;
                }
                DataTable dataTable1 = db_Connect.fromDB("select*from Material");
                lbl_Count.Text = $"{result} из {dataTable1.Rows.Count}";
                if (result == 0)
                {
                    MessageBox.Show("Ничего не найдено", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void box_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void box_Search_TextChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            box_Filter.SelectedIndex = 0;
            box_Sort.SelectedIndex = 0;
            box_Search.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddUpdateClass.Select = "Add";
            AddUpdate addUpdate = new AddUpdate();
            addUpdate.ShowDialog();
        }

        public static class AddUpdateClass
        {
            public static string Select;
        }
    }
}
