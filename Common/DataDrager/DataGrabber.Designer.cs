namespace DataDrager
{
    partial class DataGrabber
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
            this.Init = new System.Windows.Forms.Button();
            this.Begin = new System.Windows.Forms.Button();
            this.Infos = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(42, 46);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(75, 23);
            this.Init.TabIndex = 0;
            this.Init.Text = "Init";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(42, 94);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(75, 23);
            this.Begin.TabIndex = 1;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Infos
            // 
            this.Infos.AutoSize = true;
            this.Infos.Location = new System.Drawing.Point(13, 13);
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(41, 12);
            this.Infos.TabIndex = 2;
            this.Infos.Text = "Infos:";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.ForeColor = System.Drawing.SystemColors.Highlight;
            this.info.Location = new System.Drawing.Point(70, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(17, 12);
            this.info.TabIndex = 3;
            this.info.Text = "~~";
            // 
            // DataGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Infos);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.Init);
            this.Name = "DataGrabber";
            this.Text = "DataGrabber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Label Infos;
        private System.Windows.Forms.Label info;
    }
}