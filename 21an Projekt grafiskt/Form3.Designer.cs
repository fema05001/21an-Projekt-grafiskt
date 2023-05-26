namespace _21an_Projekt_grafiskt
{
    partial class Form3
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
            this.button10 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Välj ett inställning du vill ändra";
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button10.Location = new System.Drawing.Point(124, 143);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 55);
            this.button10.TabIndex = 6;
            this.button10.Text = "Svårighetsgrad";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button20
            // 
            this.button20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button20.Location = new System.Drawing.Point(240, 143);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(95, 55);
            this.button20.TabIndex = 7;
            this.button20.Text = "Vem vinner om det är lika?";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button30
            // 
            this.button30.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button30.Location = new System.Drawing.Point(124, 222);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(95, 55);
            this.button30.TabIndex = 8;
            this.button30.Text = "Max/Min värde av kort";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button40
            // 
            this.button40.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button40.Location = new System.Drawing.Point(240, 222);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(95, 55);
            this.button40.TabIndex = 9;
            this.button40.Text = "Tillbaka";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 338);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form3";
            this.Text = "Inställningar";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button10;
        private Button button20;
        private Button button30;
        private Button button40;
    }
}