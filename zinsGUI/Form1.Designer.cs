namespace zinsGUI
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
            CmdAusrechnen = new Button();
            LblStartkapital = new Label();
            tBStartkapital = new TextBox();
            tBZinssatz = new TextBox();
            LblZinssatz = new Label();
            tBJahrezuberechnen = new TextBox();
            LblJahrezuberechnen = new Label();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdAusrechnen
            // 
            CmdAusrechnen.Location = new Point(389, 74);
            CmdAusrechnen.Name = "CmdAusrechnen";
            CmdAusrechnen.Size = new Size(94, 29);
            CmdAusrechnen.TabIndex = 0;
            CmdAusrechnen.Text = "ausrechnen";
            CmdAusrechnen.UseVisualStyleBackColor = true;
            CmdAusrechnen.Click += CmdAusrechnen_Click;
            // 
            // LblStartkapital
            // 
            LblStartkapital.AutoSize = true;
            LblStartkapital.Location = new Point(38, 82);
            LblStartkapital.Name = "LblStartkapital";
            LblStartkapital.Size = new Size(85, 20);
            LblStartkapital.TabIndex = 1;
            LblStartkapital.Text = "Startkapital";
            // 
            // tBStartkapital
            // 
            tBStartkapital.Location = new Point(213, 75);
            tBStartkapital.Name = "tBStartkapital";
            tBStartkapital.Size = new Size(125, 27);
            tBStartkapital.TabIndex = 2;
            // 
            // tBZinssatz
            // 
            tBZinssatz.Location = new Point(213, 132);
            tBZinssatz.Name = "tBZinssatz";
            tBZinssatz.Size = new Size(125, 27);
            tBZinssatz.TabIndex = 4;
            // 
            // LblZinssatz
            // 
            LblZinssatz.AutoSize = true;
            LblZinssatz.Location = new Point(38, 139);
            LblZinssatz.Name = "LblZinssatz";
            LblZinssatz.Size = new Size(62, 20);
            LblZinssatz.TabIndex = 3;
            LblZinssatz.Text = "Zinssatz";
            // 
            // tBJahrezuberechnen
            // 
            tBJahrezuberechnen.Location = new Point(213, 198);
            tBJahrezuberechnen.Name = "tBJahrezuberechnen";
            tBJahrezuberechnen.Size = new Size(125, 27);
            tBJahrezuberechnen.TabIndex = 6;
            // 
            // LblJahrezuberechnen
            // 
            LblJahrezuberechnen.AutoSize = true;
            LblJahrezuberechnen.Location = new Point(38, 205);
            LblJahrezuberechnen.Name = "LblJahrezuberechnen";
            LblJahrezuberechnen.Size = new Size(135, 20);
            LblJahrezuberechnen.TabIndex = 5;
            LblJahrezuberechnen.Text = "Jahre zu berechnen";
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.BorderStyle = BorderStyle.Fixed3D;
            LblAusgabe.Location = new Point(396, 133);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(2, 22);
            LblAusgabe.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(tBJahrezuberechnen);
            Controls.Add(LblJahrezuberechnen);
            Controls.Add(tBZinssatz);
            Controls.Add(LblZinssatz);
            Controls.Add(tBStartkapital);
            Controls.Add(LblStartkapital);
            Controls.Add(CmdAusrechnen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAusrechnen;
        private Label LblStartkapital;
        private TextBox tBStartkapital;
        private TextBox tBZinssatz;
        private Label LblZinssatz;
        private TextBox tBJahrezuberechnen;
        private Label LblJahrezuberechnen;
        private Label LblAusgabe;
    }
}