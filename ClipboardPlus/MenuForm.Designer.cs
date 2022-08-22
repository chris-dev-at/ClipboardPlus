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
            this.startup_btn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(25, 137);
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
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(25, 79);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(105, 23);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "Close Menu";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // startup_btn
            // 
            this.startup_btn.AutoSize = true;
            this.startup_btn.Location = new System.Drawing.Point(25, 112);
            this.startup_btn.Name = "startup_btn";
            this.startup_btn.Size = new System.Drawing.Size(101, 19);
            this.startup_btn.TabIndex = 4;
            this.startup_btn.Text = "run on startup";
            this.startup_btn.UseVisualStyleBackColor = true;
            this.startup_btn.CheckedChanged += new System.EventHandler(this.startup_btn_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 415);
            this.Controls.Add(this.startup_btn);
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
        private CheckBox startup_btn;
    }
}