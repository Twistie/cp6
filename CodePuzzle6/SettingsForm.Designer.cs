namespace CodePuzzle6
{
    partial class SettingsForm
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
            this.loopInner = new System.Windows.Forms.NumericUpDown();
            this.loopOuter = new System.Windows.Forms.NumericUpDown();
            this.keepTop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mutChance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.additionallyTop = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loopInner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopOuter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionallyTop)).BeginInit();
            this.SuspendLayout();
            // 
            // loopInner
            // 
            this.loopInner.Location = new System.Drawing.Point(12, 62);
            this.loopInner.Name = "loopInner";
            this.loopInner.Size = new System.Drawing.Size(120, 20);
            this.loopInner.TabIndex = 0;
            this.loopInner.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // loopOuter
            // 
            this.loopOuter.Location = new System.Drawing.Point(12, 108);
            this.loopOuter.Name = "loopOuter";
            this.loopOuter.Size = new System.Drawing.Size(120, 20);
            this.loopOuter.TabIndex = 1;
            this.loopOuter.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // keepTop
            // 
            this.keepTop.AutoSize = true;
            this.keepTop.Checked = true;
            this.keepTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepTop.Location = new System.Drawing.Point(12, 152);
            this.keepTop.Name = "keepTop";
            this.keepTop.Size = new System.Drawing.Size(116, 17);
            this.keepTop.TabIndex = 2;
            this.keepTop.Text = "Keep top performer";
            this.keepTop.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Breed first x actors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "With top x actors";
            // 
            // mutChance
            // 
            this.mutChance.DecimalPlaces = 3;
            this.mutChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mutChance.Location = new System.Drawing.Point(252, 62);
            this.mutChance.Name = "mutChance";
            this.mutChance.Size = new System.Drawing.Size(120, 20);
            this.mutChance.TabIndex = 5;
            this.mutChance.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mutation Chance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Finished";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // additionallyTop
            // 
            this.additionallyTop.Location = new System.Drawing.Point(15, 199);
            this.additionallyTop.Name = "additionallyTop";
            this.additionallyTop.Size = new System.Drawing.Size(74, 20);
            this.additionallyTop.TabIndex = 8;
            this.additionallyTop.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Additionally breed top with";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.additionallyTop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mutChance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keepTop);
            this.Controls.Add(this.loopOuter);
            this.Controls.Add(this.loopInner);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.loopInner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopOuter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionallyTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown loopInner;
        public System.Windows.Forms.NumericUpDown loopOuter;
        public System.Windows.Forms.CheckBox keepTop;
        public System.Windows.Forms.NumericUpDown mutChance;
        public System.Windows.Forms.NumericUpDown additionallyTop;
        private System.Windows.Forms.Label label4;
    }
}