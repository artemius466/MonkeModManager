namespace MonkeModManager
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
            this.radioButtonRussian = new System.Windows.Forms.RadioButton();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonRussian
            // 
            this.radioButtonRussian.AutoSize = true;
            this.radioButtonRussian.Location = new System.Drawing.Point(99, 12);
            this.radioButtonRussian.Name = "radioButtonRussian";
            this.radioButtonRussian.Size = new System.Drawing.Size(94, 17);
            this.radioButtonRussian.TabIndex = 1;
            this.radioButtonRussian.TabStop = true;
            this.radioButtonRussian.Text = "Русский язык";
            this.radioButtonRussian.UseVisualStyleBackColor = true;
            this.radioButtonRussian.CheckedChanged += new System.EventHandler(this.radioButtonRussian_CheckedChanged);
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(90, 35);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(115, 17);
            this.radioButtonEnglish.TabIndex = 2;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "English language";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Location = new System.Drawing.Point(109, 58);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(292, 95);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.radioButtonEnglish);
            this.Controls.Add(this.radioButtonRussian);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRussian;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.Button buttonConfirm;
    }
}