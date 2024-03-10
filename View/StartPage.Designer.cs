namespace CatchMeGame
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            label1 = new Label();
            button1 = new Button();
            explBtn = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(222, 182);
            label1.Name = "label1";
            label1.Size = new Size(226, 62);
            label1.TabIndex = 0;
            label1.Text = "Catch Me";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Coral;
            button1.Font = new Font("SimSun", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(265, 374);
            button1.Name = "button1";
            button1.Size = new Size(143, 55);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // explBtn
            // 
            explBtn.AutoSize = true;
            explBtn.BackColor = Color.Transparent;
            explBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            explBtn.Location = new Point(91, 292);
            explBtn.Name = "explBtn";
            explBtn.Size = new Size(494, 31);
            explBtn.TabIndex = 2;
            explBtn.Text = "Catch the monster 5 times within 60 sec to win";
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(660, 654);
            Controls.Add(explBtn);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "StartPage";
            Text = "StartPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label explBtn;
    }
}