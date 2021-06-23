
namespace Discussion
{
    partial class MessageUC
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
            this.flPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flPnl
            // 
            this.flPnl.AutoSize = true;
            this.flPnl.BackColor = System.Drawing.Color.Transparent;
            this.flPnl.Location = new System.Drawing.Point(3, -7);
            this.flPnl.Name = "flPnl";
            this.flPnl.Size = new System.Drawing.Size(580, 0);
            this.flPnl.TabIndex = 0;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flPnl);
            this.MaximumSize = new System.Drawing.Size(609, 0);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(609, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnl;
    }
}
