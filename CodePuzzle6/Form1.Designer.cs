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
            this.oneTurn = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.TextBox();
            this.doGeneration = new System.Windows.Forms.Button();
            this.breedButton = new System.Windows.Forms.Button();
            this.repeatBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // oneTurn
            // 
            this.oneTurn.Location = new System.Drawing.Point(811, 345);
            this.oneTurn.Name = "oneTurn";
            this.oneTurn.Size = new System.Drawing.Size(177, 37);
            this.oneTurn.TabIndex = 0;
            this.oneTurn.Text = "Do One Turn";
            this.oneTurn.UseVisualStyleBackColor = true;
            this.oneTurn.Click += new System.EventHandler(this.oneTurn_Click);
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(743, 449);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(245, 164);
            this.statusText.TabIndex = 1;
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
            // breedButton
            // 
            this.breedButton.Location = new System.Drawing.Point(811, 388);
            this.breedButton.Name = "breedButton";
            this.breedButton.Size = new System.Drawing.Size(177, 37);
            this.breedButton.TabIndex = 3;
            this.breedButton.Text = "Breed";
            this.breedButton.UseVisualStyleBackColor = true;
            this.breedButton.Click += new System.EventHandler(this.breedButton_Click);
            // 
            // repeatBox
            // 
            this.repeatBox.AutoSize = true;
            this.repeatBox.Location = new System.Drawing.Point(555, 516);
            this.repeatBox.Name = "repeatBox";
            this.repeatBox.Size = new System.Drawing.Size(41, 17);
            this.repeatBox.TabIndex = 4;
            this.repeatBox.Text = "afd";
            this.repeatBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1073, 702);
            this.Controls.Add(this.repeatBox);
            this.Controls.Add(this.breedButton);
            this.Controls.Add(this.doGeneration);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.oneTurn);
            this.Name = "Form1";
            this.Text = "CodePuzzle6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneTurn;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Button doGeneration;
        private System.Windows.Forms.Button breedButton;
        private System.Windows.Forms.CheckBox repeatBox;

    }
}

