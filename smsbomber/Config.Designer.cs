namespace smsbomber
{
    partial class Config
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
            this.LVResource = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxform = new System.Windows.Forms.TextBox();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVResource
            // 
            this.LVResource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LVResource.ContextMenuStrip = this.contextMenuStrip1;
            this.LVResource.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LVResource.FullRowSelect = true;
            this.LVResource.GridLines = true;
            this.LVResource.Location = new System.Drawing.Point(0, 92);
            this.LVResource.Name = "LVResource";
            this.LVResource.Size = new System.Drawing.Size(474, 196);
            this.LVResource.TabIndex = 0;
            this.LVResource.UseCompatibleStateImageBehavior = false;
            this.LVResource.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "地址";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "间隔";
            this.columnHeader2.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.DeleteToolStripMenuItem.Text = "删除";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(45, 2);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(417, 21);
            this.tbxURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地址：";
            // 
            // tbxInterval
            // 
            this.tbxInterval.Location = new System.Drawing.Point(45, 65);
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(120, 21);
            this.tbxInterval.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "间隔：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "S";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cbMethod.Location = new System.Drawing.Point(71, 33);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(121, 20);
            this.cbMethod.TabIndex = 7;
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "提交方式：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "表单名称：";
            // 
            // tbxform
            // 
            this.tbxform.Location = new System.Drawing.Point(289, 32);
            this.tbxform.Name = "tbxform";
            this.tbxform.Size = new System.Drawing.Size(172, 21);
            this.tbxform.TabIndex = 10;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "提交方式";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "表单名称";
            this.columnHeader4.Width = 80;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxURL);
            this.Controls.Add(this.LVResource);
            this.Controls.Add(this.tbxInterval);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Config_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVResource;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbxform;
    }
}