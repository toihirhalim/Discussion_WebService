
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
            this.SuspendLayout();
            // 
            // sender
            // 
            this.sender.AutoSize = true;
            this.sender.Dock = System.Windows.Forms.DockStyle.Left;
            this.sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sender.Location = new System.Drawing.Point(0, 0);
            this.sender.MaximumSize = new System.Drawing.Size(70, 0);
            this.sender.Name = "sender";
            this.sender.Padding = new System.Windows.Forms.Padding(5);
            this.sender.Size = new System.Drawing.Size(55, 23);
            this.sender.TabIndex = 0;
            this.sender.Text = "sender";
            // 
            // msgText
            // 
            this.msgText.AutoSize = true;
            this.msgText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgText.Location = new System.Drawing.Point(55, 0);
            this.msgText.MaximumSize = new System.Drawing.Size(270, 0);
            this.msgText.Name = "msgText";
            this.msgText.Padding = new System.Windows.Forms.Padding(5);
            this.msgText.Size = new System.Drawing.Size(59, 23);
            this.msgText.TabIndex = 1;
            this.msgText.Text = "message";
            // 
            // MessageRecuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.sender);
            this.MaximumSize = new System.Drawing.Size(311, 0);
            this.MinimumSize = new System.Drawing.Size(50, 25);
            this.Name = "MessageRecuUC";
            this.Size = new System.Drawing.Size(114, 25);
            this.Load += new System.EventHandler(this.MessageRecuUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sender;
        private System.Windows.Forms.Label msgText;
    }
}
