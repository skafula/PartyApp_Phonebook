namespace Party_App_WF
{
    partial class MainForm
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
            this.lbPhoneBook = new System.Windows.Forms.ListBox();
            this.btnShowPhoneBook = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSurpDef = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.listboxGuestList = new System.Windows.Forms.ListBox();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.tbFeePerPerson = new System.Windows.Forms.TextBox();
            this.tbCostPerPerson = new System.Windows.Forms.TextBox();
            this.tbMaxGuests = new System.Windows.Forms.TextBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpAddGuests.SuspendLayout();
            this.grpNewParty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPhoneBook
            // 
            this.lbPhoneBook.BackColor = System.Drawing.Color.Bisque;
            this.lbPhoneBook.FormattingEnabled = true;
            this.lbPhoneBook.Location = new System.Drawing.Point(15, 47);
            this.lbPhoneBook.Name = "lbPhoneBook";
            this.lbPhoneBook.Size = new System.Drawing.Size(230, 147);
            this.lbPhoneBook.TabIndex = 0;
            // 
            // btnShowPhoneBook
            // 
            this.btnShowPhoneBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnShowPhoneBook.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnShowPhoneBook.Location = new System.Drawing.Point(85, 200);
            this.btnShowPhoneBook.Name = "btnShowPhoneBook";
            this.btnShowPhoneBook.Size = new System.Drawing.Size(90, 30);
            this.btnShowPhoneBook.TabIndex = 1;
            this.btnShowPhoneBook.Text = "Show List";
            this.btnShowPhoneBook.UseVisualStyleBackColor = false;
            this.btnShowPhoneBook.Click += new System.EventHandler(this.btnShowPhoneBook_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrderList.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnOrderList.Location = new System.Drawing.Point(85, 235);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(90, 30);
            this.btnOrderList.TabIndex = 2;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = false;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbPhoneBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderList);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowPhoneBook);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(51)))));
            this.splitContainer1.Panel2.Controls.Add(this.lblSurpDef);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalFees);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalCost);
            this.splitContainer1.Panel2.Controls.Add(this.lblNumOfGuests);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.lblGuestList);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnChange);
            this.splitContainer1.Panel2.Controls.Add(this.listboxGuestList);
            this.splitContainer1.Panel2.Controls.Add(this.grpAddGuests);
            this.splitContainer1.Panel2.Controls.Add(this.grpNewParty);
            this.splitContainer1.Size = new System.Drawing.Size(776, 519);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Book App";
            // 
            // lblSurpDef
            // 
            this.lblSurpDef.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblSurpDef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurpDef.Location = new System.Drawing.Point(134, 448);
            this.lblSurpDef.Name = "lblSurpDef";
            this.lblSurpDef.Size = new System.Drawing.Size(110, 20);
            this.lblSurpDef.TabIndex = 13;
            this.lblSurpDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(134, 418);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(110, 20);
            this.lblTotalFees.TabIndex = 12;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(134, 388);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(110, 20);
            this.lblTotalCost.TabIndex = 11;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNumOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfGuests.Location = new System.Drawing.Point(134, 358);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(110, 20);
            this.lblNumOfGuests.TabIndex = 10;
            this.lblNumOfGuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Surplus/deficit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Number of guests";
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGuestList.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGuestList.Location = new System.Drawing.Point(344, 14);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(85, 18);
            this.lblGuestList.TabIndex = 5;
            this.lblGuestList.Text = "Guest List";
            this.lblGuestList.Click += new System.EventHandler(this.lblGuestList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(401, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.PeachPuff;
            this.btnChange.Enabled = false;
            this.btnChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChange.Location = new System.Drawing.Point(290, 415);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // listboxGuestList
            // 
            this.listboxGuestList.BackColor = System.Drawing.Color.NavajoWhite;
            this.listboxGuestList.FormattingEnabled = true;
            this.listboxGuestList.Location = new System.Drawing.Point(272, 36);
            this.listboxGuestList.Name = "listboxGuestList";
            this.listboxGuestList.Size = new System.Drawing.Size(221, 368);
            this.listboxGuestList.TabIndex = 2;
            this.listboxGuestList.SelectedIndexChanged += new System.EventHandler(this.listboxGuestList_SelectedIndexChanged);
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.tbLastName);
            this.grpAddGuests.Controls.Add(this.tbFirstName);
            this.grpAddGuests.Controls.Add(this.btnAddToList);
            this.grpAddGuests.Controls.Add(this.label6);
            this.grpAddGuests.Controls.Add(this.label5);
            this.grpAddGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpAddGuests.ForeColor = System.Drawing.Color.GreenYellow;
            this.grpAddGuests.Location = new System.Drawing.Point(4, 187);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Size = new System.Drawing.Size(253, 140);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Invite Guest";
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbLastName.Location = new System.Drawing.Point(110, 70);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(130, 24);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbFirstName.Location = new System.Drawing.Point(110, 35);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(130, 24);
            this.tbFirstName.TabIndex = 3;
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAddToList.Enabled = false;
            this.btnAddToList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToList.Location = new System.Drawing.Point(84, 104);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(100, 30);
            this.btnAddToList.TabIndex = 2;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name";
            // 
            // grpNewParty
            // 
            this.grpNewParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(113)))), ((int)(((byte)(51)))));
            this.grpNewParty.Controls.Add(this.tbFeePerPerson);
            this.grpNewParty.Controls.Add(this.tbCostPerPerson);
            this.grpNewParty.Controls.Add(this.tbMaxGuests);
            this.grpNewParty.Controls.Add(this.btnCreateList);
            this.grpNewParty.Controls.Add(this.label4);
            this.grpNewParty.Controls.Add(this.label3);
            this.grpNewParty.Controls.Add(this.label2);
            this.grpNewParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpNewParty.ForeColor = System.Drawing.Color.GreenYellow;
            this.grpNewParty.Location = new System.Drawing.Point(4, 4);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(253, 177);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // tbFeePerPerson
            // 
            this.tbFeePerPerson.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbFeePerPerson.Location = new System.Drawing.Point(160, 105);
            this.tbFeePerPerson.Name = "tbFeePerPerson";
            this.tbFeePerPerson.Size = new System.Drawing.Size(80, 24);
            this.tbFeePerPerson.TabIndex = 6;
            // 
            // tbCostPerPerson
            // 
            this.tbCostPerPerson.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbCostPerPerson.Location = new System.Drawing.Point(160, 70);
            this.tbCostPerPerson.Name = "tbCostPerPerson";
            this.tbCostPerPerson.Size = new System.Drawing.Size(80, 24);
            this.tbCostPerPerson.TabIndex = 5;
            // 
            // tbMaxGuests
            // 
            this.tbMaxGuests.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbMaxGuests.Location = new System.Drawing.Point(160, 35);
            this.tbMaxGuests.Name = "tbMaxGuests";
            this.tbMaxGuests.Size = new System.Drawing.Size(80, 24);
            this.tbMaxGuests.TabIndex = 4;
            // 
            // btnCreateList
            // 
            this.btnCreateList.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCreateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateList.Location = new System.Drawing.Point(84, 141);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(100, 30);
            this.btnCreateList.TabIndex = 3;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = false;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fee per person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cost per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max number of guests";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpAddGuests.ResumeLayout(false);
            this.grpAddGuests.PerformLayout();
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPhoneBook;
        private System.Windows.Forms.Button btnShowPhoneBook;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSurpDef;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGuestList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox listboxGuestList;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.TextBox tbFeePerPerson;
        private System.Windows.Forms.TextBox tbCostPerPerson;
        private System.Windows.Forms.TextBox tbMaxGuests;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

