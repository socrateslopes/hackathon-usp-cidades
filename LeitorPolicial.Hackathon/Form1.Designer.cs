namespace LeitorPolicial.Hackathon
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txbPasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArquivosEncontrados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(324, 49);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txbPasta
            // 
            this.txbPasta.Enabled = false;
            this.txbPasta.Location = new System.Drawing.Point(12, 51);
            this.txbPasta.Name = "txbPasta";
            this.txbPasta.Size = new System.Drawing.Size(306, 20);
            this.txbPasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione a pasta:";
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(12, 110);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnGerarArquivo.TabIndex = 3;
            this.btnGerarArquivo.Text = "Vai!";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gerar arquivo:";
            // 
            // lblArquivosEncontrados
            // 
            this.lblArquivosEncontrados.AutoSize = true;
            this.lblArquivosEncontrados.Location = new System.Drawing.Point(9, 74);
            this.lblArquivosEncontrados.Name = "lblArquivosEncontrados";
            this.lblArquivosEncontrados.Size = new System.Drawing.Size(0, 13);
            this.lblArquivosEncontrados.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 158);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.lblArquivosEncontrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPasta);
            this.Controls.Add(this.btnSelecionar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Leitor dos arquivos da Hackathon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txbPasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArquivosEncontrados;
    }
}

