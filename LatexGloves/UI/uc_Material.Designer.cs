namespace LatexGloves.UI
{
    partial class uc_Material
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_Image = new System.Windows.Forms.PictureBox();
            this.lbl_TypeTitle = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Sup = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // box_Image
            // 
            this.box_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Image.Location = new System.Drawing.Point(4, 8);
            this.box_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(164, 168);
            this.box_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_Image.TabIndex = 0;
            this.box_Image.TabStop = false;
            // 
            // lbl_TypeTitle
            // 
            this.lbl_TypeTitle.AutoSize = true;
            this.lbl_TypeTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.lbl_TypeTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_TypeTitle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_TypeTitle.Location = new System.Drawing.Point(175, 5);
            this.lbl_TypeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TypeTitle.Name = "lbl_TypeTitle";
            this.lbl_TypeTitle.Size = new System.Drawing.Size(114, 29);
            this.lbl_TypeTitle.TabIndex = 8;
            this.lbl_TypeTitle.Text = "Type|Title";
            this.lbl_TypeTitle.Click += new System.EventHandler(this.lbl_TypeTitle_Click);
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Min.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Min.Location = new System.Drawing.Point(180, 55);
            this.lbl_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(43, 24);
            this.lbl_Min.TabIndex = 12;
            this.lbl_Min.Text = "Min";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Stock.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stock.Location = new System.Drawing.Point(540, 79);
            this.lbl_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(58, 24);
            this.lbl_Stock.TabIndex = 13;
            this.lbl_Stock.Text = "Ctock";
            // 
            // lbl_Sup
            // 
            this.lbl_Sup.AutoSize = true;
            this.lbl_Sup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Sup.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Sup.Location = new System.Drawing.Point(180, 135);
            this.lbl_Sup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sup.Name = "lbl_Sup";
            this.lbl_Sup.Size = new System.Drawing.Size(42, 24);
            this.lbl_Sup.TabIndex = 14;
            this.lbl_Sup.Text = "Sup";
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Cost.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cost.Location = new System.Drawing.Point(180, 100);
            this.lbl_Cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(47, 24);
            this.lbl_Cost.TabIndex = 15;
            this.lbl_Cost.Text = "Cost";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.lbl_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.Location = new System.Drawing.Point(660, 5);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(35, 29);
            this.lbl_ID.TabIndex = 16;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // uc_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.lbl_Sup);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_TypeTitle);
            this.Controls.Add(this.box_Image);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_Material";
            this.Size = new System.Drawing.Size(700, 182);
            this.Load += new System.EventHandler(this.uc_Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box_Image;
        private System.Windows.Forms.Label lbl_TypeTitle;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Sup;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_ID;
    }
}
