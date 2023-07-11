namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            ukrainianToolStripMenuItem = new ToolStripMenuItem();
            sPToolStripMenuItem = new ToolStripMenuItem();
            gERToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem, englishToolStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, ukrainianToolStripMenuItem, sPToolStripMenuItem, gERToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(englishToolStripMenuItem, "englishToolStripMenuItem");
            englishToolStripMenuItem.Image = Properties.Resources.ENG;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // ukrainianToolStripMenuItem
            // 
            resources.ApplyResources(ukrainianToolStripMenuItem, "ukrainianToolStripMenuItem");
            ukrainianToolStripMenuItem.Image = Properties.Resources.UKR;
            ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            ukrainianToolStripMenuItem.Click += ukrainianToolStripMenuItem_Click;
            // 
            // sPToolStripMenuItem
            // 
            sPToolStripMenuItem.Image = Properties.Resources.SPN;
            sPToolStripMenuItem.Name = "sPToolStripMenuItem";
            resources.ApplyResources(sPToolStripMenuItem, "sPToolStripMenuItem");
            sPToolStripMenuItem.Click += sPToolStripMenuItem_Click;
            // 
            // gERToolStripMenuItem
            // 
            gERToolStripMenuItem.Image = Properties.Resources.GER;
            gERToolStripMenuItem.Name = "gERToolStripMenuItem";
            resources.ApplyResources(gERToolStripMenuItem, "gERToolStripMenuItem");
            gERToolStripMenuItem.Click += gERToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem1
            // 
            englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            resources.ApplyResources(englishToolStripMenuItem1, "englishToolStripMenuItem1");
            englishToolStripMenuItem1.Click += englishToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Desktop;
            label1.Name = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.Desktop;
            label2.Name = "label2";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.Desktop;
            label3.Name = "label3";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Info;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.Desktop;
            label4.Name = "label4";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Info;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.ForeColor = SystemColors.ControlLightLight;
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.Desktop;
            label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem ukrainianToolStripMenuItem;
        private ToolStripMenuItem sPToolStripMenuItem;
        private ToolStripMenuItem gERToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
    }
}