namespace Lojinha.Formularios
{
    partial class BuscaClientesForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.LimparButton = new System.Windows.Forms.Button();
            this.IncluirButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.FiltrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(86, 66);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(86, 104);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(161, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(86, 141);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(161, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(15, 221);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(75, 23);
            this.LimparButton.TabIndex = 8;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            // 
            // IncluirButton
            // 
            this.IncluirButton.Location = new System.Drawing.Point(96, 221);
            this.IncluirButton.Name = "IncluirButton";
            this.IncluirButton.Size = new System.Drawing.Size(75, 23);
            this.IncluirButton.TabIndex = 9;
            this.IncluirButton.Text = "Incluir";
            this.IncluirButton.UseVisualStyleBackColor = true;
            this.IncluirButton.Click += new System.EventHandler(this.IncluirButton_Click);
            // 
            // AlterarButton
            // 
            this.AlterarButton.Location = new System.Drawing.Point(177, 221);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(75, 23);
            this.AlterarButton.TabIndex = 10;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(258, 221);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 11;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(15, 250);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.Size = new System.Drawing.Size(318, 227);
            this.ClientesdataGridView.TabIndex = 12;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(86, 178);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(161, 20);
            this.telefoneTextBox.TabIndex = 13;
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(15, 493);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(232, 20);
            this.filtroTextBox.TabIndex = 14;
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(258, 493);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 15;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // BuscaClientesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.ClientesdataGridView);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.AlterarButton);
            this.Controls.Add(this.IncluirButton);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscaClientesForms";
            this.Text = "BuscaClientesForms";
            this.Load += new System.EventHandler(this.BuscaClientesForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.Button IncluirButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button FiltrarButton;
    }
}