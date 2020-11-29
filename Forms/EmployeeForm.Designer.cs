namespace Zachary_Childers_CPT_185_Lab_10__10_4_
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.empBox = new System.Windows.Forms.GroupBox();
            this.txtRate_Input = new System.Windows.Forms.TextBox();
            this.txtEmployee_ID_Input = new System.Windows.Forms.TextBox();
            this.txtEmployeeInput = new System.Windows.Forms.TextBox();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txt_gross_pay = new System.Windows.Forms.TextBox();
            this.txtEmployee_id_output = new System.Windows.Forms.TextBox();
            this.txtEmployeeOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalc = new FontAwesome.Sharp.IconButton();
            this.btnClr = new FontAwesome.Sharp.IconButton();
            this.btnExt = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.empBox.SuspendLayout();
            this.sumBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // empBox
            // 
            this.empBox.Controls.Add(this.txtRate_Input);
            this.empBox.Controls.Add(this.txtEmployee_ID_Input);
            this.empBox.Controls.Add(this.txtEmployeeInput);
            this.empBox.Controls.Add(this.rd2);
            this.empBox.Controls.Add(this.rd1);
            this.empBox.Controls.Add(this.label4);
            this.empBox.Controls.Add(this.label3);
            this.empBox.Controls.Add(this.label2);
            this.empBox.Controls.Add(this.label1);
            this.empBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBox.Location = new System.Drawing.Point(12, 49);
            this.empBox.Name = "empBox";
            this.empBox.Size = new System.Drawing.Size(429, 300);
            this.empBox.TabIndex = 0;
            this.empBox.TabStop = false;
            this.empBox.Text = "Employee";
            // 
            // txtRate_Input
            // 
            this.txtRate_Input.Location = new System.Drawing.Point(162, 129);
            this.txtRate_Input.Name = "txtRate_Input";
            this.txtRate_Input.Size = new System.Drawing.Size(103, 27);
            this.txtRate_Input.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtRate_Input, "Hourly Rate, Ex. 9.25");
            // 
            // txtEmployee_ID_Input
            // 
            this.txtEmployee_ID_Input.Location = new System.Drawing.Point(162, 96);
            this.txtEmployee_ID_Input.Name = "txtEmployee_ID_Input";
            this.txtEmployee_ID_Input.Size = new System.Drawing.Size(176, 27);
            this.txtEmployee_ID_Input.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtEmployee_ID_Input, "Enter your unique Employee ID");
            // 
            // txtEmployeeInput
            // 
            this.txtEmployeeInput.Location = new System.Drawing.Point(162, 63);
            this.txtEmployeeInput.Name = "txtEmployeeInput";
            this.txtEmployeeInput.Size = new System.Drawing.Size(176, 27);
            this.txtEmployeeInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtEmployeeInput, "Enter your name");
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(250, 252);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(101, 24);
            this.rd2.TabIndex = 4;
            this.rd2.TabStop = true;
            this.rd2.Text = "Night Shift";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(66, 252);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(89, 24);
            this.rd1.TabIndex = 3;
            this.rd1.TabStop = true;
            this.rd1.Text = "Day Shift";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shift Worked";
            this.toolTip1.SetToolTip(this.label4, "Day or Night Shift");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Pay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // sumBox
            // 
            this.sumBox.Controls.Add(this.label6);
            this.sumBox.Controls.Add(this.label7);
            this.sumBox.Controls.Add(this.txtShift);
            this.sumBox.Controls.Add(this.txt_gross_pay);
            this.sumBox.Controls.Add(this.txtEmployee_id_output);
            this.sumBox.Controls.Add(this.txtEmployeeOutput);
            this.sumBox.Controls.Add(this.label8);
            this.sumBox.Controls.Add(this.label5);
            this.sumBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumBox.Location = new System.Drawing.Point(509, 49);
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(427, 300);
            this.sumBox.TabIndex = 1;
            this.sumBox.TabStop = false;
            this.sumBox.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employee Name:";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(203, 195);
            this.txtShift.Name = "txtShift";
            this.txtShift.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(62, 27);
            this.txtShift.TabIndex = 12;
            this.txtShift.TabStop = false;
            // 
            // txt_gross_pay
            // 
            this.txt_gross_pay.Location = new System.Drawing.Point(194, 126);
            this.txt_gross_pay.Name = "txt_gross_pay";
            this.txt_gross_pay.ReadOnly = true;
            this.txt_gross_pay.Size = new System.Drawing.Size(138, 27);
            this.txt_gross_pay.TabIndex = 11;
            this.txt_gross_pay.TabStop = false;
            this.toolTip1.SetToolTip(this.txt_gross_pay, "Pay x 40 Hours");
            // 
            // txtEmployee_id_output
            // 
            this.txtEmployee_id_output.Location = new System.Drawing.Point(194, 93);
            this.txtEmployee_id_output.Name = "txtEmployee_id_output";
            this.txtEmployee_id_output.ReadOnly = true;
            this.txtEmployee_id_output.Size = new System.Drawing.Size(178, 27);
            this.txtEmployee_id_output.TabIndex = 10;
            this.txtEmployee_id_output.TabStop = false;
            // 
            // txtEmployeeOutput
            // 
            this.txtEmployeeOutput.Location = new System.Drawing.Point(194, 60);
            this.txtEmployeeOutput.Name = "txtEmployeeOutput";
            this.txtEmployeeOutput.ReadOnly = true;
            this.txtEmployeeOutput.Size = new System.Drawing.Size(178, 27);
            this.txtEmployeeOutput.TabIndex = 9;
            this.txtEmployeeOutput.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Shift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gross Pay (40 hours):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(331, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Employee Summary Program";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnCalc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalc.IconSize = 30;
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalc.Location = new System.Drawing.Point(100, 435);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalc.Size = new System.Drawing.Size(158, 50);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.TabStop = false;
            this.btnCalc.Text = "Dis&play Total";
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnCalc, "Calculate your Paycheck");
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClr
            // 
            this.btnClr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClr.FlatAppearance.BorderSize = 0;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            this.btnClr.IconColor = System.Drawing.Color.White;
            this.btnClr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClr.IconSize = 30;
            this.btnClr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClr.Location = new System.Drawing.Point(371, 435);
            this.btnClr.Name = "btnClr";
            this.btnClr.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClr.Size = new System.Drawing.Size(158, 50);
            this.btnClr.TabIndex = 1;
            this.btnClr.Text = "&Clear";
            this.btnClr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnClr, "Clear for Next Employee");
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnExt
            // 
            this.btnExt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.Color.White;
            this.btnExt.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.btnExt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExt.IconSize = 30;
            this.btnExt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExt.Location = new System.Drawing.Point(631, 435);
            this.btnExt.Name = "btnExt";
            this.btnExt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExt.Size = new System.Drawing.Size(158, 50);
            this.btnExt.TabIndex = 2;
            this.btnExt.Text = "&Exit";
            this.btnExt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnExt, "Exit for the Day");
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 96);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 34);
            this.panel2.TabIndex = 9;
            // 
            // EmployeeForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClr;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.empBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.empBox.ResumeLayout(false);
            this.empBox.PerformLayout();
            this.sumBox.ResumeLayout(false);
            this.sumBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox empBox;
        private System.Windows.Forms.TextBox txtRate_Input;
        private System.Windows.Forms.TextBox txtEmployee_ID_Input;
        private System.Windows.Forms.TextBox txtEmployeeInput;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sumBox;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txt_gross_pay;
        private System.Windows.Forms.TextBox txtEmployee_id_output;
        private System.Windows.Forms.TextBox txtEmployeeOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnCalc;
        private FontAwesome.Sharp.IconButton btnClr;
        private FontAwesome.Sharp.IconButton btnExt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}