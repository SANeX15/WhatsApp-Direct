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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MinimiseBtn = new WhatsApp_Direct.CustomControls_ModernButton();
            this.CloseBtn = new WhatsApp_Direct.CustomControls_ModernButton();
            this.Code = new System.Windows.Forms.TextBox();
            this.MbNo = new System.Windows.Forms.TextBox();
            this.MsgBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Mode = new System.Windows.Forms.CheckBox();
            this.waMode = new System.Windows.Forms.ImageList(this.components);
            this.MsgEnabled = new System.Windows.Forms.CheckBox();
            this.msg = new System.Windows.Forms.ImageList(this.components);
            this.GO = new WhatsApp_Direct.CustomControls_ModernButton();
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
            this.TitleBar.Size = new System.Drawing.Size(342, 17);
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
            this.MinimiseBtn.BackgroundColor = System.Drawing.Color.Gold;
            this.MinimiseBtn.BorderColor = System.Drawing.Color.Gold;
            this.MinimiseBtn.BorderRadius = 5;
            this.MinimiseBtn.BorderSize = 1;
            this.MinimiseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimiseBtn.FlatAppearance.BorderSize = 0;
            this.MinimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseBtn.ForeColor = System.Drawing.Color.White;
            this.MinimiseBtn.Location = new System.Drawing.Point(250, 0);
            this.MinimiseBtn.Name = "MinimiseBtn";
            this.MinimiseBtn.Size = new System.Drawing.Size(45, 15);
            this.MinimiseBtn.TabIndex = 1;
            this.MinimiseBtn.TextColor = System.Drawing.Color.White;
            this.MinimiseBtn.UseVisualStyleBackColor = false;
            this.MinimiseBtn.Click += new System.EventHandler(this.MinimiseBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.BorderRadius = 5;
            this.CloseBtn.BorderSize = 1;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(295, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 15);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TextColor = System.Drawing.Color.White;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.ForeColor = System.Drawing.Color.White;
            this.Code.Location = new System.Drawing.Point(8, 15);
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
            this.MbNo.Location = new System.Drawing.Point(55, 15);
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
            // MsgBox
            // 
            this.MsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.ForeColor = System.Drawing.Color.White;
            this.MsgBox.Location = new System.Drawing.Point(3, 18);
            this.MsgBox.Multiline = true;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MsgBox.Size = new System.Drawing.Size(336, 104);
            this.MsgBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsgBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, -56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 125);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Mode);
            this.groupBox2.Controls.Add(this.MbNo);
            this.groupBox2.Controls.Add(this.MsgEnabled);
            this.groupBox2.Controls.Add(this.Code);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 55);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Mode
            // 
            this.Mode.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mode.AutoSize = true;
            this.Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mode.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Mode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Mode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.ImageIndex = 0;
            this.Mode.ImageList = this.waMode;
            this.Mode.Location = new System.Drawing.Point(266, 15);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(31, 31);
            this.Mode.TabIndex = 6;
            this.Mode.UseVisualStyleBackColor = false;
            this.Mode.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // waMode
            // 
            this.waMode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("waMode.ImageStream")));
            this.waMode.TransparentColor = System.Drawing.Color.Transparent;
            this.waMode.Images.SetKeyName(0, "desktop.png");
            this.waMode.Images.SetKeyName(1, "web.png");
            // 
            // MsgEnabled
            // 
            this.MsgEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.MsgEnabled.AutoSize = true;
            this.MsgEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MsgEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MsgEnabled.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.MsgEnabled.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MsgEnabled.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MsgEnabled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MsgEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgEnabled.ForeColor = System.Drawing.Color.White;
            this.MsgEnabled.ImageIndex = 0;
            this.MsgEnabled.ImageList = this.msg;
            this.MsgEnabled.Location = new System.Drawing.Point(303, 15);
            this.MsgEnabled.Name = "MsgEnabled";
            this.MsgEnabled.Size = new System.Drawing.Size(31, 31);
            this.MsgEnabled.TabIndex = 5;
            this.MsgEnabled.UseVisualStyleBackColor = false;
            this.MsgEnabled.CheckedChanged += new System.EventHandler(this.msgEnabled_CheckedChanged);
            // 
            // msg
            // 
            this.msg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("msg.ImageStream")));
            this.msg.TransparentColor = System.Drawing.Color.Transparent;
            this.msg.Images.SetKeyName(0, "message off.png");
            this.msg.Images.SetKeyName(1, "message on.png");
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.GO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GO.BorderColor = System.Drawing.Color.Gray;
            this.GO.BorderRadius = 5;
            this.GO.BorderSize = 1;
            this.GO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.ForeColor = System.Drawing.Color.White;
            this.GO.Image = ((System.Drawing.Image)(resources.GetObject("GO.Image")));
            this.GO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GO.Location = new System.Drawing.Point(0, 69);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(342, 41);
            this.GO.TabIndex = 3;
            this.GO.Text = "Launch Whatsapp";
            this.GO.TextColor = System.Drawing.Color.White;
            this.GO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GO.UseVisualStyleBackColor = false;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(342, 110);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private CustomControls_ModernButton MinimiseBtn;
        private CustomControls_ModernButton CloseBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox MbNo;
        private CustomControls_ModernButton GO;
        private System.Windows.Forms.CheckBox MsgEnabled;
        private System.Windows.Forms.TextBox MsgBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Mode;
        private System.Windows.Forms.ImageList waMode;
        private System.Windows.Forms.ImageList msg;
    }
}

