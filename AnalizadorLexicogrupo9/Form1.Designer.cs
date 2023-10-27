namespace AnalizadorLexicogrupo9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.RichTextBox();
            this.txt2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(89, 155);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(598, 128);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(89, 346);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(598, 128);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "ABRIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "C++",
            "Java"});
            this.cb.Location = new System.Drawing.Point(317, 80);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 21);
            this.cb.TabIndex = 4;
            this.cb.Text = "Elija lenguaje";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "ANALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "GUARDAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(672, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "CANCELAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Analizador Lexico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt1;
        private System.Windows.Forms.RichTextBox txt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

