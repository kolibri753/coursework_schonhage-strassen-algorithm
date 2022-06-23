
namespace Schonhage_StrassenAlgorithm
{
    partial class AcyclicConvolutionForm
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
            this.rtbAcyclicConvolution = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAcyclicConvolution
            // 
            this.rtbAcyclicConvolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAcyclicConvolution.Location = new System.Drawing.Point(0, 0);
            this.rtbAcyclicConvolution.Name = "rtbAcyclicConvolution";
            this.rtbAcyclicConvolution.Size = new System.Drawing.Size(482, 253);
            this.rtbAcyclicConvolution.TabIndex = 0;
            this.rtbAcyclicConvolution.Text = "";
            // 
            // AcyclicConvolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.rtbAcyclicConvolution);
            this.Name = "AcyclicConvolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ациклічна згортка ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAcyclicConvolution;
    }
}