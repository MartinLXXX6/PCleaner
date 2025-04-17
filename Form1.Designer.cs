namespace PCleaner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            storageLabel = new Label();
            tempButton = new Button();
            cleanupButton = new Button();
            memoryLabel = new Label();
            startupButton = new Button();
            servicesButton = new Button();
            quitButton = new Button();
            githubButton = new Button();
            toolTip1 = new ToolTip(components);
            featuresButton = new Button();
            UWPButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // storageLabel
            // 
            storageLabel.AutoSize = true;
            storageLabel.Location = new Point(195, 97);
            storageLabel.Name = "storageLabel";
            storageLabel.Size = new Size(256, 45);
            storageLabel.TabIndex = 0;
            storageLabel.Text = "STORAGE (DISK)";
            // 
            // tempButton
            // 
            tempButton.BackColor = Color.LightGray;
            tempButton.Cursor = Cursors.Hand;
            tempButton.FlatAppearance.BorderColor = Color.DarkGray;
            tempButton.FlatAppearance.BorderSize = 5;
            tempButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            tempButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            tempButton.FlatStyle = FlatStyle.Flat;
            tempButton.ForeColor = Color.Black;
            tempButton.Location = new Point(12, 145);
            tempButton.Name = "tempButton";
            tempButton.Size = new Size(319, 135);
            tempButton.TabIndex = 1;
            tempButton.Text = "Clear Windows Temp Files";
            toolTip1.SetToolTip(tempButton, "Deletes files & folders on the following locations (MAY TAKE A WHILE):\r\n- Temp\r\n- %Temp%\r\n- Prefetch");
            tempButton.UseVisualStyleBackColor = false;
            tempButton.Click += tempButton_Click;
            // 
            // cleanupButton
            // 
            cleanupButton.BackColor = Color.LightGray;
            cleanupButton.Cursor = Cursors.Hand;
            cleanupButton.FlatAppearance.BorderColor = Color.DarkGray;
            cleanupButton.FlatAppearance.BorderSize = 5;
            cleanupButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            cleanupButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            cleanupButton.FlatStyle = FlatStyle.Flat;
            cleanupButton.ForeColor = Color.Black;
            cleanupButton.Location = new Point(337, 145);
            cleanupButton.Name = "cleanupButton";
            cleanupButton.Size = new Size(297, 135);
            cleanupButton.TabIndex = 2;
            cleanupButton.Text = "Run Disk Cleanup";
            toolTip1.SetToolTip(cleanupButton, "Runs Disk Cleanup utility (MAY TAKE A WHILE).\r\nIt is recommended to check everithing.");
            cleanupButton.UseVisualStyleBackColor = false;
            cleanupButton.Click += cleanupButton_Click;
            // 
            // memoryLabel
            // 
            memoryLabel.AutoSize = true;
            memoryLabel.Location = new Point(194, 395);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(259, 45);
            memoryLabel.TabIndex = 3;
            memoryLabel.Text = "MEMORY (RAM)";
            // 
            // startupButton
            // 
            startupButton.BackColor = Color.LightGray;
            startupButton.Cursor = Cursors.Hand;
            startupButton.FlatAppearance.BorderColor = Color.DarkGray;
            startupButton.FlatAppearance.BorderSize = 5;
            startupButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            startupButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            startupButton.FlatStyle = FlatStyle.Flat;
            startupButton.ForeColor = Color.Black;
            startupButton.Location = new Point(12, 443);
            startupButton.Name = "startupButton";
            startupButton.Size = new Size(332, 135);
            startupButton.TabIndex = 4;
            startupButton.Text = "Check Startup Apps";
            toolTip1.SetToolTip(startupButton, "Check them regularly!!!");
            startupButton.UseVisualStyleBackColor = false;
            startupButton.Click += startupButton_Click;
            // 
            // servicesButton
            // 
            servicesButton.BackColor = Color.LightGray;
            servicesButton.Cursor = Cursors.Hand;
            servicesButton.FlatAppearance.BorderColor = Color.DarkGray;
            servicesButton.FlatAppearance.BorderSize = 5;
            servicesButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            servicesButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            servicesButton.FlatStyle = FlatStyle.Flat;
            servicesButton.ForeColor = Color.Black;
            servicesButton.Location = new Point(350, 443);
            servicesButton.Name = "servicesButton";
            servicesButton.Size = new Size(284, 135);
            servicesButton.TabIndex = 5;
            servicesButton.Text = "Show Services";
            toolTip1.SetToolTip(servicesButton, "See important services. Make sure you check the box that says:\r\n\"Hide Microsoft Services\" to only see third-party services.");
            servicesButton.UseVisualStyleBackColor = false;
            servicesButton.Click += servicesButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.LightGray;
            quitButton.BackgroundImage = Properties.Resources.Exit;
            quitButton.Cursor = Cursors.Hand;
            quitButton.FlatAppearance.BorderColor = Color.DarkGray;
            quitButton.FlatAppearance.BorderSize = 5;
            quitButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            quitButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.ForeColor = Color.Black;
            quitButton.Location = new Point(12, 12);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(70, 70);
            quitButton.TabIndex = 6;
            toolTip1.SetToolTip(quitButton, "Exit");
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // githubButton
            // 
            githubButton.BackColor = Color.LightGray;
            githubButton.BackgroundImage = Properties.Resources.Github;
            githubButton.Cursor = Cursors.Hand;
            githubButton.FlatAppearance.BorderColor = Color.DarkGray;
            githubButton.FlatAppearance.BorderSize = 5;
            githubButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            githubButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            githubButton.FlatStyle = FlatStyle.Flat;
            githubButton.ForeColor = Color.Black;
            githubButton.Location = new Point(564, 12);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(70, 70);
            githubButton.TabIndex = 7;
            toolTip1.SetToolTip(githubButton, "See Github Page");
            githubButton.UseVisualStyleBackColor = false;
            githubButton.Click += githubButton_Click;
            // 
            // featuresButton
            // 
            featuresButton.BackColor = Color.LightGray;
            featuresButton.Cursor = Cursors.Hand;
            featuresButton.FlatAppearance.BorderColor = Color.DarkGray;
            featuresButton.FlatAppearance.BorderSize = 5;
            featuresButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            featuresButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            featuresButton.FlatStyle = FlatStyle.Flat;
            featuresButton.ForeColor = Color.Black;
            featuresButton.Location = new Point(12, 286);
            featuresButton.Name = "featuresButton";
            featuresButton.Size = new Size(622, 80);
            featuresButton.TabIndex = 8;
            featuresButton.Text = "Check Optional Windows Features";
            toolTip1.SetToolTip(featuresButton, "Recommend:\r\n- .Net Framework 3.5\r\n- .Net Framework 4.8\r\n- Microsoft Print to PDF\r\n\r\nNOT RECOMMENDED (Security Vulnerabilities):\r\n- SMB 1.0\r\n- Windows Powershell 2.0");
            featuresButton.UseVisualStyleBackColor = false;
            featuresButton.Click += featuresButton_Click;
            // 
            // UWPButton
            // 
            UWPButton.BackColor = Color.LightGray;
            UWPButton.Cursor = Cursors.Hand;
            UWPButton.FlatAppearance.BorderColor = Color.DarkGray;
            UWPButton.FlatAppearance.BorderSize = 5;
            UWPButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            UWPButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            UWPButton.FlatStyle = FlatStyle.Flat;
            UWPButton.ForeColor = Color.Black;
            UWPButton.Location = new Point(12, 584);
            UWPButton.Name = "UWPButton";
            UWPButton.Size = new Size(622, 80);
            UWPButton.TabIndex = 9;
            UWPButton.Text = "Disable Store Background Apps";
            toolTip1.SetToolTip(UWPButton, "Disable UWP (Microsoft Store) Apps from running randomly in the Background.");
            UWPButton.UseVisualStyleBackColor = false;
            UWPButton.Click += UWPButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(132, 12);
            label1.Name = "label1";
            label1.Size = new Size(383, 38);
            label1.TabIndex = 10;
            label1.Text = "HOVER OVER TO SEE DETAILS";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DimGray;
            ClientSize = new Size(646, 676);
            Controls.Add(label1);
            Controls.Add(UWPButton);
            Controls.Add(featuresButton);
            Controls.Add(githubButton);
            Controls.Add(quitButton);
            Controls.Add(servicesButton);
            Controls.Add(startupButton);
            Controls.Add(memoryLabel);
            Controls.Add(cleanupButton);
            Controls.Add(tempButton);
            Controls.Add(storageLabel);
            Font = new Font("Segoe UI", 14F);
            ForeColor = Color.WhiteSmoke;
            MaximizeBox = false;
            MaximumSize = new Size(670, 740);
            MinimumSize = new Size(670, 740);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PCleaner by TheFreeDevClub";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label storageLabel;
        private Button tempButton;
        private Button cleanupButton;
        private Label memoryLabel;
        private Button startupButton;
        private Button servicesButton;
        private Button quitButton;
        private Button githubButton;
        private ToolTip toolTip1;
        private Button featuresButton;
        private Button UWPButton;
        private Label label1;
    }
}
