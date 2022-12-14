namespace ClipboardPlus
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.RunOnStartup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(105, 364);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(105, 23);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "Exit Program";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(105, 325);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(105, 23);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "Close Menu";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // RunOnStartup_btn
            // 
            this.RunOnStartup_btn.Location = new System.Drawing.Point(83, 76);
            this.RunOnStartup_btn.Name = "RunOnStartup_btn";
            this.RunOnStartup_btn.Size = new System.Drawing.Size(144, 23);
            this.RunOnStartup_btn.TabIndex = 3;
            this.RunOnStartup_btn.Text = "RunOnStartup";
            this.RunOnStartup_btn.UseVisualStyleBackColor = true;
            this.RunOnStartup_btn.Click += new System.EventHandler(this.RunOnStartup_btn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 418);
            this.Controls.Add(this.RunOnStartup_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Program Setting (Menu)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_btn;
        private Label label1;
        private Button close_btn;
        private Button RunOnStartup_btn;
    }
}