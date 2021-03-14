
namespace _101062225_eventManagement_project
{
    partial class Event_Form
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
            this.btnEventSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEventSearch = new System.Windows.Forms.TextBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btnEventReset = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.btnEventSave = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventSearch
            // 
            this.btnEventSearch.BackColor = System.Drawing.Color.Gold;
            this.btnEventSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEventSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEventSearch.Location = new System.Drawing.Point(930, 70);
            this.btnEventSearch.Name = "btnEventSearch";
            this.btnEventSearch.Size = new System.Drawing.Size(174, 38);
            this.btnEventSearch.TabIndex = 14;
            this.btnEventSearch.Text = "SEARCH OR VIEW";
            this.btnEventSearch.UseVisualStyleBackColor = false;
            this.btnEventSearch.Click += new System.EventHandler(this.BtnEventSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add An Event ";
            // 
            // txtEventSearch
            // 
            this.txtEventSearch.Location = new System.Drawing.Point(388, 81);
            this.txtEventSearch.Name = "txtEventSearch";
            this.txtEventSearch.Size = new System.Drawing.Size(523, 27);
            this.txtEventSearch.TabIndex = 13;
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(388, 114);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 29;
            this.dgvEvents.Size = new System.Drawing.Size(716, 348);
            this.dgvEvents.TabIndex = 11;
            this.dgvEvents.DoubleClick += new System.EventHandler(this.DgvEvents_DoubleClick);
            // 
            // btnEventReset
            // 
            this.btnEventReset.BackColor = System.Drawing.Color.Gold;
            this.btnEventReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEventReset.Location = new System.Drawing.Point(259, 271);
            this.btnEventReset.Name = "btnEventReset";
            this.btnEventReset.Size = new System.Drawing.Size(123, 38);
            this.btnEventReset.TabIndex = 8;
            this.btnEventReset.Text = "RESET";
            this.btnEventReset.UseVisualStyleBackColor = false;
            this.btnEventReset.Click += new System.EventHandler(this.BtnEventReset_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(151, 94);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(198, 27);
            this.txtEventName.TabIndex = 3;
            this.txtEventName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEventName_Validatin);
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(151, 134);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(198, 27);
            this.txtEventDate.TabIndex = 1;
            this.txtEventDate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDate_Validating);
            // 
            // btnEventSave
            // 
            this.btnEventSave.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEventSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEventSave.Location = new System.Drawing.Point(0, 271);
            this.btnEventSave.Name = "btnEventSave";
            this.btnEventSave.Size = new System.Drawing.Size(135, 38);
            this.btnEventSave.TabIndex = 15;
            this.btnEventSave.Text = "Add";
            this.btnEventSave.UseVisualStyleBackColor = false;
            this.btnEventSave.Click += new System.EventHandler(this.BtnEventSave_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(31, 94);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(89, 20);
            this.lblEventName.TabIndex = 16;
            this.lblEventName.Text = "Event Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Event Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "People Attending";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(23, 212);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(89, 20);
            this.lblVenue.TabIndex = 19;
            this.lblVenue.Text = "Event Venue";
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(151, 167);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(198, 27);
            this.txtPeople.TabIndex = 20;
            this.txtPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeople_KeyPress);
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(151, 212);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(198, 27);
            this.txtVenue.TabIndex = 21;
            this.txtVenue.Validating += new System.ComponentModel.CancelEventHandler(this.TxtVenue_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(146, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "*Double tap Grid to edit an Event*";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Lime;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(1104, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(127, 43);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "NEXT ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 43);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "BACK ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEventDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEventDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEventDelete.Location = new System.Drawing.Point(141, 271);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(112, 38);
            this.btnEventDelete.TabIndex = 26;
            this.btnEventDelete.Text = "DELETE";
            this.btnEventDelete.UseVisualStyleBackColor = false;
            this.btnEventDelete.Click += new System.EventHandler(this.BtnEventDelete_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(388, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "*Search By Event Name or Click to View";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Event_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEventDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnEventSave);
            this.Controls.Add(this.btnEventReset);
            this.Controls.Add(this.btnEventSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtEventSearch);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.dgvEvents);
            this.Name = "Event_Form";
            this.Text = "Event_Form";
            this.Load += new System.EventHandler(this.Event_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEventSearch;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnEventReset;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Button btnEventSave;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}