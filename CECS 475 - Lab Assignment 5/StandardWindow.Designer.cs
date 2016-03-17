namespace CECS_475___Lab_Assignment_5
{
    partial class StandardWindow
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.radioBtnSearchByName = new System.Windows.Forms.RadioButton();
            this.radioBtnSearchById = new System.Windows.Forms.RadioButton();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.radioBtnUpdate = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.checkBoxRelatedStudents = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(570, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 69);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.BackColor = System.Drawing.Color.White;
            this.outputTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 162);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(738, 395);
            this.outputTextBox.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(284, 563);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(182, 68);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(570, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 69);
            this.btnClear.TabIndex = 15;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.radioBtnSearchByName);
            this.groupBoxMenu.Controls.Add(this.radioBtnSearchById);
            this.groupBoxMenu.Controls.Add(this.radioBtnDelete);
            this.groupBoxMenu.Controls.Add(this.radioBtnUpdate);
            this.groupBoxMenu.Controls.Add(this.radioBtnAdd);
            this.groupBoxMenu.Location = new System.Drawing.Point(13, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(281, 111);
            this.groupBoxMenu.TabIndex = 16;
            this.groupBoxMenu.TabStop = false;
            // 
            // radioBtnSearchByName
            // 
            this.radioBtnSearchByName.AutoSize = true;
            this.radioBtnSearchByName.Location = new System.Drawing.Point(118, 43);
            this.radioBtnSearchByName.Name = "radioBtnSearchByName";
            this.radioBtnSearchByName.Size = new System.Drawing.Size(153, 24);
            this.radioBtnSearchByName.TabIndex = 4;
            this.radioBtnSearchByName.TabStop = true;
            this.radioBtnSearchByName.Text = "Search By Name";
            this.radioBtnSearchByName.UseVisualStyleBackColor = true;
            this.radioBtnSearchByName.Click += new System.EventHandler(this.radioBtnSearchByName_Click);
            // 
            // radioBtnSearchById
            // 
            this.radioBtnSearchById.AutoSize = true;
            this.radioBtnSearchById.Location = new System.Drawing.Point(118, 13);
            this.radioBtnSearchById.Name = "radioBtnSearchById";
            this.radioBtnSearchById.Size = new System.Drawing.Size(128, 24);
            this.radioBtnSearchById.TabIndex = 3;
            this.radioBtnSearchById.TabStop = true;
            this.radioBtnSearchById.Text = "Search By ID";
            this.radioBtnSearchById.UseVisualStyleBackColor = true;
            this.radioBtnSearchById.Click += new System.EventHandler(this.radioBtnSearchById_Click);
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Location = new System.Drawing.Point(7, 75);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(81, 24);
            this.radioBtnDelete.TabIndex = 2;
            this.radioBtnDelete.TabStop = true;
            this.radioBtnDelete.Text = "Delete";
            this.radioBtnDelete.UseVisualStyleBackColor = true;
            this.radioBtnDelete.Click += new System.EventHandler(this.radioBtnDelete_Click);
            // 
            // radioBtnUpdate
            // 
            this.radioBtnUpdate.AutoSize = true;
            this.radioBtnUpdate.Location = new System.Drawing.Point(7, 45);
            this.radioBtnUpdate.Name = "radioBtnUpdate";
            this.radioBtnUpdate.Size = new System.Drawing.Size(87, 24);
            this.radioBtnUpdate.TabIndex = 1;
            this.radioBtnUpdate.TabStop = true;
            this.radioBtnUpdate.Text = "Update";
            this.radioBtnUpdate.UseVisualStyleBackColor = true;
            this.radioBtnUpdate.Click += new System.EventHandler(this.radioBtnUpdate_Click);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(7, 13);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(63, 24);
            this.radioBtnAdd.TabIndex = 0;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Add";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.Click += new System.EventHandler(this.radioBtnAdd_Click);
            // 
            // checkBoxRelatedStudents
            // 
            this.checkBoxRelatedStudents.AutoSize = true;
            this.checkBoxRelatedStudents.Location = new System.Drawing.Point(20, 129);
            this.checkBoxRelatedStudents.Name = "checkBoxRelatedStudents";
            this.checkBoxRelatedStudents.Size = new System.Drawing.Size(215, 24);
            this.checkBoxRelatedStudents.TabIndex = 17;
            this.checkBoxRelatedStudents.Text = "Display Related Students";
            this.checkBoxRelatedStudents.UseVisualStyleBackColor = true;
            this.checkBoxRelatedStudents.Click += new System.EventHandler(this.checkBoxRelatedStudents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(399, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 26);
            this.txtId.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(399, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 26);
            this.txtName.TabIndex = 22;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(399, 97);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(153, 56);
            this.txtDescription.TabIndex = 23;
            // 
            // StandardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 643);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxRelatedStudents);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StandardWindow";
            this.Text = "Standard Window";
            this.Load += new System.EventHandler(this.StandardWindow_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.RadioButton radioBtnSearchByName;
        private System.Windows.Forms.RadioButton radioBtnSearchById;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.RadioButton radioBtnUpdate;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.CheckBox checkBoxRelatedStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
    }
}