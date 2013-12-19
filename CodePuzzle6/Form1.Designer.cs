namespace CodePuzzle6
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
            this.doGeneration = new System.Windows.Forms.Button();
            this.repeatBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doGeneration
            // 
            this.doGeneration.Location = new System.Drawing.Point(541, 449);
            this.doGeneration.Name = "doGeneration";
            this.doGeneration.Size = new System.Drawing.Size(177, 37);
            this.doGeneration.TabIndex = 2;
            this.doGeneration.Text = "Finish Generation";
            this.doGeneration.UseVisualStyleBackColor = true;
            this.doGeneration.Click += new System.EventHandler(this.doGeneration_Click);
            // 
            // repeatBox
            // 
            this.repeatBox.AutoSize = true;
            this.repeatBox.Location = new System.Drawing.Point(572, 502);
            this.repeatBox.Name = "repeatBox";
            this.repeatBox.Size = new System.Drawing.Size(89, 17);
            this.repeatBox.TabIndex = 4;
            this.repeatBox.Text = "Keep running";
            this.repeatBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repeatBox);
            this.Controls.Add(this.doGeneration);
            this.Name = "Form1";
            this.Text = "CodePuzzle6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doGeneration;
        private System.Windows.Forms.CheckBox repeatBox;
        private System.Windows.Forms.Button button1;

    }
}

