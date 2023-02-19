namespace ZoakiFinal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capybara = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.buttonext = new System.Windows.Forms.Button();
            this.buttonnormal = new System.Windows.Forms.Button();
            this.buttoneasy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Stats = new System.Windows.Forms.Button();
            this.ReturnBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clicks: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // capybara
            // 
            this.capybara.BackColor = System.Drawing.Color.Transparent;
            this.capybara.BackgroundImage = global::ZoakiFinal.Properties.Resources.capybara;
            this.capybara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.capybara.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.capybara.FlatAppearance.BorderSize = 0;
            this.capybara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.capybara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.capybara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capybara.Location = new System.Drawing.Point(336, 166);
            this.capybara.Name = "capybara";
            this.capybara.Size = new System.Drawing.Size(102, 87);
            this.capybara.TabIndex = 2;
            this.capybara.UseVisualStyleBackColor = false;
            this.capybara.Click += new System.EventHandler(this.capybara_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ZoakiFinal.Properties.Resources.retry;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(716, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 64);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonext
            // 
            this.buttonext.Location = new System.Drawing.Point(703, 12);
            this.buttonext.Name = "buttonext";
            this.buttonext.Size = new System.Drawing.Size(88, 25);
            this.buttonext.TabIndex = 4;
            this.buttonext.Text = "Extreme Mode";
            this.buttonext.UseVisualStyleBackColor = true;
            this.buttonext.Click += new System.EventHandler(this.buttonext_Click_1);
            // 
            // buttonnormal
            // 
            this.buttonnormal.Location = new System.Drawing.Point(609, 12);
            this.buttonnormal.Name = "buttonnormal";
            this.buttonnormal.Size = new System.Drawing.Size(88, 25);
            this.buttonnormal.TabIndex = 5;
            this.buttonnormal.Text = "Normal Mode";
            this.buttonnormal.UseVisualStyleBackColor = true;
            this.buttonnormal.Click += new System.EventHandler(this.buttonnormal_Click_1);
            // 
            // buttoneasy
            // 
            this.buttoneasy.Location = new System.Drawing.Point(515, 12);
            this.buttoneasy.Name = "buttoneasy";
            this.buttoneasy.Size = new System.Drawing.Size(88, 25);
            this.buttoneasy.TabIndex = 6;
            this.buttoneasy.Text = "Easy Mode";
            this.buttoneasy.UseVisualStyleBackColor = true;
            this.buttoneasy.Click += new System.EventHandler(this.buttoneasy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Yellow;
            this.Save.Location = new System.Drawing.Point(12, 374);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(59, 28);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.Color.Yellow;
            this.Stats.Location = new System.Drawing.Point(12, 410);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(59, 28);
            this.Stats.TabIndex = 9;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = false;
            this.Stats.Click += new System.EventHandler(this.Stats_Click_1);
            // 
            // ReturnBTN
            // 
            this.ReturnBTN.BackColor = System.Drawing.Color.Yellow;
            this.ReturnBTN.Location = new System.Drawing.Point(12, 195);
            this.ReturnBTN.Name = "ReturnBTN";
            this.ReturnBTN.Size = new System.Drawing.Size(59, 28);
            this.ReturnBTN.TabIndex = 10;
            this.ReturnBTN.Text = "Return";
            this.ReturnBTN.UseVisualStyleBackColor = false;
            this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 140);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZoakiFinal.Properties.Resources.space;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReturnBTN);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttoneasy);
            this.Controls.Add(this.buttonnormal);
            this.Controls.Add(this.buttonext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.capybara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capybara";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button capybara;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonext;
        private System.Windows.Forms.Button buttonnormal;
        private System.Windows.Forms.Button buttoneasy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.Button ReturnBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

