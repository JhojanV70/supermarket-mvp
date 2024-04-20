using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class DetailView : Form, IDetailView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public DetailView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        public string DetailId
        {
            get { return TxtDetailId.Text; }
            set { TxtDetailId.Text = value; }
        }
        public string DetailQuantity
        {
            get { return TxtDetailQuantity.Text; }
            set { TxtDetailQuantity.Text = value; }
        }
        public string DetailPrice
        {
            get { return TxtDetailPrice.Text; }
            set { TxtDetailPrice.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { IsSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetDetailListBildingSource(BindingSource detailList)
        {
            DgDetail.DataSource = detailList;
        }
        private static DetailView instance;

        public static DetailView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DetailView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            if (instance == null || instance.IsDisposed)
            {
                instance = new DetailView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Maximized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };            

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageDetailList);
                tabControl1.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Add New Detail";
            };


            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageDetailList);
                tabControl1.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Edit Detail";
            };


            BtnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var Result = MessageBox.Show("Are you sure you want to delete the selected detail",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageDetail);
                    tabControl1.TabPages.Add(tabPageDetailList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageDetail);
                tabControl1.TabPages.Add(tabPageDetailList);
            };            
        }
    }
}
