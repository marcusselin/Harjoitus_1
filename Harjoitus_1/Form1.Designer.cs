namespace Harjoitus_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VaihdaBT = new Button();
            OtsikkoLB = new Label();
            SuspendLayout();
            // 
            // VaihdaBT
            // 
            VaihdaBT.Location = new Point(304, 257);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(133, 23);
            VaihdaBT.TabIndex = 0;
            VaihdaBT.Text = "Paina minua";
            VaihdaBT.UseVisualStyleBackColor = true;
            VaihdaBT.Click += VaihdaBT_Click;
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(212, 163);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(313, 54);
            OtsikkoLB.TabIndex = 1;
            OtsikkoLB.Text = "Mahtava otsikko";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OtsikkoLB);
            Controls.Add(VaihdaBT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VaihdaBT;
        private Label OtsikkoLB;
    }
}
