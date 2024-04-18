namespace Supermarket_mvp.Views
{
    partial class DetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageDetailList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgDetail = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageDetail = new TabPage();
            TxtDetailPrice = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtDetailQuantity = new TextBox();
            TxtDetailId = new TextBox();
            Label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageDetailList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgDetail).BeginInit();
            tabPageDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold);
            label1.Location = new Point(175, 23);
            label1.Name = "label1";
            label1.Size = new Size(174, 44);
            label1.TabIndex = 2;
            label1.Text = "Datails";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDetailList);
            tabControl1.Controls.Add(tabPageDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabPageDetailList
            // 
            tabPageDetailList.Controls.Add(BtnClose);
            tabPageDetailList.Controls.Add(BtnDelete);
            tabPageDetailList.Controls.Add(BtnEdit);
            tabPageDetailList.Controls.Add(BtnNew);
            tabPageDetailList.Controls.Add(DgDetail);
            tabPageDetailList.Controls.Add(BtnSearch);
            tabPageDetailList.Controls.Add(TxtSearch);
            tabPageDetailList.Controls.Add(label2);
            tabPageDetailList.Location = new Point(4, 24);
            tabPageDetailList.Name = "tabPageDetailList";
            tabPageDetailList.Padding = new Padding(3);
            tabPageDetailList.Size = new Size(792, 322);
            tabPageDetailList.TabIndex = 0;
            tabPageDetailList.Text = "Mode Detail List";
            tabPageDetailList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(717, 228);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(55, 57);
            BtnClose.TabIndex = 15;
            BtnClose.Text = "&Close";
            BtnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.ImageAlign = ContentAlignment.TopCenter;
            BtnDelete.Location = new Point(717, 165);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(55, 57);
            BtnDelete.TabIndex = 14;
            BtnDelete.Text = "&Delete";
            BtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.ImageAlign = ContentAlignment.TopCenter;
            BtnEdit.Location = new Point(717, 102);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(55, 57);
            BtnEdit.TabIndex = 13;
            BtnEdit.Text = "&Edit";
            BtnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.ImageAlign = ContentAlignment.TopCenter;
            BtnNew.Location = new Point(717, 39);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(55, 57);
            BtnNew.TabIndex = 12;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgDetail
            // 
            DgDetail.AllowUserToAddRows = false;
            DgDetail.AllowUserToDeleteRows = false;
            DgDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgDetail.Location = new Point(8, 57);
            DgDetail.Name = "DgDetail";
            DgDetail.ReadOnly = true;
            DgDetail.Size = new Size(541, 202);
            DgDetail.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearch.Location = new Point(555, 13);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(34, 38);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseMnemonic = false;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 28);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(541, 23);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Search Detail";
            // 
            // tabPageDetail
            // 
            tabPageDetail.Controls.Add(TxtDetailPrice);
            tabPageDetail.Controls.Add(BtnCancel);
            tabPageDetail.Controls.Add(BtnSave);
            tabPageDetail.Controls.Add(TxtDetailQuantity);
            tabPageDetail.Controls.Add(TxtDetailId);
            tabPageDetail.Controls.Add(Label5);
            tabPageDetail.Controls.Add(label4);
            tabPageDetail.Controls.Add(label3);
            tabPageDetail.Location = new Point(4, 24);
            tabPageDetail.Name = "tabPageDetail";
            tabPageDetail.Padding = new Padding(3);
            tabPageDetail.Size = new Size(792, 322);
            tabPageDetail.TabIndex = 1;
            tabPageDetail.Text = "Mode Detail";
            tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // TxtDetailPrice
            // 
            TxtDetailPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDetailPrice.Location = new Point(22, 159);
            TxtDetailPrice.Name = "TxtDetailPrice";
            TxtDetailPrice.Size = new Size(363, 23);
            TxtDetailPrice.TabIndex = 16;
            TxtDetailPrice.Text = "0";
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.ImageAlign = ContentAlignment.TopCenter;
            BtnCancel.Location = new Point(619, 115);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(151, 53);
            BtnCancel.TabIndex = 15;
            BtnCancel.Text = "&Cancel";
            BtnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.ImageAlign = ContentAlignment.TopCenter;
            BtnSave.Location = new Point(619, 14);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(151, 53);
            BtnSave.TabIndex = 14;
            BtnSave.Text = "&Save";
            BtnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtDetailQuantity
            // 
            TxtDetailQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDetailQuantity.Location = new Point(22, 105);
            TxtDetailQuantity.Name = "TxtDetailQuantity";
            TxtDetailQuantity.Size = new Size(363, 23);
            TxtDetailQuantity.TabIndex = 13;
            TxtDetailQuantity.Text = "0";
            // 
            // TxtDetailId
            // 
            TxtDetailId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDetailId.Location = new Point(22, 34);
            TxtDetailId.Name = "TxtDetailId";
            TxtDetailId.ReadOnly = true;
            TxtDetailId.Size = new Size(363, 23);
            TxtDetailId.TabIndex = 12;
            TxtDetailId.Text = "0";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(8, 141);
            Label5.Name = "Label5";
            Label5.Size = new Size(66, 15);
            Label5.TabIndex = 11;
            Label5.Text = "Detail Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 87);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 10;
            label4.Text = "Detail Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 9;
            label3.Text = "Detail Id";
            // 
            // DetailView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "DetailView";
            Text = "DetailView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageDetailList.ResumeLayout(false);
            tabPageDetailList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgDetail).EndInit();
            tabPageDetail.ResumeLayout(false);
            tabPageDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageDetailList;
        private TabPage tabPageDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtDetailPrice;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtDetailQuantity;
        private TextBox TxtDetailId;
        private Label Label5;
        private Label label4;
        private Label label3;
    }
}