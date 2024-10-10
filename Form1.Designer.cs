
namespace EX3
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
            this.Adunare = new System.Windows.Forms.Button();
            this.Scadere = new System.Windows.Forms.Button();
            this.Inmultire = new System.Windows.Forms.Button();
            this.Impartire = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.nr1 = new System.Windows.Forms.TextBox();
            this.nr2 = new System.Windows.Forms.TextBox();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adunare
            // 
            this.Adunare.Location = new System.Drawing.Point(198, 70);
            this.Adunare.Name = "Adunare";
            this.Adunare.Size = new System.Drawing.Size(75, 22);
            this.Adunare.TabIndex = 0;
            this.Adunare.Text = "+";
            this.Adunare.UseVisualStyleBackColor = true;
            this.Adunare.Click += new System.EventHandler(this.Adunare_Click);
            // 
            // Scadere
            // 
            this.Scadere.Location = new System.Drawing.Point(198, 125);
            this.Scadere.Name = "Scadere";
            this.Scadere.Size = new System.Drawing.Size(75, 21);
            this.Scadere.TabIndex = 1;
            this.Scadere.Text = "-";
            this.Scadere.UseVisualStyleBackColor = true;
            this.Scadere.Click += new System.EventHandler(this.Scadere_Click);
            // 
            // Inmultire
            // 
            this.Inmultire.Location = new System.Drawing.Point(198, 175);
            this.Inmultire.Name = "Inmultire";
            this.Inmultire.Size = new System.Drawing.Size(75, 23);
            this.Inmultire.TabIndex = 2;
            this.Inmultire.Text = "*";
            this.Inmultire.UseVisualStyleBackColor = true;
            this.Inmultire.Click += new System.EventHandler(this.Inmultire_Click);
            // 
            // Impartire
            // 
            this.Impartire.Location = new System.Drawing.Point(198, 229);
            this.Impartire.Name = "Impartire";
            this.Impartire.Size = new System.Drawing.Size(75, 21);
            this.Impartire.TabIndex = 3;
            this.Impartire.Text = "/";
            this.Impartire.UseVisualStyleBackColor = true;
            this.Impartire.Click += new System.EventHandler(this.Impartire_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(198, 295);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(77, 33);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // nr1
            // 
            this.nr1.Location = new System.Drawing.Point(109, 70);
            this.nr1.Name = "nr1";
            this.nr1.Size = new System.Drawing.Size(58, 22);
            this.nr1.TabIndex = 5;
            // 
            // nr2
            // 
            this.nr2.Location = new System.Drawing.Point(111, 138);
            this.nr2.Name = "nr2";
            this.nr2.Size = new System.Drawing.Size(56, 22);
            this.nr2.TabIndex = 6;
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(46, 267);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(93, 22);
            this.Rezultat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numarul 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numarul 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rezultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Impartire);
            this.Controls.Add(this.Inmultire);
            this.Controls.Add(this.Scadere);
            this.Controls.Add(this.Adunare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adunare;
        private System.Windows.Forms.Button Scadere;
        private System.Windows.Forms.Button Inmultire;
        private System.Windows.Forms.Button Impartire;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox nr1;
        private System.Windows.Forms.TextBox nr2;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

