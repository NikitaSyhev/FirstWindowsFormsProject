namespace FirstWindowsFormsProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.labelOutput1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextBoxViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput1.Location = new System.Drawing.Point(297, 77);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(174, 53);
            this.textBoxInput1.TabIndex = 0;
            // 
            // labelOutput1
            // 
            this.labelOutput1.AutoSize = true;
            this.labelOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelOutput1.Location = new System.Drawing.Point(528, 80);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(126, 46);
            this.labelOutput1.TabIndex = 1;
            this.labelOutput1.Text = "label1";
            this.labelOutput1.DoubleClick += new System.EventHandler(this.textBoxInput1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TextBoxViewer
            // 
            this.TextBoxViewer.Location = new System.Drawing.Point(0, 12);
            this.TextBoxViewer.Name = "TextBoxViewer";
            this.TextBoxViewer.Size = new System.Drawing.Size(291, 390);
            this.TextBoxViewer.TabIndex = 3;
            this.TextBoxViewer.Text = "";
            this.TextBoxViewer.TextChanged += new System.EventHandler(this.TextBoxViewer_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(730, 414);
            this.Controls.Add(this.TextBoxViewer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOutput1);
            this.Controls.Add(this.textBoxInput1);
            this.Name = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Label labelOutput1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox TextBoxViewer;
    }
}

