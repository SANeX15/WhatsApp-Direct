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
            this.Code = new System.Windows.Forms.TextBox();
            this.MbNo = new System.Windows.Forms.TextBox();
            this.MsgBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Mode = new System.Windows.Forms.CheckBox();
            this.MsgEnabled = new System.Windows.Forms.CheckBox();
            this.GO = new WhatsApp_Direct.CustomControls_ModernButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.Code.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
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
            this.MbNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
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
            this.groupBox1.Location = new System.Drawing.Point(0, -70);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
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
            this.Mode.Image = global::WhatsApp_Direct.Properties.Resources.desktop;
            this.Mode.Location = new System.Drawing.Point(266, 15);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(31, 31);
            this.Mode.TabIndex = 6;
            this.Mode.UseVisualStyleBackColor = false;
            this.Mode.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
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
            this.MsgEnabled.Image = global::WhatsApp_Direct.Properties.Resources.message_off;
            this.MsgEnabled.Location = new System.Drawing.Point(303, 15);
            this.MsgEnabled.Name = "MsgEnabled";
            this.MsgEnabled.Size = new System.Drawing.Size(31, 31);
            this.MsgEnabled.TabIndex = 5;
            this.MsgEnabled.UseVisualStyleBackColor = false;
            this.MsgEnabled.CheckedChanged += new System.EventHandler(this.msgEnabled_CheckedChanged);
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
            this.GO.Location = new System.Drawing.Point(0, 55);
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
            this.ClientSize = new System.Drawing.Size(342, 96);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox MbNo;
        private CustomControls_ModernButton GO;
        private System.Windows.Forms.CheckBox MsgEnabled;
        private System.Windows.Forms.TextBox MsgBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Mode;
    }
}

