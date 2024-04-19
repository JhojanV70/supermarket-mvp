﻿using System;
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
    public partial class CategorieView : Form, ICategorieView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategorieView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageDetail);
            BtnClose.Click += delegate { this.Close(); };
        }
        
        public string CategorieId
        {
            get { return TxtCategorieId.Text; }
            set { TxtCategorieId.Text = value; }
        }
        public string CategorieName
        {
            get { return TxtCategorieName.Text; }
            set { TxtCategorieName.Text = value; }
        }
        public string CategorieDescription
        {
            get { return TxtCategorieDescription.Text; }
            set { TxtCategorieDescription.Text = value; }
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
            set { isSuccessful = value; }
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

        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgCategorie.DataSource = categorieList;
        }

        private static CategorieView instance;
        public static CategorieView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategorieView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategorieView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
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
            BtnNew.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty);
                
                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Add new Categorie";
            };

            BtnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Edit Categorie";
            };

            BtnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            BtnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };

        }

    }
}
