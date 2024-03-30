namespace WhatsApp_Direct
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MinimiseBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.MbNo = new System.Windows.Forms.TextBox();
            this.GO = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.MsgEnabled = new System.Windows.Forms.CheckBox();
            this.MsgBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TitleBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.MinimiseBtn);
            this.TitleBar.Controls.Add(this.CloseBtn);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(271, 17);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(97, 15);
            this.Title.TabIndex = 2;
            this.Title.Text = "WhatsApp Direct";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // MinimiseBtn
            // 
            this.MinimiseBtn.BackColor = System.Drawing.Color.Gold;
            this.MinimiseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimiseBtn.FlatAppearance.BorderSize = 0;
            this.MinimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseBtn.ForeColor = System.Drawing.Color.White;
            this.MinimiseBtn.Location = new System.Drawing.Point(179, 0);
            this.MinimiseBtn.Name = "MinimiseBtn";
            this.MinimiseBtn.Size = new System.Drawing.Size(45, 15);
            this.MinimiseBtn.TabIndex = 1;
            this.MinimiseBtn.UseVisualStyleBackColor = false;
            this.MinimiseBtn.Click += new System.EventHandler(this.MinimiseBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(224, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 15);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.ForeColor = System.Drawing.Color.White;
            this.Code.Location = new System.Drawing.Point(12, 19);
            this.Code.MaxLength = 3;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(41, 31);
            this.Code.TabIndex = 1;
            this.Code.Text = "91";
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Code.WordWrap = false;
            // 
            // MbNo
            // 
            this.MbNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MbNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbNo.ForeColor = System.Drawing.Color.White;
            this.MbNo.Location = new System.Drawing.Point(59, 19);
            this.MbNo.MaxLength = 10;
            this.MbNo.Name = "MbNo";
            this.MbNo.Size = new System.Drawing.Size(205, 31);
            this.MbNo.TabIndex = 2;
            this.MbNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MbNo.WordWrap = false;
            this.MbNo.Enter += new System.EventHandler(this.MbNo_Enter);
            this.MbNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MbNo_KeyDown);
            this.MbNo.Leave += new System.EventHandler(this.MbNo_Leave);
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GO.BackgroundImage = global::WhatsApp_Direct.Properties.Resources.External_Link;
            this.GO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GO.ForeColor = System.Drawing.Color.White;
            this.GO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GO.Location = new System.Drawing.Point(0, 138);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(271, 41);
            this.GO.TabIndex = 3;
            this.GO.UseVisualStyleBackColor = false;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.ForeColor = System.Drawing.Color.White;
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "WhatsApp Desktop",
            "WhatsApp Web"});
            this.Mode.Location = new System.Drawing.Point(12, 55);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(252, 33);
            this.Mode.TabIndex = 4;
            this.Mode.SelectedIndexChanged += new System.EventHandler(this.Mode_SelectedIndexChanged);
            // 
            // MsgEnabled
            // 
            this.MsgEnabled.AutoSize = true;
            this.MsgEnabled.ForeColor = System.Drawing.Color.White;
            this.MsgEnabled.Location = new System.Drawing.Point(12, 94);
            this.MsgEnabled.Name = "MsgEnabled";
            this.MsgEnabled.Size = new System.Drawing.Size(116, 17);
            this.MsgEnabled.TabIndex = 5;
            this.MsgEnabled.Text = "Include Message ?";
            this.MsgEnabled.UseVisualStyleBackColor = true;
            this.MsgEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MsgBox
            // 
            this.MsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.ForeColor = System.Drawing.Color.White;
            this.MsgBox.Location = new System.Drawing.Point(3, 18);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MsgBox.Size = new System.Drawing.Size(289, 100);
            this.MsgBox.TabIndex = 8;
            this.MsgBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsgBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-24, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MbNo);
            this.groupBox2.Controls.Add(this.MsgEnabled);
            this.groupBox2.Controls.Add(this.Code);
            this.groupBox2.Controls.Add(this.Mode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(271, 179);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.GO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button MinimiseBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox MbNo;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.CheckBox MsgEnabled;
        private System.Windows.Forms.RichTextBox MsgBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

