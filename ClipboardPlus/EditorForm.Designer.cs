namespace ClipboardPlus
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(22, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(795, 319);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.Transparent;
            this.change_btn.FlatAppearance.BorderSize = 0;
            this.change_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.change_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.change_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_btn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.change_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.change_btn.Location = new System.Drawing.Point(704, 357);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(113, 43);
            this.change_btn.TabIndex = 1;
            this.change_btn.TabStop = false;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = false;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cancel_btn.Location = new System.Drawing.Point(568, 357);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(113, 43);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.TabStop = false;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.menu_btn.FlatAppearance.BorderSize = 0;
            this.menu_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menu_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.menu_btn.Location = new System.Drawing.Point(14, 356);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(179, 42);
            this.menu_btn.TabIndex = 3;
            this.menu_btn.TabStop = false;
            this.menu_btn.Text = "Menu";
            this.menu_btn.UseVisualStyleBackColor = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 409);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cancel_btn);
            this.DoubleBuffered = true;
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button change_btn;
        private Button cancel_btn;
        private Button menu_btn;
    }
}