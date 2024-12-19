namespace _1111
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
            LABEL1 = new Label();
            TEXTBOX1 = new TextBox();
            buttonOK = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // LABEL1
            // 
            LABEL1.AccessibleName = "LABEL1";
            LABEL1.AccessibleRole = AccessibleRole.None;
            LABEL1.AutoSize = true;
            LABEL1.Location = new Point(63, 79);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(38, 15);
            LABEL1.TabIndex = 0;
            LABEL1.Text = "label1";
            // 
            // TEXTBOX1
            // 
            TEXTBOX1.AccessibleName = "TEXTBOX1";
            TEXTBOX1.Location = new Point(63, 42);
            TEXTBOX1.Name = "TEXTBOX1";
            TEXTBOX1.Size = new Size(276, 23);
            TEXTBOX1.TabIndex = 1;
            TEXTBOX1.TextChanged += textBox1_TextChanged;
            // 
            // buttonOK
            // 
            buttonOK.AccessibleName = "buttonOK";
            buttonOK.Location = new Point(252, 134);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.AccessibleName = "btnCerrar";
            btnCerrar.Location = new Point(333, 134);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 181);
            Controls.Add(btnCerrar);
            Controls.Add(buttonOK);
            Controls.Add(TEXTBOX1);
            Controls.Add(LABEL1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABEL1;
        private TextBox TEXTBOX1;
        private Button buttonOK;
        private Button btnCerrar;
    }
}
