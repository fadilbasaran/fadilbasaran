namespace DortIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.txtboxCevap = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblIsaret = new System.Windows.Forms.Label();
            this.lblGoster1 = new System.Windows.Forms.Label();
            this.lblGoster2 = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblCevapGoster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(338, 51);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(96, 23);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Toplama Öğren";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(571, 51);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(82, 23);
            this.btnBolme.TabIndex = 2;
            this.btnBolme.Text = "Bölme Öğren";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(454, 51);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(97, 23);
            this.btnCıkar.TabIndex = 3;
            this.btnCıkar.Text = "Çıkarma Öğren";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(673, 51);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(99, 23);
            this.btnCarpma.TabIndex = 4;
            this.btnCarpma.Text = "Çarpma Öğren";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // txtboxCevap
            // 
            this.txtboxCevap.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCevap.Location = new System.Drawing.Point(172, 44);
            this.txtboxCevap.MaxLength = 10;
            this.txtboxCevap.Name = "txtboxCevap";
            this.txtboxCevap.Size = new System.Drawing.Size(160, 34);
            this.txtboxCevap.TabIndex = 5;
            this.txtboxCevap.TextChanged += new System.EventHandler(this.txtboxCevap_TextChanged);
            this.txtboxCevap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCevap_KeyPress);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(96, 231);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 26);
            this.lblSonuc.TabIndex = 7;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(267, 136);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblIsaret
            // 
            this.lblIsaret.AutoSize = true;
            this.lblIsaret.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsaret.Location = new System.Drawing.Point(56, 49);
            this.lblIsaret.Name = "lblIsaret";
            this.lblIsaret.Size = new System.Drawing.Size(0, 26);
            this.lblIsaret.TabIndex = 9;
            // 
            // lblGoster1
            // 
            this.lblGoster1.AutoSize = true;
            this.lblGoster1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoster1.Location = new System.Drawing.Point(2, 49);
            this.lblGoster1.Name = "lblGoster1";
            this.lblGoster1.Size = new System.Drawing.Size(0, 26);
            this.lblGoster1.TabIndex = 10;
            // 
            // lblGoster2
            // 
            this.lblGoster2.AutoSize = true;
            this.lblGoster2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoster2.Location = new System.Drawing.Point(92, 49);
            this.lblGoster2.Name = "lblGoster2";
            this.lblGoster2.Size = new System.Drawing.Size(0, 26);
            this.lblGoster2.TabIndex = 11;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(242, 98);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(100, 23);
            this.btnKontrol.TabIndex = 12;
            this.btnKontrol.Text = "Cevabı Konrol et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.Location = new System.Drawing.Point(92, 191);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(0, 26);
            this.lblCevap.TabIndex = 13;
            // 
            // lblCevapGoster
            // 
            this.lblCevapGoster.AutoSize = true;
            this.lblCevapGoster.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCevapGoster.Location = new System.Drawing.Point(26, 231);
            this.lblCevapGoster.Name = "lblCevapGoster";
            this.lblCevapGoster.Size = new System.Drawing.Size(76, 26);
            this.lblCevapGoster.TabIndex = 14;
            this.lblCevapGoster.Text = "Cevap:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.lblCevapGoster);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lblGoster2);
            this.Controls.Add(this.lblGoster1);
            this.Controls.Add(this.lblIsaret);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtboxCevap);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnTopla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dört İşlem Öğreniyorum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.TextBox txtboxCevap;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblIsaret;
        private System.Windows.Forms.Label lblGoster1;
        private System.Windows.Forms.Label lblGoster2;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblCevapGoster;
    }
}

