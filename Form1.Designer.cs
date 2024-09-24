
namespace CarFinancing
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
            this.tbCtrlPurchasesMade = new System.Windows.Forms.TabControl();
            this.tbCarPurchase = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lstMonthlyPayments = new System.Windows.Forms.ListBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.grpModel = new System.Windows.Forms.GroupBox();
            this.rdSport = new System.Windows.Forms.RadioButton();
            this.rdHybrid = new System.Windows.Forms.RadioButton();
            this.rdBasic = new System.Windows.Forms.RadioButton();
            this.lblSelection = new System.Windows.Forms.Label();
            this.cmbSelection = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPurchasesMade = new System.Windows.Forms.TabPage();
            this.lstPurchasesMade = new System.Windows.Forms.ListBox();
            this.tbCtrlPurchasesMade.SuspendLayout();
            this.tbCarPurchase.SuspendLayout();
            this.grpModel.SuspendLayout();
            this.tbPurchasesMade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlPurchasesMade
            // 
            this.tbCtrlPurchasesMade.Controls.Add(this.tbCarPurchase);
            this.tbCtrlPurchasesMade.Controls.Add(this.tbPurchasesMade);
            this.tbCtrlPurchasesMade.Location = new System.Drawing.Point(12, 12);
            this.tbCtrlPurchasesMade.Name = "tbCtrlPurchasesMade";
            this.tbCtrlPurchasesMade.SelectedIndex = 0;
            this.tbCtrlPurchasesMade.Size = new System.Drawing.Size(776, 426);
            this.tbCtrlPurchasesMade.TabIndex = 0;
            this.tbCtrlPurchasesMade.SelectedIndexChanged += new System.EventHandler(this.tbCtrlPurchasesMade_SelectedIndexChanged);
            // 
            // tbCarPurchase
            // 
            this.tbCarPurchase.Controls.Add(this.btnClear);
            this.tbCarPurchase.Controls.Add(this.btnExit);
            this.tbCarPurchase.Controls.Add(this.btnPayments);
            this.tbCarPurchase.Controls.Add(this.btnPurchase);
            this.tbCarPurchase.Controls.Add(this.lstMonthlyPayments);
            this.tbCarPurchase.Controls.Add(this.txtDownPayment);
            this.tbCarPurchase.Controls.Add(this.lblDownPayment);
            this.tbCarPurchase.Controls.Add(this.grpModel);
            this.tbCarPurchase.Controls.Add(this.lblSelection);
            this.tbCarPurchase.Controls.Add(this.cmbSelection);
            this.tbCarPurchase.Controls.Add(this.txtAge);
            this.tbCarPurchase.Controls.Add(this.lblAge);
            this.tbCarPurchase.Controls.Add(this.txtName);
            this.tbCarPurchase.Controls.Add(this.lblName);
            this.tbCarPurchase.Location = new System.Drawing.Point(4, 22);
            this.tbCarPurchase.Name = "tbCarPurchase";
            this.tbCarPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarPurchase.Size = new System.Drawing.Size(768, 400);
            this.tbCarPurchase.TabIndex = 0;
            this.tbCarPurchase.Text = "Car Purchase";
            this.tbCarPurchase.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(595, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(595, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.Location = new System.Drawing.Point(595, 248);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(148, 23);
            this.btnPayments.TabIndex = 11;
            this.btnPayments.Text = "Show Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(595, 199);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(148, 23);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lstMonthlyPayments
            // 
            this.lstMonthlyPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonthlyPayments.FormattingEnabled = true;
            this.lstMonthlyPayments.ItemHeight = 15;
            this.lstMonthlyPayments.Location = new System.Drawing.Point(60, 199);
            this.lstMonthlyPayments.Name = "lstMonthlyPayments";
            this.lstMonthlyPayments.Size = new System.Drawing.Size(512, 169);
            this.lstMonthlyPayments.TabIndex = 9;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(472, 153);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 23);
            this.txtDownPayment.TabIndex = 8;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPayment.Location = new System.Drawing.Point(366, 158);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(91, 17);
            this.lblDownPayment.TabIndex = 7;
            this.lblDownPayment.Text = "Down Payment";
            // 
            // grpModel
            // 
            this.grpModel.Controls.Add(this.rdSport);
            this.grpModel.Controls.Add(this.rdHybrid);
            this.grpModel.Controls.Add(this.rdBasic);
            this.grpModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModel.Location = new System.Drawing.Point(369, 49);
            this.grpModel.Name = "grpModel";
            this.grpModel.Size = new System.Drawing.Size(203, 44);
            this.grpModel.TabIndex = 6;
            this.grpModel.TabStop = false;
            this.grpModel.Text = "Select Model";
            // 
            // rdSport
            // 
            this.rdSport.AutoSize = true;
            this.rdSport.Location = new System.Drawing.Point(132, 23);
            this.rdSport.Name = "rdSport";
            this.rdSport.Size = new System.Drawing.Size(53, 19);
            this.rdSport.TabIndex = 2;
            this.rdSport.TabStop = true;
            this.rdSport.Text = "Sport";
            this.rdSport.UseVisualStyleBackColor = true;
            // 
            // rdHybrid
            // 
            this.rdHybrid.AutoSize = true;
            this.rdHybrid.Location = new System.Drawing.Point(65, 23);
            this.rdHybrid.Name = "rdHybrid";
            this.rdHybrid.Size = new System.Drawing.Size(61, 19);
            this.rdHybrid.TabIndex = 1;
            this.rdHybrid.TabStop = true;
            this.rdHybrid.Text = "Hybrid";
            this.rdHybrid.UseVisualStyleBackColor = true;
            // 
            // rdBasic
            // 
            this.rdBasic.AutoSize = true;
            this.rdBasic.Location = new System.Drawing.Point(7, 23);
            this.rdBasic.Name = "rdBasic";
            this.rdBasic.Size = new System.Drawing.Size(52, 19);
            this.rdBasic.TabIndex = 0;
            this.rdBasic.TabStop = true;
            this.rdBasic.Text = "Basic";
            this.rdBasic.UseVisualStyleBackColor = true;
            // 
            // lblSelection
            // 
            this.lblSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(57, 156);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(74, 17);
            this.lblSelection.TabIndex = 5;
            this.lblSelection.Text = "Select Car";
            // 
            // cmbSelection
            // 
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Items.AddRange(new object[] {
            "Sonata",
            "Corolla",
            "Civic",
            "Camry"});
            this.cmbSelection.Location = new System.Drawing.Point(169, 154);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(100, 21);
            this.cmbSelection.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(169, 106);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 23);
            this.txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(57, 109);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(74, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Enter Age";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(169, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            // 
            // tbPurchasesMade
            // 
            this.tbPurchasesMade.Controls.Add(this.lstPurchasesMade);
            this.tbPurchasesMade.Location = new System.Drawing.Point(4, 22);
            this.tbPurchasesMade.Name = "tbPurchasesMade";
            this.tbPurchasesMade.Padding = new System.Windows.Forms.Padding(3);
            this.tbPurchasesMade.Size = new System.Drawing.Size(768, 400);
            this.tbPurchasesMade.TabIndex = 1;
            this.tbPurchasesMade.Text = "Purchases Made";
            this.tbPurchasesMade.UseVisualStyleBackColor = true;
            // 
            // lstPurchasesMade
            // 
            this.lstPurchasesMade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPurchasesMade.FormattingEnabled = true;
            this.lstPurchasesMade.ItemHeight = 15;
            this.lstPurchasesMade.Location = new System.Drawing.Point(7, 7);
            this.lstPurchasesMade.Name = "lstPurchasesMade";
            this.lstPurchasesMade.Size = new System.Drawing.Size(755, 379);
            this.lstPurchasesMade.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCtrlPurchasesMade);
            this.Name = "Form1";
            this.Text = "Car Financing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbCtrlPurchasesMade.ResumeLayout(false);
            this.tbCarPurchase.ResumeLayout(false);
            this.tbCarPurchase.PerformLayout();
            this.grpModel.ResumeLayout(false);
            this.grpModel.PerformLayout();
            this.tbPurchasesMade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlPurchasesMade;
        private System.Windows.Forms.TabPage tbCarPurchase;
        private System.Windows.Forms.TabPage tbPurchasesMade;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ListBox lstMonthlyPayments;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.GroupBox grpModel;
        private System.Windows.Forms.RadioButton rdSport;
        private System.Windows.Forms.RadioButton rdHybrid;
        private System.Windows.Forms.RadioButton rdBasic;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ComboBox cmbSelection;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstPurchasesMade;
    }
}

