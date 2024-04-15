namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            label4 = new Label();
            Label5 = new Label();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            BntSave = new Button();
            BtnCanel = new Button();
            TxtPayModeObservation = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 23);
            label1.Name = "label1";
            label1.Size = new Size(203, 44);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(BtnCanel);
            tabPagePayModeDetail.Controls.Add(BntSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(Label5);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 322);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 28);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(541, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearch.Location = new Point(555, 13);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(34, 38);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseMnemonic = false;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(8, 57);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(541, 202);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.ImageAlign = ContentAlignment.TopCenter;
            BtnNew.Location = new Point(705, 13);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(55, 57);
            BtnNew.TabIndex = 4;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.ImageAlign = ContentAlignment.TopCenter;
            BtnEdit.Location = new Point(705, 76);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(55, 57);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "&Edit";
            BtnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.ImageAlign = ContentAlignment.TopCenter;
            BtnDelete.Location = new Point(705, 139);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(55, 57);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "&Delete";
            BtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(705, 202);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(55, 57);
            BtnClose.TabIndex = 7;
            BtnClose.Text = "&Close";
            BtnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 87);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 1;
            label4.Text = "Pay Mode Name";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(8, 141);
            Label5.Name = "Label5";
            Label5.Size = new Size(127, 15);
            Label5.TabIndex = 2;
            Label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(22, 34);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(100, 23);
            TxtPayModeId.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(22, 105);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(100, 23);
            TxtPayModeName.TabIndex = 4;
            // 
            // BntSave
            // 
            BntSave.Image = Properties.Resources.save;
            BntSave.ImageAlign = ContentAlignment.TopCenter;
            BntSave.Location = new Point(681, 14);
            BntSave.Name = "BntSave";
            BntSave.Size = new Size(75, 53);
            BntSave.TabIndex = 6;
            BntSave.Text = "&Save";
            BntSave.TextImageRelation = TextImageRelation.ImageAboveText;
            BntSave.UseVisualStyleBackColor = true;
            // 
            // BtnCanel
            // 
            BtnCanel.Image = Properties.Resources.cancel;
            BtnCanel.ImageAlign = ContentAlignment.TopCenter;
            BtnCanel.Location = new Point(681, 105);
            BtnCanel.Name = "BtnCanel";
            BtnCanel.Size = new Size(75, 53);
            BtnCanel.TabIndex = 7;
            BtnCanel.Text = "&Cancel";
            BtnCanel.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCanel.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(22, 159);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(624, 130);
            TxtPayModeObservation.TabIndex = 8;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label Label5;
        private Label label4;
        private Label label3;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Button BtnCanel;
        private Button BntSave;
        private TextBox TxtPayModeObservation;
    }
}