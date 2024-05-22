namespace agenda
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.INSERIR = new System.Windows.Forms.Button();
            this.PESQUISAR = new System.Windows.Forms.Button();
            this.SAIR = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGENDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INSERIR
            // 
            this.INSERIR.Location = new System.Drawing.Point(161, 64);
            this.INSERIR.Name = "INSERIR";
            this.INSERIR.Size = new System.Drawing.Size(153, 67);
            this.INSERIR.TabIndex = 1;
            this.INSERIR.Text = "Editar";
            this.INSERIR.UseVisualStyleBackColor = true;
            this.INSERIR.Click += new System.EventHandler(this.INSERIR_Click);
            // 
            // PESQUISAR
            // 
            this.PESQUISAR.Location = new System.Drawing.Point(161, 155);
            this.PESQUISAR.Name = "PESQUISAR";
            this.PESQUISAR.Size = new System.Drawing.Size(153, 67);
            this.PESQUISAR.TabIndex = 2;
            this.PESQUISAR.Text = "Pesquisar";
            this.PESQUISAR.UseVisualStyleBackColor = true;
            this.PESQUISAR.Click += new System.EventHandler(this.PESQUISAR_Click);
            // 
            // SAIR
            // 
            this.SAIR.Location = new System.Drawing.Point(161, 241);
            this.SAIR.Name = "SAIR";
            this.SAIR.Size = new System.Drawing.Size(153, 67);
            this.SAIR.TabIndex = 3;
            this.SAIR.Text = "Sair";
            this.SAIR.UseVisualStyleBackColor = true;
            this.SAIR.Click += new System.EventHandler(this.SAIR_Click);
            // 
            // label_versao
            // 
            this.label_versao.Location = new System.Drawing.Point(12, 349);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(448, 23);
            this.label_versao.TabIndex = 0;
            this.label_versao.Text = "versao";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 381);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.SAIR);
            this.Controls.Add(this.PESQUISAR);
            this.Controls.Add(this.INSERIR);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button INSERIR;
        private System.Windows.Forms.Button PESQUISAR;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.Label label_versao;
    }
}

