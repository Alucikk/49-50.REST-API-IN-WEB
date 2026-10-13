namespace PostService.App
{
    partial class PostingDialog
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
            pnlDlgHd = new Panel();
            lblDlgTt = new Label();
            lblS = new Label();
            txtSnd = new TextBox();
            txtRc = new TextBox();
            lblR = new Label();
            lblCn = new Label();
            txtCn = new TextBox();
            txtWgh = new TextBox();
            txtCs = new TextBox();
            txtDlVl = new TextBox();
            txtDp = new TextBox();
            txtHgh = new TextBox();
            txtWd = new TextBox();
            lblDl = new Label();
            cmbDl = new ComboBox();
            lblkg = new Label();
            lblWd = new Label();
            lblHgh = new Label();
            lblDp = new Label();
            lblDlVl = new Label();
            lblCs = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlBtm = new Panel();
            pnlDlgHd.SuspendLayout();
            pnlBtm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDlgHd
            // 
            pnlDlgHd.BackColor = Color.FromArgb(0, 64, 0);
            pnlDlgHd.Controls.Add(lblDlgTt);
            pnlDlgHd.Dock = DockStyle.Top;
            pnlDlgHd.Location = new Point(0, 0);
            pnlDlgHd.Name = "pnlDlgHd";
            pnlDlgHd.Size = new Size(893, 62);
            pnlDlgHd.TabIndex = 0;
            // 
            // lblDlgTt
            // 
            lblDlgTt.AutoSize = true;
            lblDlgTt.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDlgTt.ForeColor = SystemColors.ButtonHighlight;
            lblDlgTt.Location = new Point(12, 16);
            lblDlgTt.Name = "lblDlgTt";
            lblDlgTt.Size = new Size(256, 32);
            lblDlgTt.TabIndex = 0;
            lblDlgTt.Text = "Нове відправлення";
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Location = new Point(21, 84);
            lblS.Name = "lblS";
            lblS.Size = new Size(105, 25);
            lblS.TabIndex = 1;
            lblS.Text = "Відправник";
            // 
            // txtSnd
            // 
            txtSnd.BackColor = Color.FromArgb(192, 255, 192);
            txtSnd.BorderStyle = BorderStyle.FixedSingle;
            txtSnd.Location = new Point(21, 124);
            txtSnd.Name = "txtSnd";
            txtSnd.PlaceholderText = "ПІБ або компанія";
            txtSnd.Size = new Size(409, 31);
            txtSnd.TabIndex = 2;
            // 
            // txtRc
            // 
            txtRc.BackColor = Color.FromArgb(192, 255, 192);
            txtRc.BorderStyle = BorderStyle.FixedSingle;
            txtRc.Location = new Point(471, 124);
            txtRc.Name = "txtRc";
            txtRc.PlaceholderText = "ПІБ або компанія";
            txtRc.Size = new Size(398, 31);
            txtRc.TabIndex = 3;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(471, 84);
            lblR.Name = "lblR";
            lblR.Size = new Size(105, 25);
            lblR.TabIndex = 4;
            lblR.Text = "Отримувач";
            // 
            // lblCn
            // 
            lblCn.AutoSize = true;
            lblCn.Location = new Point(21, 178);
            lblCn.Name = "lblCn";
            lblCn.Size = new Size(54, 25);
            lblCn.TabIndex = 5;
            lblCn.Text = "Вміст";
            // 
            // txtCn
            // 
            txtCn.BackColor = Color.FromArgb(192, 255, 192);
            txtCn.BorderStyle = BorderStyle.FixedSingle;
            txtCn.Location = new Point(21, 207);
            txtCn.Name = "txtCn";
            txtCn.PlaceholderText = "Опис вмісту";
            txtCn.Size = new Size(848, 31);
            txtCn.TabIndex = 6;
            // 
            // txtWgh
            // 
            txtWgh.BackColor = Color.FromArgb(192, 255, 192);
            txtWgh.BorderStyle = BorderStyle.FixedSingle;
            txtWgh.Location = new Point(21, 384);
            txtWgh.Name = "txtWgh";
            txtWgh.Size = new Size(184, 31);
            txtWgh.TabIndex = 7;
            // 
            // txtCs
            // 
            txtCs.BackColor = Color.FromArgb(192, 255, 192);
            txtCs.BorderStyle = BorderStyle.FixedSingle;
            txtCs.Location = new Point(471, 489);
            txtCs.Name = "txtCs";
            txtCs.Size = new Size(398, 31);
            txtCs.TabIndex = 8;
            // 
            // txtDlVl
            // 
            txtDlVl.BackColor = Color.FromArgb(192, 255, 192);
            txtDlVl.BorderStyle = BorderStyle.FixedSingle;
            txtDlVl.Location = new Point(21, 489);
            txtDlVl.Name = "txtDlVl";
            txtDlVl.Size = new Size(409, 31);
            txtDlVl.TabIndex = 9;
            // 
            // txtDp
            // 
            txtDp.BackColor = Color.FromArgb(192, 255, 192);
            txtDp.BorderStyle = BorderStyle.FixedSingle;
            txtDp.Location = new Point(677, 384);
            txtDp.Name = "txtDp";
            txtDp.Size = new Size(192, 31);
            txtDp.TabIndex = 10;
            // 
            // txtHgh
            // 
            txtHgh.BackColor = Color.FromArgb(192, 255, 192);
            txtHgh.BorderStyle = BorderStyle.FixedSingle;
            txtHgh.Location = new Point(467, 384);
            txtHgh.Name = "txtHgh";
            txtHgh.Size = new Size(180, 31);
            txtHgh.TabIndex = 11;
            // 
            // txtWd
            // 
            txtWd.BackColor = Color.FromArgb(192, 255, 192);
            txtWd.BorderStyle = BorderStyle.FixedSingle;
            txtWd.Location = new Point(241, 384);
            txtWd.Name = "txtWd";
            txtWd.Size = new Size(192, 31);
            txtWd.TabIndex = 12;
            // 
            // lblDl
            // 
            lblDl.AutoSize = true;
            lblDl.Location = new Point(21, 254);
            lblDl.Name = "lblDl";
            lblDl.Size = new Size(120, 25);
            lblDl.TabIndex = 13;
            lblDl.Text = "Тип доставки";
            // 
            // cmbDl
            // 
            cmbDl.BackColor = Color.FromArgb(192, 255, 192);
            cmbDl.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDl.FlatStyle = FlatStyle.Flat;
            cmbDl.FormattingEnabled = true;
            cmbDl.Location = new Point(21, 289);
            cmbDl.Name = "cmbDl";
            cmbDl.Size = new Size(848, 33);
            cmbDl.TabIndex = 14;
            // 
            // lblkg
            // 
            lblkg.AutoSize = true;
            lblkg.Location = new Point(21, 346);
            lblkg.Name = "lblkg";
            lblkg.Size = new Size(78, 25);
            lblkg.TabIndex = 15;
            lblkg.Text = "Вага (кг)";
            // 
            // lblWd
            // 
            lblWd.AutoSize = true;
            lblWd.Location = new Point(241, 346);
            lblWd.Name = "lblWd";
            lblWd.Size = new Size(115, 25);
            lblWd.TabIndex = 16;
            lblWd.Text = "Ширина (см)";
            // 
            // lblHgh
            // 
            lblHgh.AutoSize = true;
            lblHgh.Location = new Point(467, 346);
            lblHgh.Name = "lblHgh";
            lblHgh.Size = new Size(103, 25);
            lblHgh.TabIndex = 17;
            lblHgh.Text = "Висота (см)";
            // 
            // lblDp
            // 
            lblDp.AutoSize = true;
            lblDp.Location = new Point(677, 346);
            lblDp.Name = "lblDp";
            lblDp.Size = new Size(114, 25);
            lblDp.TabIndex = 18;
            lblDp.Text = "Глибина (см)";
            // 
            // lblDlVl
            // 
            lblDlVl.AutoSize = true;
            lblDlVl.Location = new Point(21, 451);
            lblDlVl.Name = "lblDlVl";
            lblDlVl.Size = new Size(217, 25);
            lblDlVl.TabIndex = 19;
            lblDlVl.Text = "Оголошена цінність (грн)";
            // 
            // lblCs
            // 
            lblCs.AutoSize = true;
            lblCs.Location = new Point(471, 451);
            lblCs.Name = "lblCs";
            lblCs.Size = new Size(120, 25);
            lblCs.TabIndex = 20;
            lblCs.Text = "Вартість (грн)";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(606, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 46);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 64, 0);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(749, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 46);
            btnSave.TabIndex = 22;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlBtm
            // 
            pnlBtm.BackColor = Color.LightGray;
            pnlBtm.Controls.Add(btnCancel);
            pnlBtm.Controls.Add(btnSave);
            pnlBtm.Dock = DockStyle.Bottom;
            pnlBtm.Location = new Point(0, 545);
            pnlBtm.Name = "pnlBtm";
            pnlBtm.Size = new Size(893, 75);
            pnlBtm.TabIndex = 23;
            // 
            // PostingDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            CancelButton = btnCancel;
            ClientSize = new Size(893, 620);
            Controls.Add(pnlBtm);
            Controls.Add(lblCs);
            Controls.Add(lblDlVl);
            Controls.Add(lblDp);
            Controls.Add(lblHgh);
            Controls.Add(lblWd);
            Controls.Add(lblkg);
            Controls.Add(cmbDl);
            Controls.Add(lblDl);
            Controls.Add(txtWd);
            Controls.Add(txtHgh);
            Controls.Add(txtDp);
            Controls.Add(txtDlVl);
            Controls.Add(txtCs);
            Controls.Add(txtWgh);
            Controls.Add(txtCn);
            Controls.Add(lblCn);
            Controls.Add(lblR);
            Controls.Add(txtRc);
            Controls.Add(txtSnd);
            Controls.Add(lblS);
            Controls.Add(pnlDlgHd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PostingDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Нове відправлення";
            pnlDlgHd.ResumeLayout(false);
            pnlDlgHd.PerformLayout();
            pnlBtm.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDlgHd;
        private Label lblDlgTt;
        private Label lblS;
        private TextBox txtSnd;
        private TextBox txtRc;
        private Label lblR;
        private Label lblCn;
        private TextBox txtCn;
        private TextBox txtWgh;
        private TextBox txtCs;
        private TextBox txtDlVl;
        private TextBox txtDp;
        private TextBox txtHgh;
        private TextBox txtWd;
        private Label lblDl;
        private ComboBox cmbDl;
        private Label lblkg;
        private Label lblWd;
        private Label lblHgh;
        private Label lblDp;
        private Label lblDlVl;
        private Label lblCs;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlBtm;
    }
}