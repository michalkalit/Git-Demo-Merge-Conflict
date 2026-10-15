namespace Git_Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.Label countLabel;

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
            this.clickMeButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            // Form appearance
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "Click Counter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // clickMeButton
            this.clickMeButton.Location = new System.Drawing.Point(250, 220);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(100, 40);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.Text = "Click me";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);

            // countLabel
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(250, 120);
            this.countLabel.Name = "countLabel";
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "Count: 0";
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Add controls
            this.Controls.Add(this.clickMeButton);
            this.Controls.Add(this.countLabel);
        }

        #endregion
    }
}
