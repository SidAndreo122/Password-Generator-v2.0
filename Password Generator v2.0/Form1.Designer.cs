namespace Password_Generator_v2._0
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
            passwordLabel = new Label();
            passwordlengthlabel = new Label();
            label2 = new Label();
            passwordlengthslider = new TrackBar();
            Copy = new Button();
            password = new Label();
            ((System.ComponentModel.ISupportInitialize)passwordlengthslider).BeginInit();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Sans Serif Collection", 15.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(24, -74);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(1041, 413);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password Generator v2\r\n";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            passwordLabel.Click += label1_Click;
            // 
            // passwordlengthlabel
            // 
            passwordlengthlabel.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlengthlabel.Location = new Point(255, 333);
            passwordlengthlabel.Name = "passwordlengthlabel";
            passwordlengthlabel.Size = new Size(514, 77);
            passwordlengthlabel.TabIndex = 1;
            passwordlengthlabel.Text = "Password Length: 5\r\n\r\n\r\n";
            passwordlengthlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Sans Serif Collection", 5.99999952F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 94);
            label2.Name = "label2";
            label2.Size = new Size(400, 102);
            label2.TabIndex = 2;
            label2.Text = "Made by: Sidney Andreano\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordlengthslider
            // 
            passwordlengthslider.Location = new Point(218, 406);
            passwordlengthslider.Name = "passwordlengthslider";
            passwordlengthslider.Size = new Size(587, 114);
            passwordlengthslider.TabIndex = 3;
            passwordlengthslider.Scroll += passwordlengthslider_Scroll;
            // 
            // Copy
            // 
            Copy.Font = new Font("Sans Serif Collection", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Copy.Location = new Point(242, 503);
            Copy.Name = "Copy";
            Copy.Size = new Size(545, 74);
            Copy.TabIndex = 4;
            Copy.Text = "Copy to Clipboard";
            Copy.UseVisualStyleBackColor = true;
            Copy.Click += Copy_Click;
            // 
            // password
            // 
            password.BackColor = SystemColors.ActiveBorder;
            password.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(50, 213);
            password.Name = "password";
            password.Size = new Size(971, 79);
            password.TabIndex = 5;
            password.Text = "label1";
            password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1094, 709);
            Controls.Add(password);
            Controls.Add(Copy);
            Controls.Add(passwordlengthslider);
            Controls.Add(label2);
            Controls.Add(passwordlengthlabel);
            Controls.Add(passwordLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Password Generator v2";
            ((System.ComponentModel.ISupportInitialize)passwordlengthslider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private Label passwordlengthlabel;
        private Label label2;
        private TrackBar passwordlengthslider;
        private Button Copy;
        private Label password;
    }
}
