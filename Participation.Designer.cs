
namespace Discussion
{
    partial class Participation
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
            this.label1 = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.listParticipants = new System.Windows.Forms.CheckedListBox();
            this.selectAll = new System.Windows.Forms.CheckBox();
            this.flPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.unselectAll = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participants";
            // 
            // msgBox
            // 
            this.msgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgBox.Location = new System.Drawing.Point(0, 0);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(526, 38);
            this.msgBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discussion";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(526, 0);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(107, 38);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // listParticipants
            // 
            this.listParticipants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listParticipants.FormattingEnabled = true;
            this.listParticipants.Location = new System.Drawing.Point(5, 51);
            this.listParticipants.Name = "listParticipants";
            this.listParticipants.Size = new System.Drawing.Size(148, 394);
            this.listParticipants.TabIndex = 8;
            this.listParticipants.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listParticipants_ItemCheck);
            // 
            // selectAll
            // 
            this.selectAll.AutoSize = true;
            this.selectAll.Checked = true;
            this.selectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectAll.Location = new System.Drawing.Point(71, 12);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(37, 17);
            this.selectAll.TabIndex = 9;
            this.selectAll.Text = "All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.CheckedChanged += new System.EventHandler(this.selectAll_CheckedChanged);
            // 
            // flPnl
            // 
            this.flPnl.AutoScroll = true;
            this.flPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPnl.Location = new System.Drawing.Point(0, 13);
            this.flPnl.Name = "flPnl";
            this.flPnl.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flPnl.Size = new System.Drawing.Size(633, 356);
            this.flPnl.TabIndex = 10;
            this.flPnl.WrapContents = false;
            // 
            // unselectAll
            // 
            this.unselectAll.AutoSize = true;
            this.unselectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unselectAll.ForeColor = System.Drawing.SystemColors.GrayText;
            this.unselectAll.Location = new System.Drawing.Point(114, 12);
            this.unselectAll.Name = "unselectAll";
            this.unselectAll.Size = new System.Drawing.Size(15, 13);
            this.unselectAll.TabIndex = 11;
            this.unselectAll.Text = "X";
            this.unselectAll.Click += new System.EventHandler(this.unselectAll_Click);
            this.unselectAll.MouseLeave += new System.EventHandler(this.unselectAll_MouseLeave);
            this.unselectAll.MouseHover += new System.EventHandler(this.unselectAll_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listParticipants);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(158, 450);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.unselectAll);
            this.panel2.Controls.Add(this.selectAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 40);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flPnl);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 369);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.msgBox);
            this.panel4.Controls.Add(this.sendBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 38);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.error);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(5, 394);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(633, 51);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(158, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(643, 450);
            this.panel6.TabIndex = 14;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(56, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 4;
            // 
            // Participation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "Participation";
            this.Text = "Participation";
            this.Load += new System.EventHandler(this.Participation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.CheckedListBox listParticipants;
        private System.Windows.Forms.CheckBox selectAll;
        private System.Windows.Forms.FlowLayoutPanel flPnl;
        private System.Windows.Forms.Label unselectAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label error;
    }
}