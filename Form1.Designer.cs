namespace TicTacToe_comp
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
            this.boardLayoutPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // boardLayoutPanel
            // 
            this.boardLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.boardLayoutPanel.Name = "boardLayoutPanel";
            this.boardLayoutPanel.Size = new System.Drawing.Size(305, 287);
            this.boardLayoutPanel.TabIndex = 0;
            this.boardLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardLayoutPanel_Paint);
            this.boardLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boardLayoutPanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 288);
            this.Controls.Add(this.boardLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boardLayoutPanel;
    }
}

