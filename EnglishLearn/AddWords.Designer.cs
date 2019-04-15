namespace EnglishLearn
{
    partial class AddWords
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWords));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fromFileBut = new System.Windows.Forms.Button();
            this.clearBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inpTran = new System.Windows.Forms.TextBox();
            this.inpEng = new System.Windows.Forms.TextBox();
            this.delWords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 560);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBut.Font = new System.Drawing.Font("Harrington", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backBut.Location = new System.Drawing.Point(19, 491);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(119, 52);
            this.backBut.TabIndex = 7;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.delWords);
            this.panel1.Controls.Add(this.fromFileBut);
            this.panel1.Controls.Add(this.clearBut);
            this.panel1.Controls.Add(this.addBut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inpTran);
            this.panel1.Controls.Add(this.inpEng);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(104, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 319);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Translation";
            // 
            // fromFileBut
            // 
            this.fromFileBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.fromFileBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromFileBut.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFileBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fromFileBut.Location = new System.Drawing.Point(437, 283);
            this.fromFileBut.Name = "fromFileBut";
            this.fromFileBut.Size = new System.Drawing.Size(151, 31);
            this.fromFileBut.TabIndex = 7;
            this.fromFileBut.Text = "Insert from file";
            this.fromFileBut.UseVisualStyleBackColor = false;
            this.fromFileBut.Click += new System.EventHandler(this.from_file_Click);
            // 
            // clearBut
            // 
            this.clearBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.clearBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBut.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBut.Location = new System.Drawing.Point(472, 188);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(82, 31);
            this.clearBut.TabIndex = 7;
            this.clearBut.Text = "Clear";
            this.clearBut.UseVisualStyleBackColor = false;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBut.Location = new System.Drawing.Point(241, 237);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(112, 39);
            this.addBut.TabIndex = 7;
            this.addBut.Text = "Add";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adding words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "English word";
            // 
            // inpTran
            // 
            this.inpTran.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpTran.Location = new System.Drawing.Point(304, 141);
            this.inpTran.Margin = new System.Windows.Forms.Padding(0);
            this.inpTran.MaxLength = 100;
            this.inpTran.Name = "inpTran";
            this.inpTran.Size = new System.Drawing.Size(250, 41);
            this.inpTran.TabIndex = 2;
            // 
            // inpEng
            // 
            this.inpEng.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpEng.Location = new System.Drawing.Point(49, 141);
            this.inpEng.Margin = new System.Windows.Forms.Padding(0);
            this.inpEng.MaxLength = 100;
            this.inpEng.Name = "inpEng";
            this.inpEng.Size = new System.Drawing.Size(250, 41);
            this.inpEng.TabIndex = 1;
            // 
            // delWords
            // 
            this.delWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.delWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delWords.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delWords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delWords.Location = new System.Drawing.Point(3, 283);
            this.delWords.Name = "delWords";
            this.delWords.Size = new System.Drawing.Size(157, 31);
            this.delWords.TabIndex = 7;
            this.delWords.Text = "Delete all words";
            this.delWords.UseVisualStyleBackColor = false;
            this.delWords.Click += new System.EventHandler(this.delWords_Click);
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddWords";
            this.Size = new System.Drawing.Size(800, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpTran;
        private System.Windows.Forms.TextBox inpEng;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.Button fromFileBut;
        private System.Windows.Forms.Button delWords;
    }
}
