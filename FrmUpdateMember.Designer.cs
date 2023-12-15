namespace FrmClubRegistration_Sanchez
{
    partial class FrmUpdateMember
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStudentID_ = new System.Windows.Forms.ComboBox();
            this.tbLastName_ = new System.Windows.Forms.TextBox();
            this.tbFirstName_ = new System.Windows.Forms.TextBox();
            this.tbMiddleName_ = new System.Windows.Forms.TextBox();
            this.tbAge_ = new System.Windows.Forms.TextBox();
            this.cbGender_ = new System.Windows.Forms.ComboBox();
            this.cbProgram_ = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Program:";
            // 
            // cbStudentID_
            // 
            this.cbStudentID_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbStudentID_.FormattingEnabled = true;
            this.cbStudentID_.Location = new System.Drawing.Point(16, 32);
            this.cbStudentID_.Name = "cbStudentID_";
            this.cbStudentID_.Size = new System.Drawing.Size(231, 21);
            this.cbStudentID_.TabIndex = 7;
            this.cbStudentID_.SelectedIndexChanged += new System.EventHandler(this.cbStudentID__SelectedIndexChanged);
            // 
            // tbLastName_
            // 
            this.tbLastName_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLastName_.Location = new System.Drawing.Point(16, 79);
            this.tbLastName_.Name = "tbLastName_";
            this.tbLastName_.Size = new System.Drawing.Size(206, 20);
            this.tbLastName_.TabIndex = 8;
            // 
            // tbFirstName_
            // 
            this.tbFirstName_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbFirstName_.Location = new System.Drawing.Point(16, 126);
            this.tbFirstName_.Name = "tbFirstName_";
            this.tbFirstName_.Size = new System.Drawing.Size(206, 20);
            this.tbFirstName_.TabIndex = 9;
            // 
            // tbMiddleName_
            // 
            this.tbMiddleName_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbMiddleName_.Location = new System.Drawing.Point(16, 173);
            this.tbMiddleName_.Name = "tbMiddleName_";
            this.tbMiddleName_.Size = new System.Drawing.Size(206, 20);
            this.tbMiddleName_.TabIndex = 10;
            // 
            // tbAge_
            // 
            this.tbAge_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAge_.Location = new System.Drawing.Point(16, 219);
            this.tbAge_.Name = "tbAge_";
            this.tbAge_.Size = new System.Drawing.Size(134, 20);
            this.tbAge_.TabIndex = 11;
            // 
            // cbGender_
            // 
            this.cbGender_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbGender_.FormattingEnabled = true;
            this.cbGender_.Location = new System.Drawing.Point(16, 265);
            this.cbGender_.Name = "cbGender_";
            this.cbGender_.Size = new System.Drawing.Size(160, 21);
            this.cbGender_.TabIndex = 12;
            // 
            // cbProgram_
            // 
            this.cbProgram_.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbProgram_.FormattingEnabled = true;
            this.cbProgram_.Location = new System.Drawing.Point(16, 312);
            this.cbProgram_.Name = "cbProgram_";
            this.cbProgram_.Size = new System.Drawing.Size(231, 21);
            this.cbProgram_.TabIndex = 13;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Peru;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(84, 354);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(102, 33);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(273, 407);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbProgram_);
            this.Controls.Add(this.cbGender_);
            this.Controls.Add(this.tbAge_);
            this.Controls.Add(this.tbMiddleName_);
            this.Controls.Add(this.tbFirstName_);
            this.Controls.Add(this.tbLastName_);
            this.Controls.Add(this.cbStudentID_);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStudentID_;
        private System.Windows.Forms.TextBox tbLastName_;
        private System.Windows.Forms.TextBox tbFirstName_;
        private System.Windows.Forms.TextBox tbMiddleName_;
        private System.Windows.Forms.TextBox tbAge_;
        private System.Windows.Forms.ComboBox cbGender_;
        private System.Windows.Forms.ComboBox cbProgram_;
        private System.Windows.Forms.Button btnConfirm;
    }
}