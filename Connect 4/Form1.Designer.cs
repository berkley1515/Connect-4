namespace Connect_4
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
            this.lastTurn = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.buttonsLabel = new System.Windows.Forms.Label();
            this.restartRoundButton = new System.Windows.Forms.Button();
            this.restartGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastTurn
            // 
            this.lastTurn.AutoSize = true;
            this.lastTurn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTurn.Location = new System.Drawing.Point(12, 639);
            this.lastTurn.Name = "lastTurn";
            this.lastTurn.Size = new System.Drawing.Size(99, 19);
            this.lastTurn.TabIndex = 0;
            this.lastTurn.Text = "Last Turn:";
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.SkyBlue;
            this.info1.Location = new System.Drawing.Point(778, 24);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(194, 600);
            this.info1.TabIndex = 1;
            // 
            // buttonsLabel
            // 
            this.buttonsLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonsLabel.Location = new System.Drawing.Point(792, 522);
            this.buttonsLabel.Name = "buttonsLabel";
            this.buttonsLabel.Size = new System.Drawing.Size(167, 85);
            this.buttonsLabel.TabIndex = 2;
            // 
            // restartRoundButton
            // 
            this.restartRoundButton.BackColor = System.Drawing.Color.White;
            this.restartRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartRoundButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartRoundButton.ForeColor = System.Drawing.Color.Black;
            this.restartRoundButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.restartRoundButton.Location = new System.Drawing.Point(811, 536);
            this.restartRoundButton.Name = "restartRoundButton";
            this.restartRoundButton.Size = new System.Drawing.Size(132, 25);
            this.restartRoundButton.TabIndex = 1;
            this.restartRoundButton.Text = "Reset Round";
            this.restartRoundButton.UseVisualStyleBackColor = false;
            // 
            // restartGameButton
            // 
            this.restartGameButton.BackColor = System.Drawing.Color.White;
            this.restartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartGameButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGameButton.ForeColor = System.Drawing.Color.Black;
            this.restartGameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.restartGameButton.Location = new System.Drawing.Point(811, 567);
            this.restartGameButton.Name = "restartGameButton";
            this.restartGameButton.Size = new System.Drawing.Size(132, 25);
            this.restartGameButton.TabIndex = 2;
            this.restartGameButton.Text = "Restart Game";
            this.restartGameButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.restartGameButton);
            this.Controls.Add(this.restartRoundButton);
            this.Controls.Add(this.buttonsLabel);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.lastTurn);
            this.Name = "Form1";
            this.Text = "Connect 4";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastTurn;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label buttonsLabel;
        private System.Windows.Forms.Button restartRoundButton;
        private System.Windows.Forms.Button restartGameButton;
    }
}

