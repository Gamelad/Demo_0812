namespace LatexGloves.Forms
{
    partial class AddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdate));
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_Type = new System.Windows.Forms.ComboBox();
            this.box_In = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CountIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_InStock = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_Min = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_unit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.box_Image = new System.Windows.Forms.PictureBox();
            this.btn_Image = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.Location = new System.Drawing.Point(705, 0);
            this.lbl_Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(94, 36);
            this.lbl_Exit.TabIndex = 6;
            this.lbl_Exit.Text = "Выход";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Название";
            // 
            // box_Title
            // 
            this.box_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Title.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Title.Location = new System.Drawing.Point(5, 33);
            this.box_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Title.Name = "box_Title";
            this.box_Title.Size = new System.Drawing.Size(230, 31);
            this.box_Title.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(245, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Тип";
            // 
            // box_Type
            // 
            this.box_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Type.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Type.FormattingEnabled = true;
            this.box_Type.Location = new System.Drawing.Point(245, 35);
            this.box_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Type.Name = "box_Type";
            this.box_Type.Size = new System.Drawing.Size(220, 32);
            this.box_Type.TabIndex = 13;
            // 
            // box_In
            // 
            this.box_In.Font = new System.Drawing.Font("Candara Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_In.Location = new System.Drawing.Point(10, 120);
            this.box_In.Mask = "00000";
            this.box_In.Name = "box_In";
            this.box_In.Size = new System.Drawing.Size(110, 32);
            this.box_In.TabIndex = 15;
            this.box_In.ValidatingType = typeof(int);
            // 
            // lbl_CountIn
            // 
            this.lbl_CountIn.AutoSize = true;
            this.lbl_CountIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CountIn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_CountIn.Location = new System.Drawing.Point(10, 90);
            this.lbl_CountIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CountIn.Name = "lbl_CountIn";
            this.lbl_CountIn.Size = new System.Drawing.Size(105, 24);
            this.lbl_CountIn.TabIndex = 16;
            this.lbl_CountIn.Text = "В упаковке";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "На складе";
            // 
            // box_InStock
            // 
            this.box_InStock.Font = new System.Drawing.Font("Candara Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_InStock.Location = new System.Drawing.Point(140, 120);
            this.box_InStock.Mask = "00000";
            this.box_InStock.Name = "box_InStock";
            this.box_InStock.Size = new System.Drawing.Size(110, 32);
            this.box_InStock.TabIndex = 17;
            this.box_InStock.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Минимум";
            // 
            // box_Min
            // 
            this.box_Min.Font = new System.Drawing.Font("Candara Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Min.Location = new System.Drawing.Point(270, 120);
            this.box_Min.Mask = "00000";
            this.box_Min.Name = "box_Min";
            this.box_Min.Size = new System.Drawing.Size(110, 32);
            this.box_Min.TabIndex = 19;
            this.box_Min.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(395, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Единица измерения";
            // 
            // box_unit
            // 
            this.box_unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_unit.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_unit.Location = new System.Drawing.Point(395, 123);
            this.box_unit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_unit.Name = "box_unit";
            this.box_unit.Size = new System.Drawing.Size(230, 31);
            this.box_unit.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Описание";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(10, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 147);
            this.textBox1.TabIndex = 23;
            // 
            // box_Image
            // 
            this.box_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Image.Location = new System.Drawing.Point(630, 150);
            this.box_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(160, 145);
            this.box_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_Image.TabIndex = 25;
            this.box_Image.TabStop = false;
            // 
            // btn_Image
            // 
            this.btn_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Image.BackColor = System.Drawing.Color.Transparent;
            this.btn_Image.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Image.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Image.Location = new System.Drawing.Point(640, 305);
            this.btn_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(140, 35);
            this.btn_Image.TabIndex = 26;
            this.btn_Image.Text = "Добавить";
            this.btn_Image.UseVisualStyleBackColor = false;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(10, 385);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(195, 60);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "Сохранить";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.Location = new System.Drawing.Point(600, 385);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(195, 60);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Visible = false;
            // 
            // AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.box_Image);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_unit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_Min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_InStock);
            this.Controls.Add(this.lbl_CountIn);
            this.Controls.Add(this.box_In);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_Title);
            this.Controls.Add(this.lbl_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно добавления/редактирования";
            this.Load += new System.EventHandler(this.AddUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_Type;
        private System.Windows.Forms.MaskedTextBox box_In;
        private System.Windows.Forms.Label lbl_CountIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox box_InStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox box_Min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox box_Image;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
    }
}