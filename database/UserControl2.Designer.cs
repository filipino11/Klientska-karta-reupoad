namespace database
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.Location = new System.Drawing.Point(0, 240);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(480, 90);
            this.button23.TabIndex = 60;
            this.button23.Text = "Životní";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.Location = new System.Drawing.Point(0, 120);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(480, 90);
            this.button22.TabIndex = 59;
            this.button22.Text = "Auto";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21.Location = new System.Drawing.Point(0, 0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(480, 90);
            this.button21.TabIndex = 58;
            this.button21.Text = "Dům";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.Location = new System.Drawing.Point(0, 360);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(480, 90);
            this.button24.TabIndex = 61;
            this.button24.Text = "Další";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(480, 450);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button23;
        private Button button22;
        private Button button21;
        private Button button24;
    }
}
