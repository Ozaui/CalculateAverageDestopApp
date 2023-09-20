namespace CalculateAvarageDestopApp
{
    partial class Form1
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
            this.lbl_firstExam = new System.Windows.Forms.Label();
            this.lbl_finalExam = new System.Windows.Forms.Label();
            this.txt_firstExam = new System.Windows.Forms.TextBox();
            this.txt_finalExam = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_firstExam
            // 
            this.lbl_firstExam.AutoSize = true;
            this.lbl_firstExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_firstExam.Location = new System.Drawing.Point(13, 13);
            this.lbl_firstExam.Name = "lbl_firstExam";
            this.lbl_firstExam.Size = new System.Drawing.Size(161, 20);
            this.lbl_firstExam.TabIndex = 0;
            this.lbl_firstExam.Text = "First Exam Score : ";
            // 
            // lbl_finalExam
            // 
            this.lbl_finalExam.AutoSize = true;
            this.lbl_finalExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_finalExam.Location = new System.Drawing.Point(13, 54);
            this.lbl_finalExam.Name = "lbl_finalExam";
            this.lbl_finalExam.Size = new System.Drawing.Size(164, 20);
            this.lbl_finalExam.TabIndex = 0;
            this.lbl_finalExam.Text = "Final Exam Score : ";
            // 
            // txt_firstExam
            // 
            this.txt_firstExam.Location = new System.Drawing.Point(180, 15);
            this.txt_firstExam.Name = "txt_firstExam";
            this.txt_firstExam.Size = new System.Drawing.Size(100, 20);
            this.txt_firstExam.TabIndex = 1;
            // 
            // txt_finalExam
            // 
            this.txt_finalExam.Location = new System.Drawing.Point(183, 54);
            this.txt_finalExam.Name = "txt_finalExam";
            this.txt_finalExam.Size = new System.Drawing.Size(100, 20);
            this.txt_finalExam.TabIndex = 1;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calculate.Location = new System.Drawing.Point(17, 100);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(141, 32);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_result.Location = new System.Drawing.Point(179, 106);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(14, 20);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 153);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_finalExam);
            this.Controls.Add(this.txt_firstExam);
            this.Controls.Add(this.lbl_finalExam);
            this.Controls.Add(this.lbl_firstExam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstExam;
        private System.Windows.Forms.Label lbl_finalExam;
        private System.Windows.Forms.TextBox txt_firstExam;
        private System.Windows.Forms.TextBox txt_finalExam;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_result;
    }
}

