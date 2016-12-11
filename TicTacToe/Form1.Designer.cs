namespace TicTacToe
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
            this.TicTacToePanel = new System.Windows.Forms.Panel();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.TicTacLabel1 = new System.Windows.Forms.Label();
            this.TicTacLabel2 = new System.Windows.Forms.Label();
            this.TicTacLabel3 = new System.Windows.Forms.Label();
            this.TicTacLabel6 = new System.Windows.Forms.Label();
            this.TicTacLabel5 = new System.Windows.Forms.Label();
            this.TicTacLabel4 = new System.Windows.Forms.Label();
            this.TicTacLabel9 = new System.Windows.Forms.Label();
            this.TicTacLabel8 = new System.Windows.Forms.Label();
            this.TicTacLabel7 = new System.Windows.Forms.Label();
            this.labelYou = new System.Windows.Forms.Label();
            this.labelComputer = new System.Windows.Forms.Label();
            this.TicTacToePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicTacToePanel
            // 
            this.TicTacToePanel.Controls.Add(this.TicTacLabel9);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel8);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel7);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel6);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel5);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel4);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel3);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel2);
            this.TicTacToePanel.Controls.Add(this.TicTacLabel1);
            this.TicTacToePanel.Location = new System.Drawing.Point(92, 86);
            this.TicTacToePanel.Name = "TicTacToePanel";
            this.TicTacToePanel.Size = new System.Drawing.Size(300, 300);
            this.TicTacToePanel.TabIndex = 0;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(156, 12);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(168, 54);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // TicTacLabel1
            // 
            this.TicTacLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel1.Location = new System.Drawing.Point(14, 11);
            this.TicTacLabel1.Name = "TicTacLabel1";
            this.TicTacLabel1.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel1.TabIndex = 0;
            this.TicTacLabel1.Text = "x";
            this.TicTacLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel1.Click += new System.EventHandler(this.TicTacLabel1_Click);
            // 
            // TicTacLabel2
            // 
            this.TicTacLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel2.Location = new System.Drawing.Point(111, 11);
            this.TicTacLabel2.Name = "TicTacLabel2";
            this.TicTacLabel2.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel2.TabIndex = 1;
            this.TicTacLabel2.Text = "x";
            this.TicTacLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel2.Click += new System.EventHandler(this.TicTacLabel2_Click);
            // 
            // TicTacLabel3
            // 
            this.TicTacLabel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel3.Location = new System.Drawing.Point(208, 11);
            this.TicTacLabel3.Name = "TicTacLabel3";
            this.TicTacLabel3.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel3.TabIndex = 2;
            this.TicTacLabel3.Text = "x";
            this.TicTacLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel3.Click += new System.EventHandler(this.TicTacLabel3_Click);
            // 
            // TicTacLabel6
            // 
            this.TicTacLabel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel6.Location = new System.Drawing.Point(207, 110);
            this.TicTacLabel6.Name = "TicTacLabel6";
            this.TicTacLabel6.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel6.TabIndex = 5;
            this.TicTacLabel6.Text = "x";
            this.TicTacLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel6.Click += new System.EventHandler(this.TicTacLabel6_Click);
            // 
            // TicTacLabel5
            // 
            this.TicTacLabel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel5.Location = new System.Drawing.Point(110, 110);
            this.TicTacLabel5.Name = "TicTacLabel5";
            this.TicTacLabel5.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel5.TabIndex = 4;
            this.TicTacLabel5.Text = "x";
            this.TicTacLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel5.Click += new System.EventHandler(this.TicTacLabel5_Click);
            // 
            // TicTacLabel4
            // 
            this.TicTacLabel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel4.Location = new System.Drawing.Point(13, 110);
            this.TicTacLabel4.Name = "TicTacLabel4";
            this.TicTacLabel4.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel4.TabIndex = 3;
            this.TicTacLabel4.Text = "x";
            this.TicTacLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel4.Click += new System.EventHandler(this.TicTacLabel4_Click);
            // 
            // TicTacLabel9
            // 
            this.TicTacLabel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel9.Location = new System.Drawing.Point(207, 206);
            this.TicTacLabel9.Name = "TicTacLabel9";
            this.TicTacLabel9.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel9.TabIndex = 8;
            this.TicTacLabel9.Text = "x";
            this.TicTacLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel9.Click += new System.EventHandler(this.TicTacLabel9_Click);
            // 
            // TicTacLabel8
            // 
            this.TicTacLabel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel8.Location = new System.Drawing.Point(110, 206);
            this.TicTacLabel8.Name = "TicTacLabel8";
            this.TicTacLabel8.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel8.TabIndex = 7;
            this.TicTacLabel8.Text = "x";
            this.TicTacLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel8.Click += new System.EventHandler(this.TicTacLabel8_Click);
            // 
            // TicTacLabel7
            // 
            this.TicTacLabel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TicTacLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacLabel7.Location = new System.Drawing.Point(13, 206);
            this.TicTacLabel7.Name = "TicTacLabel7";
            this.TicTacLabel7.Size = new System.Drawing.Size(80, 80);
            this.TicTacLabel7.TabIndex = 6;
            this.TicTacLabel7.Text = "x";
            this.TicTacLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicTacLabel7.Click += new System.EventHandler(this.TicTacLabel7_Click);
            // 
            // labelYou
            // 
            this.labelYou.AutoSize = true;
            this.labelYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYou.Location = new System.Drawing.Point(34, 28);
            this.labelYou.Name = "labelYou";
            this.labelYou.Size = new System.Drawing.Size(52, 20);
            this.labelYou.TabIndex = 2;
            this.labelYou.Text = "YOU:";
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputer.Location = new System.Drawing.Point(370, 28);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(64, 20);
            this.labelComputer.TabIndex = 3;
            this.labelComputer.Text = "COMP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.labelYou);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.TicTacToePanel);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.TicTacToePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TicTacToePanel;
        private System.Windows.Forms.Label TicTacLabel9;
        private System.Windows.Forms.Label TicTacLabel8;
        private System.Windows.Forms.Label TicTacLabel7;
        private System.Windows.Forms.Label TicTacLabel6;
        private System.Windows.Forms.Label TicTacLabel5;
        private System.Windows.Forms.Label TicTacLabel4;
        private System.Windows.Forms.Label TicTacLabel3;
        private System.Windows.Forms.Label TicTacLabel2;
        private System.Windows.Forms.Label TicTacLabel1;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Label labelYou;
        private System.Windows.Forms.Label labelComputer;
    }
}

