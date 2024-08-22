namespace TrocaValores
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
            btnClick = new Button();
            TxtValor1 = new TextBox();
            TxtValor2 = new TextBox();
            lblValor1 = new Label();
            LblValor2 = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.Transparent;
            btnClick.BackgroundImageLayout = ImageLayout.None;
            btnClick.FlatAppearance.BorderSize = 0;
            btnClick.FlatStyle = FlatStyle.Flat;
            btnClick.ForeColor = Color.Transparent;
            btnClick.Image = Properties.Resources.trocar2;
            btnClick.Location = new Point(146, 90);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(75, 52);
            btnClick.TabIndex = 0;
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += btnClick_Click;
            btnClick.MouseDown += btnClick_MouseDown;
            btnClick.MouseHover += button1_Click;
            // 
            // TxtValor1
            // 
            TxtValor1.Location = new Point(66, 43);
            TxtValor1.Name = "TxtValor1";
            TxtValor1.Size = new Size(100, 23);
            TxtValor1.TabIndex = 1;
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(240, 43);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(100, 23);
            TxtValor2.TabIndex = 2;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.BackColor = Color.Transparent;
            lblValor1.Location = new Point(19, 47);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(45, 15);
            lblValor1.TabIndex = 3;
            lblValor1.Text = "Valor 1:";
            lblValor1.Click += label1_Click;
            // 
            // LblValor2
            // 
            LblValor2.AutoSize = true;
            LblValor2.BackColor = Color.Transparent;
            LblValor2.Location = new Point(193, 48);
            LblValor2.Name = "LblValor2";
            LblValor2.Size = new Size(45, 15);
            LblValor2.TabIndex = 4;
            LblValor2.Text = "Valor 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(365, 169);
            Controls.Add(LblValor2);
            Controls.Add(lblValor1);
            Controls.Add(TxtValor2);
            Controls.Add(TxtValor1);
            Controls.Add(btnClick);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private TextBox TxtValor1;
        private TextBox TxtValor2;
        private Label lblValor1;
        private Label LblValor2;
    }
}
