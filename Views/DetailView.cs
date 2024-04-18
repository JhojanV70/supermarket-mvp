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
    }
}
