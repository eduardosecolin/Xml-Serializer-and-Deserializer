namespace TesteXMLWinForm {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgXml = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgXml)).BeginInit();
            this.SuspendLayout();
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnS.Location = new System.Drawing.Point(12, 12);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(129, 42);
            this.btnS.TabIndex = 0;
            this.btnS.Text = "Serializer";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnD.Location = new System.Drawing.Point(140, 12);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(129, 42);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "Deserializer";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(305, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 42);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgXml
            // 
            this.dgXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXml.Location = new System.Drawing.Point(12, 76);
            this.dgXml.Name = "dgXml";
            this.dgXml.Size = new System.Drawing.Size(422, 281);
            this.dgXml.TabIndex = 4;
            this.dgXml.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(446, 66);
            this.Controls.Add(this.dgXml);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML";
            ((System.ComponentModel.ISupportInitialize)(this.dgXml)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgXml;
    }
}

