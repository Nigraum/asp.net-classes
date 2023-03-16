namespace Aula08Atv02
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
            label1 = new Label();
            tabuadaTextBox = new TextBox();
            okButton = new Button();
            tabuadaListBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite a tabuada";
            // 
            // tabuadaTextBox
            // 
            tabuadaTextBox.Location = new Point(133, 19);
            tabuadaTextBox.Name = "tabuadaTextBox";
            tabuadaTextBox.Size = new Size(94, 23);
            tabuadaTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Location = new Point(233, 19);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // tabuadaListBox1
            // 
            tabuadaListBox1.FormattingEnabled = true;
            tabuadaListBox1.ItemHeight = 15;
            tabuadaListBox1.Location = new Point(34, 82);
            tabuadaListBox1.Name = "tabuadaListBox1";
            tabuadaListBox1.Size = new Size(360, 199);
            tabuadaListBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 311);
            Controls.Add(tabuadaListBox1);
            Controls.Add(okButton);
            Controls.Add(tabuadaTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tabuadaTextBox;
        private Button okButton;
        private ListBox tabuadaListBox1;
    }
}