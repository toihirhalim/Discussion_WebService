﻿
namespace Discussion
{
    partial class NotificationUC
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
            this.msgText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgText
            // 
            this.msgText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgText.Location = new System.Drawing.Point(0, 0);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(583, 20);
            this.msgText.TabIndex = 0;
            this.msgText.Text = "Welcome";
            this.msgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgText);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "NotificationUC";
            this.Size = new System.Drawing.Size(583, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label msgText;
    }
}
