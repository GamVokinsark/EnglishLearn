namespace EnglishLearn
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.movingPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.closeBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlPanelCheck = new System.Windows.Forms.Panel();
            this.controlPanelAdd = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.controlPanelLearn = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.movingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.movingPanel.Controls.Add(this.title);
            this.movingPanel.Controls.Add(this.button4);
            this.movingPanel.Controls.Add(this.closeBut);
            this.movingPanel.Location = new System.Drawing.Point(0, 0);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(800, 40);
            this.movingPanel.TabIndex = 3;
            this.movingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.movingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.movingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(4, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(69, 31);
            this.title.TabIndex = 1;
            this.title.Text = "English";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeBut
            // 
            this.closeBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBut.BackgroundImage")));
            this.closeBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBut.FlatAppearance.BorderSize = 0;
            this.closeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBut.Location = new System.Drawing.Point(760, 0);
            this.closeBut.Margin = new System.Windows.Forms.Padding(0);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(40, 40);
            this.closeBut.TabIndex = 0;
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 560);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(68)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(10, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check words";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(68)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(484, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add words";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlPanelCheck
            // 
            this.controlPanelCheck.Location = new System.Drawing.Point(0, 40);
            this.controlPanelCheck.Name = "controlPanelCheck";
            this.controlPanelCheck.Size = new System.Drawing.Size(800, 560);
            this.controlPanelCheck.TabIndex = 6;
            this.controlPanelCheck.Visible = false;
            // 
            // controlPanelAdd
            // 
            this.controlPanelAdd.Location = new System.Drawing.Point(0, 40);
            this.controlPanelAdd.Name = "controlPanelAdd";
            this.controlPanelAdd.Size = new System.Drawing.Size(800, 560);
            this.controlPanelAdd.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(68)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(248, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 67);
            this.button3.TabIndex = 5;
            this.button3.Text = "Learn words";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // controlPanelLearn
            // 
            this.controlPanelLearn.Location = new System.Drawing.Point(0, 40);
            this.controlPanelLearn.Name = "controlPanelLearn";
            this.controlPanelLearn.Size = new System.Drawing.Size(800, 560);
            this.controlPanelLearn.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(720, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movingPanel);
            this.Controls.Add(this.controlPanelCheck);
            this.Controls.Add(this.controlPanelAdd);
            this.Controls.Add(this.controlPanelLearn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.movingPanel.ResumeLayout(false);
            this.movingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel controlPanelCheck;
        private System.Windows.Forms.Panel controlPanelAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel controlPanelLearn;
        private System.Windows.Forms.Button button4;
    }
}

