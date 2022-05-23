namespace Praktikum13
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.tBox_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dt_birthday = new System.Windows.Forms.DateTimePicker();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.cb_Nationality = new System.Windows.Forms.ComboBox();
            this.lb_availability = new System.Windows.Forms.Label();
            this.numericUpDown_Teamnumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Teamnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(70, 12);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(90, 57);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(185, 12);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(86, 57);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(290, 12);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 57);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(397, 12);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(91, 57);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(82, 337);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(178, 35);
            this.btn_save.TabIndex = 77;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(185, 134);
            this.tBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(269, 26);
            this.tBox_Name.TabIndex = 72;
            // 
            // tBox_ID
            // 
            this.tBox_ID.Location = new System.Drawing.Point(185, 94);
            this.tBox_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_ID.Name = "tBox_ID";
            this.tBox_ID.Size = new System.Drawing.Size(148, 26);
            this.tBox_ID.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Team Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "BirthDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Player Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Player ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(311, 337);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(177, 35);
            this.btn_cancel.TabIndex = 78;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dt_birthday
            // 
            this.dt_birthday.Location = new System.Drawing.Point(185, 174);
            this.dt_birthday.Name = "dt_birthday";
            this.dt_birthday.Size = new System.Drawing.Size(303, 26);
            this.dt_birthday.TabIndex = 79;
            // 
            // cb_Team
            // 
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Location = new System.Drawing.Point(185, 251);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(269, 28);
            this.cb_Team.TabIndex = 80;
            this.cb_Team.SelectedIndexChanged += new System.EventHandler(this.cb_Team_SelectedIndexChanged);
            // 
            // cb_Nationality
            // 
            this.cb_Nationality.FormattingEnabled = true;
            this.cb_Nationality.Location = new System.Drawing.Point(185, 211);
            this.cb_Nationality.Name = "cb_Nationality";
            this.cb_Nationality.Size = new System.Drawing.Size(269, 28);
            this.cb_Nationality.TabIndex = 82;
            this.cb_Nationality.SelectedIndexChanged += new System.EventHandler(this.cb_Nationality_SelectedIndexChanged);
            // 
            // lb_availability
            // 
            this.lb_availability.AutoSize = true;
            this.lb_availability.Location = new System.Drawing.Point(363, 300);
            this.lb_availability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_availability.Name = "lb_availability";
            this.lb_availability.Size = new System.Drawing.Size(81, 20);
            this.lb_availability.TabIndex = 83;
            this.lb_availability.Text = "Availability";
            // 
            // numericUpDown_Teamnumber
            // 
            this.numericUpDown_Teamnumber.Location = new System.Drawing.Point(185, 294);
            this.numericUpDown_Teamnumber.Name = "numericUpDown_Teamnumber";
            this.numericUpDown_Teamnumber.Size = new System.Drawing.Size(159, 26);
            this.numericUpDown_Teamnumber.TabIndex = 85;
            this.numericUpDown_Teamnumber.ValueChanged += new System.EventHandler(this.numericUpDown_Teamnumber_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 403);
            this.Controls.Add(this.numericUpDown_Teamnumber);
            this.Controls.Add(this.lb_availability);
            this.Controls.Add(this.cb_Nationality);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.dt_birthday);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.tBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Teamnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.TextBox tBox_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dt_birthday;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.ComboBox cb_Nationality;
        private System.Windows.Forms.Label lb_availability;
        private System.Windows.Forms.NumericUpDown numericUpDown_Teamnumber;
    }
}

