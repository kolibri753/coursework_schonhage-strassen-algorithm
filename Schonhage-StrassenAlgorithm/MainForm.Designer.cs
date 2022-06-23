
namespace Schonhage_StrassenAlgorithm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFirstNum = new System.Windows.Forms.TextBox();
            this.tbSecondNum = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbAcyclicConvolution = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelFirstNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSecondNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelInputData = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbMultiplicationResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelInputData.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstNum
            // 
            this.tbFirstNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstNum.Location = new System.Drawing.Point(12, 12);
            this.tbFirstNum.Multiline = true;
            this.tbFirstNum.Name = "tbFirstNum";
            this.tbFirstNum.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbFirstNum.Size = new System.Drawing.Size(676, 50);
            this.tbFirstNum.TabIndex = 0;
            this.tbFirstNum.Text = "1234";
            this.tbFirstNum.WordWrap = false;
            this.tbFirstNum.TextChanged += new System.EventHandler(this.tbFirstNum_TextChanged);
            // 
            // tbSecondNum
            // 
            this.tbSecondNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSecondNum.Location = new System.Drawing.Point(12, 68);
            this.tbSecondNum.Multiline = true;
            this.tbSecondNum.Name = "tbSecondNum";
            this.tbSecondNum.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbSecondNum.Size = new System.Drawing.Size(676, 50);
            this.tbSecondNum.TabIndex = 1;
            this.tbSecondNum.Text = "5678";
            this.tbSecondNum.WordWrap = false;
            this.tbSecondNum.TextChanged += new System.EventHandler(this.tbSecondNum_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(18, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(211, 106);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Порахувати";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTime);
            this.groupBox1.Controls.Add(this.cbAcyclicConvolution);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(18, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додаткові функції";
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Location = new System.Drawing.Point(6, 130);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(182, 54);
            this.cbTime.TabIndex = 1;
            this.cbTime.Text = "Час \r\n(у мілісекундах)";
            this.cbTime.UseVisualStyleBackColor = true;
            // 
            // cbAcyclicConvolution
            // 
            this.cbAcyclicConvolution.AutoSize = true;
            this.cbAcyclicConvolution.Location = new System.Drawing.Point(6, 70);
            this.cbAcyclicConvolution.Name = "cbAcyclicConvolution";
            this.cbAcyclicConvolution.Size = new System.Drawing.Size(133, 54);
            this.cbAcyclicConvolution.TabIndex = 0;
            this.cbAcyclicConvolution.Text = "Ациклічна \r\nзгортка";
            this.cbAcyclicConvolution.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(726, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 504);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelResult);
            this.panel2.Controls.Add(this.labelFirstNum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelSecondNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 110);
            this.panel2.TabIndex = 19;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.Tomato;
            this.labelResult.Location = new System.Drawing.Point(71, 71);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(26, 29);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "0";
            // 
            // labelFirstNum
            // 
            this.labelFirstNum.AutoSize = true;
            this.labelFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelFirstNum.Location = new System.Drawing.Point(71, 17);
            this.labelFirstNum.Name = "labelFirstNum";
            this.labelFirstNum.Size = new System.Drawing.Size(26, 29);
            this.labelFirstNum.TabIndex = 2;
            this.labelFirstNum.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "В:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "№2 -";
            // 
            // labelSecondNum
            // 
            this.labelSecondNum.AutoSize = true;
            this.labelSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelSecondNum.Location = new System.Drawing.Point(71, 46);
            this.labelSecondNum.Name = "labelSecondNum";
            this.labelSecondNum.Size = new System.Drawing.Size(26, 29);
            this.labelSecondNum.TabIndex = 3;
            this.labelSecondNum.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "№1 -";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(0, 475);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(55, 29);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Час";
            // 
            // panelInputData
            // 
            this.panelInputData.Controls.Add(this.tbFirstNum);
            this.panelInputData.Controls.Add(this.tbSecondNum);
            this.panelInputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputData.Location = new System.Drawing.Point(0, 0);
            this.panelInputData.Name = "panelInputData";
            this.panelInputData.Size = new System.Drawing.Size(726, 132);
            this.panelInputData.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbMultiplicationResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 372);
            this.panel3.TabIndex = 15;
            // 
            // rtbMultiplicationResult
            // 
            this.rtbMultiplicationResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMultiplicationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMultiplicationResult.Location = new System.Drawing.Point(0, 0);
            this.rtbMultiplicationResult.Name = "rtbMultiplicationResult";
            this.rtbMultiplicationResult.ReadOnly = true;
            this.rtbMultiplicationResult.Size = new System.Drawing.Size(726, 372);
            this.rtbMultiplicationResult.TabIndex = 0;
            this.rtbMultiplicationResult.Text = "";
            this.rtbMultiplicationResult.TextChanged += new System.EventHandler(this.rtbMultiplicationResult_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelInputData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Множення цілих чисел методом Шенхаге-Страссена";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInputData.ResumeLayout(false);
            this.panelInputData.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNum;
        private System.Windows.Forms.TextBox tbSecondNum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbAcyclicConvolution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInputData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbMultiplicationResult;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelFirstNum;
        private System.Windows.Forms.Label labelSecondNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}

