
namespace RegexChecker
{
    partial class RegexCheckerForm
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
            this.rtfInput = new System.Windows.Forms.RichTextBox();
            this.rtfOutput = new System.Windows.Forms.RichTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtfInput
            // 
            this.rtfInput.Location = new System.Drawing.Point(12, 12);
            this.rtfInput.Name = "rtfInput";
            this.rtfInput.Size = new System.Drawing.Size(800, 200);
            this.rtfInput.TabIndex = 0;
            this.rtfInput.Text = "";
            this.rtfInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfInput_KeyPress);
            // 
            // rtfOutput
            // 
            this.rtfOutput.Location = new System.Drawing.Point(12, 287);
            this.rtfOutput.Name = "rtfOutput";
            this.rtfOutput.ReadOnly = true;
            this.rtfOutput.Size = new System.Drawing.Size(800, 200);
            this.rtfOutput.TabIndex = 5;
            this.rtfOutput.Text = "";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(13, 219);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(12, 258);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(90, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(108, 219);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(704, 22);
            this.tbFind.TabIndex = 2;
            this.tbFind.TextChanged += new System.EventHandler(this.regex_TextChanged);
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(108, 259);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(704, 22);
            this.tbReplace.TabIndex = 4;
            this.tbReplace.TextChanged += new System.EventHandler(this.regex_TextChanged);
            // 
            // RegexCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 499);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.rtfOutput);
            this.Controls.Add(this.rtfInput);
            this.Name = "RegexCheckerForm";
            this.Text = "Regex checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfInput;
        private System.Windows.Forms.RichTextBox rtfOutput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TextBox tbReplace;
    }
}

