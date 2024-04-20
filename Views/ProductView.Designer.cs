namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            DgProduct = new DataGridView();
            tabPageProductDetail = new TabPage();
            TxtProductStock = new TextBox();
            label6 = new Label();
            TxtProductPrice = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            Label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold);
            label1.Location = new Point(175, 23);
            label1.Name = "label1";
            label1.Size = new Size(214, 44);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 322);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(717, 228);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(55, 57);
            BtnClose.TabIndex = 19;
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
            BtnDelete.TabIndex = 18;
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
            BtnEdit.TabIndex = 17;
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
            BtnNew.TabIndex = 16;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearch.Location = new Point(555, 13);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(34, 38);
            BtnSearch.TabIndex = 13;
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
            TxtSearch.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 11;
            label2.Text = "Search Product";
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(8, 57);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.Size = new Size(541, 202);
            DgProduct.TabIndex = 0;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(Label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 322);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Datail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductStock.Location = new Point(22, 218);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(363, 23);
            TxtProductStock.TabIndex = 26;
            TxtProductStock.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 200);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 25;
            label6.Text = "Product Stock";
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductPrice.Location = new Point(22, 159);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(363, 23);
            TxtProductPrice.TabIndex = 24;
            TxtProductPrice.Text = "0";
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.ImageAlign = ContentAlignment.TopCenter;
            BtnCancel.Location = new Point(619, 115);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(151, 53);
            BtnCancel.TabIndex = 23;
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
            BtnSave.TabIndex = 22;
            BtnSave.Text = "&Save";
            BtnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.Location = new Point(22, 105);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(363, 23);
            TxtProductName.TabIndex = 21;
            TxtProductName.Text = "0";
            // 
            // TxtProductId
            // 
            TxtProductId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductId.Location = new Point(22, 34);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(363, 23);
            TxtProductId.TabIndex = 20;
            TxtProductId.Text = "0";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(8, 141);
            Label5.Name = "Label5";
            Label5.Size = new Size(78, 15);
            Label5.TabIndex = 19;
            Label5.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 87);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 18;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductPrice;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private Label Label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProductStock;
        private Label label6;
    }
}