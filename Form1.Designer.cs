
namespace WindowsFormsApp18
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIntervalo = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxHabilitaEnviarDoClipboard = new System.Windows.Forms.CheckBox();
            this.checkBoxDelayEntreTeclas = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDelayEntreTeclas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(524, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 37);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(588, 234);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tempo de espera antes do Envio:";
            // 
            // textBoxIntervalo
            // 
            this.textBoxIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIntervalo.Location = new System.Drawing.Point(183, 309);
            this.textBoxIntervalo.Name = "textBoxIntervalo";
            this.textBoxIntervalo.Size = new System.Drawing.Size(36, 20);
            this.textBoxIntervalo.TabIndex = 40;
            this.textBoxIntervalo.Text = "350";
            this.textBoxIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(12, 332);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(441, 20);
            this.labelInfo.TabIndex = 45;
            this.labelInfo.Text = "Selecione a janela para enviar a sequencia de teclado";
            this.labelInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(12, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(585, 27);
            this.label3.TabIndex = 46;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "By: Hertz Oliveira";
            // 
            // checkBoxHabilitaEnviarDoClipboard
            // 
            this.checkBoxHabilitaEnviarDoClipboard.AutoSize = true;
            this.checkBoxHabilitaEnviarDoClipboard.Checked = true;
            this.checkBoxHabilitaEnviarDoClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHabilitaEnviarDoClipboard.Location = new System.Drawing.Point(16, 275);
            this.checkBoxHabilitaEnviarDoClipboard.Name = "checkBoxHabilitaEnviarDoClipboard";
            this.checkBoxHabilitaEnviarDoClipboard.Size = new System.Drawing.Size(452, 17);
            this.checkBoxHabilitaEnviarDoClipboard.TabIndex = 48;
            this.checkBoxHabilitaEnviarDoClipboard.Text = "Habilita Ctrl+Alt+F12 para enviar textos direto do Clipboard para o destino (risc" +
    "o de conflito)";
            this.checkBoxHabilitaEnviarDoClipboard.UseVisualStyleBackColor = true;
            this.checkBoxHabilitaEnviarDoClipboard.CheckedChanged += new System.EventHandler(this.checkBoxHabilitaEnviarDoClipboard_CheckedChanged);
            // 
            // checkBoxDelayEntreTeclas
            // 
            this.checkBoxDelayEntreTeclas.AutoSize = true;
            this.checkBoxDelayEntreTeclas.Checked = true;
            this.checkBoxDelayEntreTeclas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelayEntreTeclas.Location = new System.Drawing.Point(16, 292);
            this.checkBoxDelayEntreTeclas.Name = "checkBoxDelayEntreTeclas";
            this.checkBoxDelayEntreTeclas.Size = new System.Drawing.Size(446, 17);
            this.checkBoxDelayEntreTeclas.TabIndex = 49;
            this.checkBoxDelayEntreTeclas.Text = "Delay entre envio de teclas (Menor: melhor desempenho, Maior: melhor compatibilid" +
    "ade): ";
            this.checkBoxDelayEntreTeclas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "ms";
            // 
            // textBoxDelayEntreTeclas
            // 
            this.textBoxDelayEntreTeclas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDelayEntreTeclas.Location = new System.Drawing.Point(454, 290);
            this.textBoxDelayEntreTeclas.Name = "textBoxDelayEntreTeclas";
            this.textBoxDelayEntreTeclas.Size = new System.Drawing.Size(36, 20);
            this.textBoxDelayEntreTeclas.TabIndex = 50;
            this.textBoxDelayEntreTeclas.Text = "8";
            this.textBoxDelayEntreTeclas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDelayEntreTeclas);
            this.Controls.Add(this.checkBoxDelayEntreTeclas);
            this.Controls.Add(this.checkBoxHabilitaEnviarDoClipboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIntervalo);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(628, 390);
            this.Name = "Form1";
            this.Text = "Virtual Keyboard para Macros";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIntervalo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxHabilitaEnviarDoClipboard;
        private System.Windows.Forms.CheckBox checkBoxDelayEntreTeclas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDelayEntreTeclas;
    }
}

