
namespace _7.Array
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.koko_kentta = new System.Windows.Forms.TextBox();
            this.luo = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tall_Num = new System.Windows.Forms.TextBox();
            this.tall_Indeksi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.haku_indeksi = new System.Windows.Forms.TextBox();
            this.haku = new System.Windows.Forms.Button();
            this.tulos = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "TAULUKON LUONTI";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 143);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Taulukon koko:";
            // 
            // koko_kentta
            // 
            this.koko_kentta.Location = new System.Drawing.Point(181, 149);
            this.koko_kentta.Name = "koko_kentta";
            this.koko_kentta.Size = new System.Drawing.Size(44, 22);
            this.koko_kentta.TabIndex = 3;
            // 
            // luo
            // 
            this.luo.Location = new System.Drawing.Point(289, 143);
            this.luo.Name = "luo";
            this.luo.Size = new System.Drawing.Size(147, 34);
            this.luo.TabIndex = 4;
            this.luo.Text = "Luo taulukko";
            this.luo.UseVisualStyleBackColor = true;
            this.luo.Click += new System.EventHandler(this.luo_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(203, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 23);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "TALLENNUS";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(24, 301);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 23);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Talletettava numero:";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(24, 342);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 23);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Talletuspaikan indeksi:";
            // 
            // tall_Num
            // 
            this.tall_Num.Location = new System.Drawing.Point(255, 305);
            this.tall_Num.Name = "tall_Num";
            this.tall_Num.Size = new System.Drawing.Size(44, 22);
            this.tall_Num.TabIndex = 8;
            // 
            // tall_Indeksi
            // 
            this.tall_Indeksi.Location = new System.Drawing.Point(255, 346);
            this.tall_Indeksi.Name = "tall_Indeksi";
            this.tall_Indeksi.Size = new System.Drawing.Size(44, 22);
            this.tall_Indeksi.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Talleta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(247, 436);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(52, 23);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "Haku";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(24, 509);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(211, 23);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "Talletuspaikan indeksi:";
            // 
            // haku_indeksi
            // 
            this.haku_indeksi.Location = new System.Drawing.Point(255, 513);
            this.haku_indeksi.Name = "haku_indeksi";
            this.haku_indeksi.Size = new System.Drawing.Size(44, 22);
            this.haku_indeksi.TabIndex = 13;
            // 
            // haku
            // 
            this.haku.Location = new System.Drawing.Point(343, 507);
            this.haku.Name = "haku";
            this.haku.Size = new System.Drawing.Size(147, 34);
            this.haku.TabIndex = 14;
            this.haku.Text = "Hae";
            this.haku.UseVisualStyleBackColor = true;
            this.haku.Click += new System.EventHandler(this.haku_Click);
            // 
            // tulos
            // 
            this.tulos.AutoSize = true;
            this.tulos.Location = new System.Drawing.Point(253, 564);
            this.tulos.Name = "tulos";
            this.tulos.Size = new System.Drawing.Size(0, 17);
            this.tulos.TabIndex = 15;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(247, 562);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(61, 31);
            this.result.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(545, 602);
            this.Controls.Add(this.result);
            this.Controls.Add(this.tulos);
            this.Controls.Add(this.haku);
            this.Controls.Add(this.haku_indeksi);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tall_Indeksi);
            this.Controls.Add(this.tall_Num);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.luo);
            this.Controls.Add(this.koko_kentta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox koko_kentta;
        private System.Windows.Forms.Button luo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tall_Num;
        private System.Windows.Forms.TextBox tall_Indeksi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox haku_indeksi;
        private System.Windows.Forms.Button haku;
        private System.Windows.Forms.Label tulos;
        private System.Windows.Forms.Label result;
    }
}

