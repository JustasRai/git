namespace WindowsFormsApp1
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
            this.skaic_mygtukas = new System.Windows.Forms.Button();
            this.skaic_input = new System.Windows.Forms.TextBox();
            this.skaic_rezul = new System.Windows.Forms.TextBox();
            this.skaic_label = new System.Windows.Forms.Label();
            this.pies_mygtukas = new System.Windows.Forms.Button();
            this.pies_output = new System.Windows.Forms.RichTextBox();
            this.pies_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skaic_prid = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mas_val = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skaic_mygtukas
            // 
            this.skaic_mygtukas.Location = new System.Drawing.Point(87, 48);
            this.skaic_mygtukas.Name = "skaic_mygtukas";
            this.skaic_mygtukas.Size = new System.Drawing.Size(75, 38);
            this.skaic_mygtukas.TabIndex = 0;
            this.skaic_mygtukas.Text = "Skaičiuoti";
            this.skaic_mygtukas.UseVisualStyleBackColor = true;
            this.skaic_mygtukas.Click += new System.EventHandler(this.skaic_mygtukas_Click);
            // 
            // skaic_input
            // 
            this.skaic_input.Location = new System.Drawing.Point(6, 22);
            this.skaic_input.Name = "skaic_input";
            this.skaic_input.Size = new System.Drawing.Size(204, 20);
            this.skaic_input.TabIndex = 1;
            // 
            // skaic_rezul
            // 
            this.skaic_rezul.Location = new System.Drawing.Point(6, 92);
            this.skaic_rezul.Name = "skaic_rezul";
            this.skaic_rezul.Size = new System.Drawing.Size(204, 20);
            this.skaic_rezul.TabIndex = 2;
            // 
            // skaic_label
            // 
            this.skaic_label.AutoSize = true;
            this.skaic_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skaic_label.ForeColor = System.Drawing.Color.Red;
            this.skaic_label.Location = new System.Drawing.Point(216, 96);
            this.skaic_label.Name = "skaic_label";
            this.skaic_label.Size = new System.Drawing.Size(0, 16);
            this.skaic_label.TabIndex = 3;
            // 
            // pies_mygtukas
            // 
            this.pies_mygtukas.Location = new System.Drawing.Point(6, 48);
            this.pies_mygtukas.Name = "pies_mygtukas";
            this.pies_mygtukas.Size = new System.Drawing.Size(75, 38);
            this.pies_mygtukas.TabIndex = 4;
            this.pies_mygtukas.Text = "Piešti";
            this.pies_mygtukas.UseVisualStyleBackColor = true;
            this.pies_mygtukas.Click += new System.EventHandler(this.pies_mygtukas_Click);
            // 
            // pies_output
            // 
            this.pies_output.Location = new System.Drawing.Point(6, 102);
            this.pies_output.Name = "pies_output";
            this.pies_output.Size = new System.Drawing.Size(312, 209);
            this.pies_output.TabIndex = 5;
            this.pies_output.Text = "";
            // 
            // pies_input
            // 
            this.pies_input.Location = new System.Drawing.Point(6, 20);
            this.pies_input.Name = "pies_input";
            this.pies_input.Size = new System.Drawing.Size(100, 20);
            this.pies_input.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mas_val);
            this.groupBox1.Controls.Add(this.skaic_prid);
            this.groupBox1.Controls.Add(this.skaic_rezul);
            this.groupBox1.Controls.Add(this.skaic_mygtukas);
            this.groupBox1.Controls.Add(this.skaic_input);
            this.groupBox1.Controls.Add(this.skaic_label);
            this.groupBox1.Location = new System.Drawing.Point(36, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skaičiavimas";
            // 
            // skaic_prid
            // 
            this.skaic_prid.Location = new System.Drawing.Point(6, 48);
            this.skaic_prid.Name = "skaic_prid";
            this.skaic_prid.Size = new System.Drawing.Size(75, 38);
            this.skaic_prid.TabIndex = 4;
            this.skaic_prid.Text = "Pridėti į masyvą";
            this.skaic_prid.UseVisualStyleBackColor = true;
            this.skaic_prid.Click += new System.EventHandler(this.skaic_prid_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pies_input);
            this.groupBox2.Controls.Add(this.pies_mygtukas);
            this.groupBox2.Controls.Add(this.pies_output);
            this.groupBox2.Location = new System.Drawing.Point(36, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 317);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eglutė";
            // 
            // mas_val
            // 
            this.mas_val.Location = new System.Drawing.Point(6, 127);
            this.mas_val.Name = "mas_val";
            this.mas_val.Size = new System.Drawing.Size(71, 24);
            this.mas_val.TabIndex = 5;
            this.mas_val.Text = "Išvalyti masyvą";
            this.mas_val.UseVisualStyleBackColor = true;
            this.mas_val.Click += new System.EventHandler(this.mas_val_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button skaic_mygtukas;
        private System.Windows.Forms.TextBox skaic_input;
        private System.Windows.Forms.TextBox skaic_rezul;
        private System.Windows.Forms.Label skaic_label;
        private System.Windows.Forms.Button pies_mygtukas;
        private System.Windows.Forms.RichTextBox pies_output;
        private System.Windows.Forms.TextBox pies_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button skaic_prid;
        private System.Windows.Forms.Button mas_val;
    }
}

