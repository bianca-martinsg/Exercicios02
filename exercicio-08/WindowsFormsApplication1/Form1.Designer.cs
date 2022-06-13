namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado25 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblResultado50 = new System.Windows.Forms.Label();
            this.lblResultado150 = new System.Windows.Forms.Label();
            this.lblResultado100 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor numérico";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(31, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 29);
            this.txtValor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // lblResultado25
            // 
            this.lblResultado25.AutoSize = true;
            this.lblResultado25.ForeColor = System.Drawing.Color.Red;
            this.lblResultado25.Location = new System.Drawing.Point(28, 136);
            this.lblResultado25.Name = "lblResultado25";
            this.lblResultado25.Size = new System.Drawing.Size(21, 24);
            this.lblResultado25.TabIndex = 3;
            this.lblResultado25.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResultado50
            // 
            this.lblResultado50.AutoSize = true;
            this.lblResultado50.ForeColor = System.Drawing.Color.Red;
            this.lblResultado50.Location = new System.Drawing.Point(28, 163);
            this.lblResultado50.Name = "lblResultado50";
            this.lblResultado50.Size = new System.Drawing.Size(21, 24);
            this.lblResultado50.TabIndex = 5;
            this.lblResultado50.Text = "0";
            // 
            // lblResultado150
            // 
            this.lblResultado150.AutoSize = true;
            this.lblResultado150.ForeColor = System.Drawing.Color.Red;
            this.lblResultado150.Location = new System.Drawing.Point(29, 218);
            this.lblResultado150.Name = "lblResultado150";
            this.lblResultado150.Size = new System.Drawing.Size(21, 24);
            this.lblResultado150.TabIndex = 7;
            this.lblResultado150.Text = "0";
            // 
            // lblResultado100
            // 
            this.lblResultado100.AutoSize = true;
            this.lblResultado100.ForeColor = System.Drawing.Color.Red;
            this.lblResultado100.Location = new System.Drawing.Point(29, 191);
            this.lblResultado100.Name = "lblResultado100";
            this.lblResultado100.Size = new System.Drawing.Size(21, 24);
            this.lblResultado100.TabIndex = 6;
            this.lblResultado100.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 309);
            this.Controls.Add(this.lblResultado150);
            this.Controls.Add(this.lblResultado100);
            this.Controls.Add(this.lblResultado50);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultado25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado25;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblResultado50;
        private System.Windows.Forms.Label lblResultado150;
        private System.Windows.Forms.Label lblResultado100;
    }
}

