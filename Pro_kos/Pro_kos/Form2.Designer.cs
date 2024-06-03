namespace Pro_kos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tn_change = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tn_clear2 = new System.Windows.Forms.Button();
            this.tn_delete2 = new System.Windows.Forms.Button();
            this.tn_update2 = new System.Windows.Forms.Button();
            this.tn_save2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tn_search2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tn_change
            // 
            this.tn_change.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_change.Location = new System.Drawing.Point(293, 16);
            this.tn_change.Name = "tn_change";
            this.tn_change.Size = new System.Drawing.Size(83, 23);
            this.tn_change.TabIndex = 53;
            this.tn_change.Text = "CHANGE";
            this.tn_change.UseVisualStyleBackColor = true;
            this.tn_change.Click += new System.EventHandler(this.tn_change_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "vd",
            "mahasiswa"});
            this.comboBox1.Location = new System.Drawing.Point(147, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "JENIS TABEL";
            // 
            // tn_clear2
            // 
            this.tn_clear2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_clear2.Location = new System.Drawing.Point(302, 159);
            this.tn_clear2.Name = "tn_clear2";
            this.tn_clear2.Size = new System.Drawing.Size(75, 23);
            this.tn_clear2.TabIndex = 50;
            this.tn_clear2.Text = "CLEAR";
            this.tn_clear2.UseVisualStyleBackColor = true;
            this.tn_clear2.Click += new System.EventHandler(this.tn_clear2_Click);
            // 
            // tn_delete2
            // 
            this.tn_delete2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_delete2.Location = new System.Drawing.Point(213, 159);
            this.tn_delete2.Name = "tn_delete2";
            this.tn_delete2.Size = new System.Drawing.Size(75, 23);
            this.tn_delete2.TabIndex = 49;
            this.tn_delete2.Text = "DELETE";
            this.tn_delete2.UseVisualStyleBackColor = true;
            this.tn_delete2.Click += new System.EventHandler(this.tn_delete2_Click);
            // 
            // tn_update2
            // 
            this.tn_update2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_update2.Location = new System.Drawing.Point(117, 159);
            this.tn_update2.Name = "tn_update2";
            this.tn_update2.Size = new System.Drawing.Size(75, 23);
            this.tn_update2.TabIndex = 48;
            this.tn_update2.Text = "UPDATE";
            this.tn_update2.UseVisualStyleBackColor = true;
            this.tn_update2.Click += new System.EventHandler(this.tn_update2_Click);
            // 
            // tn_save2
            // 
            this.tn_save2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_save2.Location = new System.Drawing.Point(18, 159);
            this.tn_save2.Name = "tn_save2";
            this.tn_save2.Size = new System.Drawing.Size(75, 23);
            this.tn_save2.TabIndex = 47;
            this.tn_save2.Text = "SAVE";
            this.tn_save2.UseVisualStyleBackColor = true;
            this.tn_save2.Click += new System.EventHandler(this.tn_save2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "ID USER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "NO. HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "NAMA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 41;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(147, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 20);
            this.textBox6.TabIndex = 40;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(147, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 20);
            this.textBox7.TabIndex = 39;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(147, 46);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(183, 20);
            this.textBox8.TabIndex = 38;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(420, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(401, 277);
            this.dataGridView2.TabIndex = 37;
            // 
            // tn_search2
            // 
            this.tn_search2.Image = global::Pro_kos.Properties.Resources.output_onlinepngtools__2_;
            this.tn_search2.Location = new System.Drawing.Point(337, 44);
            this.tn_search2.Name = "tn_search2";
            this.tn_search2.Size = new System.Drawing.Size(26, 23);
            this.tn_search2.TabIndex = 46;
            this.tn_search2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(117, 133);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tn_change);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tn_clear2);
            this.Controls.Add(this.tn_delete2);
            this.Controls.Add(this.tn_update2);
            this.Controls.Add(this.tn_save2);
            this.Controls.Add(this.tn_search2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tn_change;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tn_clear2;
        private System.Windows.Forms.Button tn_delete2;
        private System.Windows.Forms.Button tn_update2;
        private System.Windows.Forms.Button tn_save2;
        private System.Windows.Forms.Button tn_search2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}