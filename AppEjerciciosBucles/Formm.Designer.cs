namespace AppEjerciciosBucles
{
    partial class Formm
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
            this.listnum = new System.Windows.Forms.ListBox();
            this.btnordenar = new System.Windows.Forms.Button();
            this.btnllenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listnum
            // 
            this.listnum.FormattingEnabled = true;
            this.listnum.Location = new System.Drawing.Point(12, 71);
            this.listnum.Name = "listnum";
            this.listnum.Size = new System.Drawing.Size(175, 147);
            this.listnum.TabIndex = 5;
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(193, 20);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(175, 45);
            this.btnordenar.TabIndex = 4;
            this.btnordenar.Text = "Ordenar lista";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // btnllenar
            // 
            this.btnllenar.Location = new System.Drawing.Point(12, 20);
            this.btnllenar.Name = "btnllenar";
            this.btnllenar.Size = new System.Drawing.Size(175, 45);
            this.btnllenar.TabIndex = 3;
            this.btnllenar.Text = "Llenar la lista de numeros";
            this.btnllenar.UseVisualStyleBackColor = true;
            this.btnllenar.Click += new System.EventHandler(this.btnllenar_Click_1);
            // 
            // Formm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 226);
            this.Controls.Add(this.listnum);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.btnllenar);
            this.Name = "Formm";
            this.Text = "Formm";
            this.Load += new System.EventHandler(this.Formm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listnum;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Button btnllenar;
    }
}