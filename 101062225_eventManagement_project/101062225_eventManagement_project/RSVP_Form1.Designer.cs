
namespace _101062225_eventManagement_project
{
    partial class RSVP_Form1
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
            this.btnRsave = new System.Windows.Forms.Button();
            this.cbxFname = new System.Windows.Forms.ComboBox();
            this.cbxLname = new System.Windows.Forms.ComboBox();
            this.cbxBooking = new System.Windows.Forms.ComboBox();
            this.cbxEvent = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRreset = new System.Windows.Forms.Button();
            this.btnRdelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.cbxFirst = new System.Windows.Forms.ComboBox();
            this.cbxLast = new System.Windows.Forms.ComboBox();
            this.cbxBook = new System.Windows.Forms.ComboBox();
            this.cbxEvt = new System.Windows.Forms.ComboBox();
            this.btnRSVPsearch = new System.Windows.Forms.Button();
            this.txtRSVPsearch = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.dgvRSVP = new System.Windows.Forms.DataGridView();
            this.btn_GetEvent = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRsave
            // 
            this.btnRsave.Location = new System.Drawing.Point(-57, 317);
            this.btnRsave.Name = "btnRsave";
            this.btnRsave.Size = new System.Drawing.Size(10, 10);
            this.btnRsave.TabIndex = 32;
            this.btnRsave.Text = "SAVE";
            this.btnRsave.UseVisualStyleBackColor = true;
            // 
            // cbxFname
            // 
            this.cbxFname.FormattingEnabled = true;
            this.cbxFname.Location = new System.Drawing.Point(-146, 171);
            this.cbxFname.Name = "cbxFname";
            this.cbxFname.Size = new System.Drawing.Size(10, 28);
            this.cbxFname.TabIndex = 28;
            this.cbxFname.Text = "First Name";
            // 
            // cbxLname
            // 
            this.cbxLname.FormattingEnabled = true;
            this.cbxLname.Location = new System.Drawing.Point(-146, 259);
            this.cbxLname.Name = "cbxLname";
            this.cbxLname.Size = new System.Drawing.Size(10, 28);
            this.cbxLname.TabIndex = 27;
            this.cbxLname.Text = "Last Name ";
            // 
            // cbxBooking
            // 
            this.cbxBooking.FormattingEnabled = true;
            this.cbxBooking.Location = new System.Drawing.Point(-146, 210);
            this.cbxBooking.Name = "cbxBooking";
            this.cbxBooking.Size = new System.Drawing.Size(10, 28);
            this.cbxBooking.TabIndex = 26;
            this.cbxBooking.Text = "Booking ID...";
            // 
            // cbxEvent
            // 
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.Location = new System.Drawing.Point(-146, 132);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.Size = new System.Drawing.Size(10, 28);
            this.cbxEvent.TabIndex = 25;
            this.cbxEvent.Text = "Click Button to display event...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnRreset);
            this.panel1.Controls.Add(this.btnRdelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Controls.Add(this.txtEvent);
            this.panel1.Controls.Add(this.txtbook);
            this.panel1.Controls.Add(this.cbxFirst);
            this.panel1.Controls.Add(this.cbxLast);
            this.panel1.Controls.Add(this.cbxBook);
            this.panel1.Controls.Add(this.cbxEvt);
            this.panel1.Controls.Add(this.btnRSVPsearch);
            this.panel1.Controls.Add(this.txtRSVPsearch);
            this.panel1.Controls.Add(this.txtlast);
            this.panel1.Controls.Add(this.dgvRSVP);
            this.panel1.Controls.Add(this.btn_GetEvent);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 531);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(451, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "*Search By First Name or Click to View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(209, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "*Double tap Grid to edit a RSVP*";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 43);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Lime;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(954, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 44);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnRreset
            // 
            this.btnRreset.BackColor = System.Drawing.Color.Gold;
            this.btnRreset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRreset.Location = new System.Drawing.Point(305, 322);
            this.btnRreset.Name = "btnRreset";
            this.btnRreset.Size = new System.Drawing.Size(140, 39);
            this.btnRreset.TabIndex = 34;
            this.btnRreset.Text = "RESET";
            this.btnRreset.UseVisualStyleBackColor = false;
            this.btnRreset.Click += new System.EventHandler(this.BtnRreset_Click);
            // 
            // btnRdelete
            // 
            this.btnRdelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRdelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRdelete.Location = new System.Drawing.Point(146, 322);
            this.btnRdelete.Name = "btnRdelete";
            this.btnRdelete.Size = new System.Drawing.Size(140, 39);
            this.btnRdelete.TabIndex = 33;
            this.btnRdelete.Text = "DELETE";
            this.btnRdelete.UseVisualStyleBackColor = false;
            this.btnRdelete.Click += new System.EventHandler(this.BtnRdelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(0, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 39);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnRsave_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(234, 182);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(188, 27);
            this.txtFirst.TabIndex = 31;
            this.txtFirst.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFirst_Validating);
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(234, 141);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(188, 27);
            this.txtEvent.TabIndex = 30;
            this.txtEvent.Validating += new System.ComponentModel.CancelEventHandler(this.TxteEvent_Validating);
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(236, 218);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(188, 27);
            this.txtbook.TabIndex = 29;
            this.txtbook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBook_KeyPress);
            // 
            // cbxFirst
            // 
            this.cbxFirst.FormattingEnabled = true;
            this.cbxFirst.Location = new System.Drawing.Point(23, 181);
            this.cbxFirst.Name = "cbxFirst";
            this.cbxFirst.Size = new System.Drawing.Size(207, 28);
            this.cbxFirst.TabIndex = 28;
            this.cbxFirst.Text = "First Name";
            this.cbxFirst.SelectedIndexChanged += new System.EventHandler(this.CbxFname_SelectedIndexChanged);
            // 
            // cbxLast
            // 
            this.cbxLast.FormattingEnabled = true;
            this.cbxLast.Location = new System.Drawing.Point(23, 266);
            this.cbxLast.Name = "cbxLast";
            this.cbxLast.Size = new System.Drawing.Size(207, 28);
            this.cbxLast.TabIndex = 27;
            this.cbxLast.Text = "Last Name ";
            this.cbxLast.SelectedIndexChanged += new System.EventHandler(this.CbxLname_SelectedIndexChanged);
            // 
            // cbxBook
            // 
            this.cbxBook.FormattingEnabled = true;
            this.cbxBook.Location = new System.Drawing.Point(23, 217);
            this.cbxBook.Name = "cbxBook";
            this.cbxBook.Size = new System.Drawing.Size(207, 28);
            this.cbxBook.TabIndex = 26;
            this.cbxBook.Text = "Booking ID...";
            this.cbxBook.SelectedIndexChanged += new System.EventHandler(this.CbxBooking_SelectedIndexChanged);
            // 
            // cbxEvt
            // 
            this.cbxEvt.FormattingEnabled = true;
            this.cbxEvt.Location = new System.Drawing.Point(23, 140);
            this.cbxEvt.Name = "cbxEvt";
            this.cbxEvt.Size = new System.Drawing.Size(207, 28);
            this.cbxEvt.TabIndex = 25;
            this.cbxEvt.Text = "Click Button to display event...";
            this.cbxEvt.SelectedIndexChanged += new System.EventHandler(this.Btn_GetEvent_SelectedIndexChanged);
            // 
            // btnRSVPsearch
            // 
            this.btnRSVPsearch.BackColor = System.Drawing.Color.Gold;
            this.btnRSVPsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRSVPsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRSVPsearch.Location = new System.Drawing.Point(898, 94);
            this.btnRSVPsearch.Name = "btnRSVPsearch";
            this.btnRSVPsearch.Size = new System.Drawing.Size(179, 37);
            this.btnRSVPsearch.TabIndex = 24;
            this.btnRSVPsearch.Text = "SEARCH OR VIEW";
            this.btnRSVPsearch.UseVisualStyleBackColor = false;
            this.btnRSVPsearch.Click += new System.EventHandler(this.BtnRSVPsearch_Click);
            // 
            // txtRSVPsearch
            // 
            this.txtRSVPsearch.Location = new System.Drawing.Point(451, 100);
            this.txtRSVPsearch.Name = "txtRSVPsearch";
            this.txtRSVPsearch.Size = new System.Drawing.Size(441, 27);
            this.txtRSVPsearch.TabIndex = 23;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(236, 266);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(188, 27);
            this.txtlast.TabIndex = 22;
            this.txtlast.Validating += new System.ComponentModel.CancelEventHandler(this.Txtlast_Validating);
            // 
            // dgvRSVP
            // 
            this.dgvRSVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRSVP.Location = new System.Drawing.Point(451, 137);
            this.dgvRSVP.Name = "dgvRSVP";
            this.dgvRSVP.RowHeadersWidth = 51;
            this.dgvRSVP.RowTemplate.Height = 29;
            this.dgvRSVP.Size = new System.Drawing.Size(637, 304);
            this.dgvRSVP.TabIndex = 21;
            this.dgvRSVP.DoubleClick += new System.EventHandler(this.DgvRSVP_DoubleClick);
            // 
            // btn_GetEvent
            // 
            this.btn_GetEvent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_GetEvent.Location = new System.Drawing.Point(23, 94);
            this.btn_GetEvent.Name = "btn_GetEvent";
            this.btn_GetEvent.Size = new System.Drawing.Size(399, 33);
            this.btn_GetEvent.TabIndex = 20;
            this.btn_GetEvent.Text = " Click Here To Get Infomation";
            this.btn_GetEvent.UseVisualStyleBackColor = false;
            this.btn_GetEvent.Click += new System.EventHandler(this.Btn_GetEvent_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // RSVP_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRsave);
            this.Controls.Add(this.cbxFname);
            this.Controls.Add(this.cbxLname);
            this.Controls.Add(this.cbxBooking);
            this.Controls.Add(this.cbxEvent);
            this.Name = "RSVP_Form1";
            this.Text = "RSVP_Form1";
            this.Load += new System.EventHandler(this.RSVP_Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRsave;
        private System.Windows.Forms.ComboBox cbxFname;
        private System.Windows.Forms.ComboBox cbxLname;
        private System.Windows.Forms.ComboBox cbxBooking;
        private System.Windows.Forms.ComboBox cbxEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRreset;
        private System.Windows.Forms.Button btnRdelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.ComboBox cbxFirst;
        private System.Windows.Forms.ComboBox cbxLast;
        private System.Windows.Forms.ComboBox cbxBook;
        private System.Windows.Forms.ComboBox cbxEvt;
        private System.Windows.Forms.Button btnRSVPsearch;
        private System.Windows.Forms.TextBox txtRSVPsearch;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.DataGridView dgvRSVP;
        private System.Windows.Forms.Button btn_GetEvent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}