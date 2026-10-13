namespace PostService.App
{
    partial class PostingList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostingList));
            gridPostings = new DataGridView();
            ClId = new DataGridViewTextBoxColumn();
            ClFrom = new DataGridViewTextBoxColumn();
            ClTo = new DataGridViewTextBoxColumn();
            clCont = new DataGridViewTextBoxColumn();
            clDelTyp = new DataGridViewTextBoxColumn();
            clWeigh = new DataGridViewTextBoxColumn();
            clWid = new DataGridViewTextBoxColumn();
            clHeig = new DataGridViewTextBoxColumn();
            clDep = new DataGridViewTextBoxColumn();
            clVal = new DataGridViewTextBoxColumn();
            clPr = new DataGridViewTextBoxColumn();
            clCrtAt = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnRefresh = new Button();
            pnlHeader = new Panel();
            lbltT = new Label();
            lblHdTit = new Label();
            pnlAct = new Panel();
            btnRefres = new Button();
            btnDetails = new Button();
            btnEdit = new Button();
            btnCreate = new Button();
            lblTtlСnt = new Label();
            lblStRd = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPostings).BeginInit();
            pnlHeader.SuspendLayout();
            pnlAct.SuspendLayout();
            SuspendLayout();
            // 
            // gridPostings
            // 
            gridPostings.AllowUserToAddRows = false;
            gridPostings.AllowUserToDeleteRows = false;
            gridPostings.BackgroundColor = SystemColors.ButtonFace;
            gridPostings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPostings.Columns.AddRange(new DataGridViewColumn[] { ClId, ClFrom, ClTo, clCont, clDelTyp, clWeigh, clWid, clHeig, clDep, clVal, clPr, clCrtAt });
            gridPostings.Location = new Point(12, 220);
            gridPostings.MultiSelect = false;
            gridPostings.Name = "gridPostings";
            gridPostings.ReadOnly = true;
            gridPostings.RowHeadersWidth = 62;
            gridPostings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPostings.Size = new Size(1564, 162);
            gridPostings.TabIndex = 0;
            // 
            // ClId
            // 
            ClId.DataPropertyName = "Id";
            ClId.HeaderText = "ID";
            ClId.MinimumWidth = 8;
            ClId.Name = "ClId";
            ClId.ReadOnly = true;
            ClId.Visible = false;
            ClId.Width = 150;
            // 
            // ClFrom
            // 
            ClFrom.DataPropertyName = "From";
            ClFrom.HeaderText = "Відправник";
            ClFrom.MinimumWidth = 8;
            ClFrom.Name = "ClFrom";
            ClFrom.ReadOnly = true;
            ClFrom.Width = 150;
            // 
            // ClTo
            // 
            ClTo.DataPropertyName = "To";
            ClTo.HeaderText = "Отримувач";
            ClTo.MinimumWidth = 8;
            ClTo.Name = "ClTo";
            ClTo.ReadOnly = true;
            ClTo.Width = 150;
            // 
            // clCont
            // 
            clCont.DataPropertyName = "Content";
            clCont.HeaderText = "Вміст";
            clCont.MinimumWidth = 8;
            clCont.Name = "clCont";
            clCont.ReadOnly = true;
            clCont.Width = 150;
            // 
            // clDelTyp
            // 
            clDelTyp.DataPropertyName = "DeliveryType";
            clDelTyp.HeaderText = "Тип доставки";
            clDelTyp.MinimumWidth = 8;
            clDelTyp.Name = "clDelTyp";
            clDelTyp.ReadOnly = true;
            clDelTyp.Width = 150;
            // 
            // clWeigh
            // 
            clWeigh.DataPropertyName = "Weight";
            clWeigh.HeaderText = "Вага";
            clWeigh.MinimumWidth = 8;
            clWeigh.Name = "clWeigh";
            clWeigh.ReadOnly = true;
            clWeigh.Width = 150;
            // 
            // clWid
            // 
            clWid.DataPropertyName = "Width";
            clWid.HeaderText = "Ширина";
            clWid.MinimumWidth = 8;
            clWid.Name = "clWid";
            clWid.ReadOnly = true;
            clWid.Width = 150;
            // 
            // clHeig
            // 
            clHeig.DataPropertyName = "Height";
            clHeig.HeaderText = "Висота";
            clHeig.MinimumWidth = 8;
            clHeig.Name = "clHeig";
            clHeig.ReadOnly = true;
            clHeig.Width = 150;
            // 
            // clDep
            // 
            clDep.DataPropertyName = "Depth";
            clDep.HeaderText = "Глибина";
            clDep.MinimumWidth = 8;
            clDep.Name = "clDep";
            clDep.ReadOnly = true;
            clDep.Width = 150;
            // 
            // clVal
            // 
            clVal.DataPropertyName = "Value";
            clVal.HeaderText = "Значення";
            clVal.MinimumWidth = 8;
            clVal.Name = "clVal";
            clVal.ReadOnly = true;
            clVal.Width = 150;
            // 
            // clPr
            // 
            clPr.DataPropertyName = "Price";
            clPr.HeaderText = "Ціна";
            clPr.MinimumWidth = 8;
            clPr.Name = "clPr";
            clPr.ReadOnly = true;
            clPr.Width = 150;
            // 
            // clCrtAt
            // 
            clCrtAt.DataPropertyName = "CreatedAt";
            clCrtAt.HeaderText = "Створення";
            clCrtAt.MinimumWidth = 8;
            clCrtAt.Name = "clCrtAt";
            clCrtAt.ReadOnly = true;
            clCrtAt.Visible = false;
            clCrtAt.Width = 150;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.GhostWhite;
            btnDelete.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(465, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Видалити";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BackColor = Color.MediumOrchid;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
            btnRefresh.Location = new Point(1436, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 37);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Оновити";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefres_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 64, 0);
            pnlHeader.Controls.Add(lbltT);
            pnlHeader.Controls.Add(lblHdTit);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1588, 101);
            pnlHeader.TabIndex = 3;
            // 
            // lbltT
            // 
            lbltT.AutoSize = true;
            lbltT.ForeColor = SystemColors.ButtonHighlight;
            lbltT.Location = new Point(12, 45);
            lbltT.Name = "lbltT";
            lbltT.Size = new Size(371, 25);
            lbltT.TabIndex = 1;
            lbltT.Text = "Система обліку та моніторингу відправлень";
            // 
            // lblHdTit
            // 
            lblHdTit.AutoSize = true;
            lblHdTit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblHdTit.ForeColor = SystemColors.ButtonHighlight;
            lblHdTit.Location = new Point(12, 7);
            lblHdTit.Name = "lblHdTit";
            lblHdTit.Size = new Size(586, 38);
            lblHdTit.TabIndex = 0;
            lblHdTit.Text = "РОБОЧА ОБЛАСТЬ КЕРУВАННЯ ДАНИМИ";
            // 
            // pnlAct
            // 
            pnlAct.BackColor = SystemColors.ButtonHighlight;
            pnlAct.Controls.Add(btnRefres);
            pnlAct.Controls.Add(btnDetails);
            pnlAct.Controls.Add(btnEdit);
            pnlAct.Controls.Add(btnCreate);
            pnlAct.Controls.Add(btnDelete);
            pnlAct.Location = new Point(12, 135);
            pnlAct.Name = "pnlAct";
            pnlAct.Size = new Size(1564, 48);
            pnlAct.TabIndex = 4;
            // 
            // btnRefres
            // 
            btnRefres.Font = new Font("Times New Roman", 10F);
            btnRefres.ForeColor = Color.DarkGreen;
            btnRefres.Location = new Point(626, 8);
            btnRefres.Name = "btnRefres";
            btnRefres.Size = new Size(145, 34);
            btnRefres.TabIndex = 5;
            btnRefres.Text = "Оновити";
            btnRefres.UseVisualStyleBackColor = true;
            btnRefres.Click += btnRefres_Click;
            // 
            // btnDetails
            // 
            btnDetails.Font = new Font("Times New Roman", 10F);
            btnDetails.ForeColor = Color.DarkGreen;
            btnDetails.Image = Properties.Resources.info;
            btnDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetails.Location = new Point(316, 8);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(145, 34);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Деталі";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 10F);
            btnEdit.ForeColor = Color.DarkGreen;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(166, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Редагувати";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreate.ForeColor = Color.DarkGreen;
            btnCreate.Location = new Point(16, 7);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(145, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "+ Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblTtlСnt
            // 
            lblTtlСnt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTtlСnt.AutoSize = true;
            lblTtlСnt.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTtlСnt.ForeColor = Color.DarkGreen;
            lblTtlСnt.Location = new Point(12, 403);
            lblTtlСnt.Name = "lblTtlСnt";
            lblTtlСnt.Size = new Size(150, 23);
            lblTtlСnt.TabIndex = 5;
            lblTtlСnt.Text = "Всього записів:";
            // 
            // lblStRd
            // 
            lblStRd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblStRd.AutoSize = true;
            lblStRd.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblStRd.ForeColor = Color.DarkGreen;
            lblStRd.Location = new Point(1505, 403);
            lblStRd.Name = "lblStRd";
            lblStRd.Size = new Size(71, 23);
            lblStRd.TabIndex = 6;
            lblStRd.Text = "Готово";
            // 
            // PostingList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1588, 450);
            Controls.Add(lblStRd);
            Controls.Add(lblTtlСnt);
            Controls.Add(pnlAct);
            Controls.Add(pnlHeader);
            Controls.Add(btnRefresh);
            Controls.Add(gridPostings);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PostingList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PostingList";
            Load += PostingList_Load;
            ((System.ComponentModel.ISupportInitialize)gridPostings).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAct.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridPostings;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn ClId;
        private DataGridViewTextBoxColumn ClFrom;
        private DataGridViewTextBoxColumn ClTo;
        private DataGridViewTextBoxColumn clCont;
        private DataGridViewTextBoxColumn clDelTyp;
        private DataGridViewTextBoxColumn clWeigh;
        private DataGridViewTextBoxColumn clWid;
        private DataGridViewTextBoxColumn clHeig;
        private DataGridViewTextBoxColumn clDep;
        private DataGridViewTextBoxColumn clVal;
        private DataGridViewTextBoxColumn clPr;
        private DataGridViewTextBoxColumn clCrtAt;
        private Panel pnlHeader;
        private Label lblHdTit;
        private Label lbltT;
        private Panel pnlAct;
        private Button btnCreate;
        private Button btnDetails;
        private Button btnEdit;
        private Label lblTtlСnt;
        private Label lblStRd;
        private Button btnRefres;
    }
}
