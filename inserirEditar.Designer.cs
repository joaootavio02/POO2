namespace agenda
{
    partial class inserirEditar
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
            this.fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.lista_contatos2 = new System.Windows.Forms.Label();
            this.numero_registros = new System.Windows.Forms.Label();
            this.Apagar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(353, 339);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 3;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(91, 40);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(319, 20);
            this.text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(91, 76);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(135, 20);
            this.text_numero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gravar
            // 
            this.gravar.Location = new System.Drawing.Point(91, 102);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(135, 35);
            this.gravar.TabIndex = 2;
            this.gravar.Text = "Gravar";
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.Location = new System.Drawing.Point(15, 173);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(413, 160);
            this.lista_contatos.TabIndex = 9;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lista_contatos2
            // 
            this.lista_contatos2.Location = new System.Drawing.Point(12, 147);
            this.lista_contatos2.Name = "lista_contatos2";
            this.lista_contatos2.Size = new System.Drawing.Size(159, 23);
            this.lista_contatos2.TabIndex = 8;
            this.lista_contatos2.Text = "Lista de contatos registrados:";
            this.lista_contatos2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numero_registros
            // 
            this.numero_registros.Location = new System.Drawing.Point(12, 336);
            this.numero_registros.Name = "numero_registros";
            this.numero_registros.Size = new System.Drawing.Size(159, 23);
            this.numero_registros.TabIndex = 10;
            this.numero_registros.Text = "Registros: 0";
            this.numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(263, 339);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(75, 23);
            this.Apagar.TabIndex = 4;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(177, 339);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 5;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // inserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 374);
            this.ControlBox = false;
            this.Controls.Add(this.editar);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.numero_registros);
            this.Controls.Add(this.lista_contatos2);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA -INSERIR/EDITAR";
            this.Load += new System.EventHandler(this.inserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label lista_contatos2;
        private System.Windows.Forms.Label numero_registros;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button editar;
    }
}