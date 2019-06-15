namespace BilgeAdam.AsyncState
{
    partial class frmMain
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
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.btnProcess2 = new System.Windows.Forms.Button();
            this.btnProcess3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLongProcess = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcess1
            // 
            this.btnProcess1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProcess1.Location = new System.Drawing.Point(49, 40);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(97, 46);
            this.btnProcess1.TabIndex = 0;
            this.btnProcess1.Text = "İşlem 1";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnProcess2
            // 
            this.btnProcess2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProcess2.Location = new System.Drawing.Point(152, 40);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(97, 46);
            this.btnProcess2.TabIndex = 0;
            this.btnProcess2.Text = "İşlem 2";
            this.btnProcess2.UseVisualStyleBackColor = true;
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // btnProcess3
            // 
            this.btnProcess3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProcess3.Location = new System.Drawing.Point(255, 40);
            this.btnProcess3.Name = "btnProcess3";
            this.btnProcess3.Size = new System.Drawing.Size(97, 46);
            this.btnProcess3.TabIndex = 0;
            this.btnProcess3.Text = "İşlem 3";
            this.btnProcess3.UseVisualStyleBackColor = true;
            this.btnProcess3.Click += new System.EventHandler(this.btnProcess3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 92);
            this.progressBar1.Maximum = 1000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(662, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // btnLongProcess
            // 
            this.btnLongProcess.Location = new System.Drawing.Point(49, 135);
            this.btnLongProcess.Name = "btnLongProcess";
            this.btnLongProcess.Size = new System.Drawing.Size(97, 47);
            this.btnLongProcess.TabIndex = 2;
            this.btnLongProcess.Text = "Uzun İşlem";
            this.btnLongProcess.UseVisualStyleBackColor = true;
            this.btnLongProcess.Click += new System.EventHandler(this.btnLongProcess_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(152, 149);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(200, 22);
            this.txtResult.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 231);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLongProcess);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProcess3);
            this.Controls.Add(this.btnProcess2);
            this.Controls.Add(this.btnProcess1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Long Running Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.Button btnProcess2;
        private System.Windows.Forms.Button btnProcess3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLongProcess;
        private System.Windows.Forms.TextBox txtResult;
    }
}

