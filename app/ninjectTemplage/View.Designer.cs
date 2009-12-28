namespace ninjectTemplage
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDidOne = new System.Windows.Forms.Label();
            this.lblDidTwo = new System.Windows.Forms.Label();
            this.lblDidThree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(104, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDidOne
            // 
            this.lblDidOne.AutoSize = true;
            this.lblDidOne.Location = new System.Drawing.Point(35, 112);
            this.lblDidOne.Name = "lblDidOne";
            this.lblDidOne.Size = new System.Drawing.Size(53, 13);
            this.lblDidOne.TabIndex = 2;
            this.lblDidOne.Text = "lblDidOne";
            // 
            // lblDidTwo
            // 
            this.lblDidTwo.AutoSize = true;
            this.lblDidTwo.Location = new System.Drawing.Point(35, 138);
            this.lblDidTwo.Name = "lblDidTwo";
            this.lblDidTwo.Size = new System.Drawing.Size(54, 13);
            this.lblDidTwo.TabIndex = 3;
            this.lblDidTwo.Text = "lblDidTwo";
            // 
            // lblDidThree
            // 
            this.lblDidThree.AutoSize = true;
            this.lblDidThree.Location = new System.Drawing.Point(35, 164);
            this.lblDidThree.Name = "lblDidThree";
            this.lblDidThree.Size = new System.Drawing.Size(61, 13);
            this.lblDidThree.TabIndex = 4;
            this.lblDidThree.Text = "lblDidThree";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblDidThree);
            this.Controls.Add(this.lblDidTwo);
            this.Controls.Add(this.lblDidOne);
            this.Controls.Add(this.btnStart);
            this.Name = "View";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDidOne;
        private System.Windows.Forms.Label lblDidTwo;
        private System.Windows.Forms.Label lblDidThree;
    }
}

