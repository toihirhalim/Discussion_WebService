
namespace Discussion
{
    partial class MessageRecuUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sender = new System.Windows.Forms.Label();
            this.msgText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sender
            // 
            this.sender.AutoSize = true;
            this.sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sender.Location = new System.Drawing.Point(3, 0);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(45, 13);
            this.sender.TabIndex = 0;
            this.sender.Text = "sender";
            // 
            // msgText
            // 
            this.msgText.AutoSize = true;
            this.msgText.Location = new System.Drawing.Point(3, 0);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(49, 13);
            this.msgText.TabIndex = 1;
            this.msgText.Text = "message";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.msgText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(231, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(231, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 13);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.sender);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(67, 27);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // MessageRecuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(311, 0);
            this.MinimumSize = new System.Drawing.Size(100, 30);
            this.Name = "MessageRecuUC";
            this.Size = new System.Drawing.Size(311, 33);
            this.Load += new System.EventHandler(this.MessageRecuUC_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sender;
        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
