namespace CatchMeGame
{
    partial class EndPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndPage));
            endLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.BackColor = Color.Transparent;
            endLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            endLabel.Location = new Point(118, 139);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(0, 38);
            endLabel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(44, 353);
            button1.Name = "button1";
            button1.Size = new Size(105, 52);
            button1.TabIndex = 1;
            button1.Text = "Retry";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("SimSun", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(220, 353);
            button2.Name = "button2";
            button2.Size = new Size(105, 52);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("SimSun", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            scoreLabel.Location = new Point(149, 252);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(0, 17);
            scoreLabel.TabIndex = 3;
            // 
            // EndPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(371, 528);
            Controls.Add(scoreLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(endLabel);
            Name = "EndPage";
            Text = "EndPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label endLabel;
        private Button button1;
        private Button button2;
        private Label scoreLabel;
    }
}