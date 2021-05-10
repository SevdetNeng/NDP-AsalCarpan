namespace NDPodev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblY = new System.Windows.Forms.Label();
            this.btnSon = new System.Windows.Forms.Button();
            this.btnArk = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblY.Location = new System.Drawing.Point(46, 128);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(16, 15);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            this.lblY.Click += new System.EventHandler(this.lblY_Click);
            // 
            // btnSon
            // 
            this.btnSon.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSon.Location = new System.Drawing.Point(164, 184);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(87, 23);
            this.btnSon.TabIndex = 5;
            this.btnSon.Text = "SON";
            this.btnSon.UseVisualStyleBackColor = false;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnArk
            // 
            this.btnArk.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnArk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnArk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArk.Location = new System.Drawing.Point(49, 183);
            this.btnArk.Name = "btnArk";
            this.btnArk.Size = new System.Drawing.Size(83, 23);
            this.btnArk.TabIndex = 6;
            this.btnArk.Text = "ARKADAŞ MI";
            this.btnArk.UseVisualStyleBackColor = false;
            this.btnArk.Click += new System.EventHandler(this.btnArk_Click);
            // 
            // txtX
            // 
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX.Location = new System.Drawing.Point(92, 39);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(159, 20);
            this.txtX.TabIndex = 7;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtY
            // 
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY.Location = new System.Drawing.Point(92, 128);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(159, 20);
            this.txtY.TabIndex = 8;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblX.Location = new System.Drawing.Point(46, 42);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(16, 15);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 232);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnArk);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.lblY);
            this.Name = "Form1";
            this.Text = "Arkadaş Sayılar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnArk;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblX;
    }
}

