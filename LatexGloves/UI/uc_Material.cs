using LatexGloves.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LatexGloves.Forms.MaterialForm;

namespace LatexGloves.UI
{
    public partial class uc_Material : UserControl
    {
        public static int uc_id {  get; set; }
        public uc_Material()
        {
            InitializeComponent();
        }

        private void uc_Material_Load(object sender, EventArgs e)
        {
            material_Load();
        }
        /// <summary>
        /// заполнение UserControl
        /// </summary>
        private void material_Load()
        {
            try
            {
                DataTable dataTable = db_Connect.fromDB($"select*from v_Material where ID = '{uc_id}'");
                for ( int i = 0; i < dataTable.Rows.Count; i++ )
                {
                    lbl_ID.Text = $"{dataTable.Rows[i][0]}";
                    lbl_TypeTitle.Text = $"{dataTable.Rows[i][9]}|{dataTable.Rows[i][1]}";
                    lbl_Min.Text = $"Минимальное количество: {dataTable.Rows[i][5]} шт.";
                    lbl_Sup.Text = $"Поставщик: {dataTable.Rows[i][10]}";
                    lbl_Stock.Text = $"Остаток: {dataTable.Rows[i][4]} шт.";
                    lbl_Cost.Text = $"Цена: {dataTable.Rows[i][7]} руб.";
                    if (dataTable.Rows[i][8].ToString() != "")
                    {
                        box_Image.Image = Image.FromFile($@"{dataTable.Rows[i][8]}");
                    }
                    else
                    {
                        box_Image.Image = Image.FromFile(@"Images\picture.png");
                    }
                    if (Convert.ToInt32(dataTable.Rows[i][4]) < Convert.ToInt32(dataTable.Rows[i][5]))
                    {
                        BackColor = Color.LightPink;
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class Material
        {
            public static int ID;
        }

        private void lbl_TypeTitle_Click(object sender, EventArgs e)
        {
            AddUpdateClass.Select = "Update";
            Material.ID = Convert.ToInt32(lbl_ID.Text);
            AddUpdate addUpdate = new AddUpdate();
            addUpdate.ShowDialog();
        }
    }
}
