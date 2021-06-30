
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participants";
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(176, 400);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(499, 37);
            this.msgBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discussion";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(681, 400);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(107, 37);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // listParticipants
            // 
            this.listParticipants.FormattingEnabled = true;
            this.listParticipants.Location = new System.Drawing.Point(12, 58);
            this.listParticipants.Name = "listParticipants";
            this.listParticipants.Size = new System.Drawing.Size(158, 379);
            this.listParticipants.TabIndex = 8;
            // 
            // selectAll
            // 
            this.selectAll.AutoSize = true;
            this.selectAll.Checked = true;
            this.selectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectAll.Location = new System.Drawing.Point(90, 25);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(70, 17);
            this.selectAll.TabIndex = 9;
            this.selectAll.Text = "Select All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.CheckedChanged += new System.EventHandler(this.selectAll_CheckedChanged);
            // 
            // flPnl
            // 
            this.flPnl.AutoScroll = true;
            this.flPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPnl.Location = new System.Drawing.Point(176, 58);
            this.flPnl.Name = "flPnl";
            this.flPnl.Size = new System.Drawing.Size(609, 323);
            this.flPnl.TabIndex = 10;
            this.flPnl.WrapContents = false;
            // 
            // Participation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.flPnl);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.listParticipants);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.label1);
            this.Name = "Participation";
            this.Text = "Participation";
            this.Load += new System.EventHandler(this.Participation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}