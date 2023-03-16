namespace Aula08Atv01
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
            Numero1TextBox = new TextBox();
            label2 = new Label();
            Numero2TextBox = new TextBox();
            SomarButton = new Button();
            SubtrairButton = new Button();
            MultiplicarButton = new Button();
            DividirButton = new Button();
            label3 = new Label();
            RespostaLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // Numero1TextBox
            // 
            Numero1TextBox.Location = new Point(78, 6);
            Numero1TextBox.Name = "Numero1TextBox";
            Numero1TextBox.Size = new Size(167, 23);
            Numero1TextBox.TabIndex = 1;
            Numero1TextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // Numero2TextBox
            // 
            Numero2TextBox.Location = new Point(78, 43);
            Numero2TextBox.Name = "Numero2TextBox";
            Numero2TextBox.Size = new Size(167, 23);
            Numero2TextBox.TabIndex = 3;
            // 
            // SomarButton
            // 
            SomarButton.Location = new Point(70, 101);
            SomarButton.Name = "SomarButton";
            SomarButton.Size = new Size(75, 23);
            SomarButton.TabIndex = 4;
            SomarButton.Text = "Somar";
            SomarButton.UseVisualStyleBackColor = true;
            SomarButton.Click += SomarButton_Click;
            // 
            // SubtrairButton
            // 
            SubtrairButton.Location = new Point(151, 101);
            SubtrairButton.Name = "SubtrairButton";
            SubtrairButton.Size = new Size(75, 23);
            SubtrairButton.TabIndex = 5;
            SubtrairButton.Text = "Subtrair";
            SubtrairButton.UseVisualStyleBackColor = true;
            SubtrairButton.Click += SubtrairButton_Click;
            // 
            // MultiplicarButton
            // 
            MultiplicarButton.Location = new Point(232, 101);
            MultiplicarButton.Name = "MultiplicarButton";
            MultiplicarButton.Size = new Size(75, 23);
            MultiplicarButton.TabIndex = 6;
            MultiplicarButton.Text = "Multiplicar";
            MultiplicarButton.UseVisualStyleBackColor = true;
            MultiplicarButton.Click += MultiplicarButton_Click;
            // 
            // DividirButton
            // 
            DividirButton.Location = new Point(313, 101);
            DividirButton.Name = "DividirButton";
            DividirButton.Size = new Size(75, 23);
            DividirButton.TabIndex = 7;
            DividirButton.Text = "Dividir";
            DividirButton.UseVisualStyleBackColor = true;
            DividirButton.Click += DividirButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Resposta";
            // 
            // RespostaLabel
            // 
            RespostaLabel.AutoSize = true;
            RespostaLabel.Location = new Point(94, 155);
            RespostaLabel.Name = "RespostaLabel";
            RespostaLabel.Size = new Size(13, 15);
            RespostaLabel.TabIndex = 9;
            RespostaLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 260);
            Controls.Add(RespostaLabel);
            Controls.Add(label3);
            Controls.Add(DividirButton);
            Controls.Add(MultiplicarButton);
            Controls.Add(SubtrairButton);
            Controls.Add(SomarButton);
            Controls.Add(Numero2TextBox);
            Controls.Add(label2);
            Controls.Add(Numero1TextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Numero1TextBox;
        private Label label2;
        private TextBox Numero2TextBox;
        private Button SomarButton;
        private Button SubtrairButton;
        private Button MultiplicarButton;
        private Button DividirButton;
        private Label label3;
        private Label RespostaLabel;
    }
}