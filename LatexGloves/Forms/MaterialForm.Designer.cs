namespace LatexGloves.Forms
{
    partial class MaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialForm));
            this.pnl_Material = new System.Windows.Forms.FlowLayoutPanel();
            this.box_Sort = new System.Windows.Forms.ComboBox();
            this.box_Filter = new System.Windows.Forms.ComboBox();
            this.box_Search = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_Material
            // 
            this.pnl_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Material.AutoScroll = true;
            this.pnl_Material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.pnl_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Material.Location = new System.Drawing.Point(18, 148);
            this.pnl_Material.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Material.Name = "pnl_Material";
            this.pnl_Material.Size = new System.Drawing.Size(761, 496);
            this.pnl_Material.TabIndex = 0;
            // 
            // box_Sort
            // 
            this.box_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Sort.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Sort.FormattingEnabled = true;
            this.box_Sort.Items.AddRange(new object[] {
            "Без сортировки",
            "Название по возрастанию",
            "Название по убыванию",
            "Остаток по возрастанию",
            "Остаток по убыванию",
            "Цена по возрастанию",
            "Цена по убыванию"});
            this.box_Sort.Location = new System.Drawing.Point(18, 103);
            this.box_Sort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Sort.Name = "box_Sort";
            this.box_Sort.Size = new System.Drawing.Size(217, 32);
            this.box_Sort.TabIndex = 1;
            this.box_Sort.SelectedIndexChanged += new System.EventHandler(this.box_Sort_SelectedIndexChanged);
            // 
            // box_Filter
            // 
            this.box_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Filter.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Filter.FormattingEnabled = true;
            this.box_Filter.Location = new System.Drawing.Point(245, 105);
            this.box_Filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(220, 32);
            this.box_Filter.TabIndex = 2;
            this.box_Filter.SelectedIndexChanged += new System.EventHandler(this.box_Filter_SelectedIndexChanged);
            // 
            // box_Search
            // 
            this.box_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Search.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Search.Location = new System.Drawing.Point(475, 103);
            this.box_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(303, 31);
            this.box_Search.TabIndex = 3;
            this.box_Search.TextChanged += new System.EventHandler(this.box_Search_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(789, 192);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(195, 60);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.Location = new System.Drawing.Point(912, -2);
            this.lbl_Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(94, 36);
            this.lbl_Exit.TabIndex = 5;
            this.lbl_Exit.Text = "Выход";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Remove.Location = new System.Drawing.Point(789, 103);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(195, 35);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Сбросить";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список материалов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сортировка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(245, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фильтрация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(475, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поиск";
            // 
            // lbl_Count
            // 
            this.lbl_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Count.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Count.Location = new System.Drawing.Point(840, 143);
            this.lbl_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(96, 39);
            this.lbl_Count.TabIndex = 11;
            this.lbl_Count.Text = "0 из 0";
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.box_Sort);
            this.Controls.Add(this.pnl_Material);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.MaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_Material;
        private System.Windows.Forms.ComboBox box_Sort;
        private System.Windows.Forms.ComboBox box_Filter;
        private System.Windows.Forms.TextBox box_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Count;
    }
}