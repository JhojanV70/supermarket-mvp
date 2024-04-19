using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
namespace Supermarket_mvp.Presenters
{
    internal class DetailPresenter
    {
        private IDetailView view;
        private IDetailRepository repository;
        private BindingSource detailBindingSource;
        private IEnumerable<DetailModel> detailList;

        public DetailPresenter(IDetailView view, IDetailRepository repository)
        {
            this.detailBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchDetail;
            this.view.AddNewEvent += AddNewDetail;
            this.view.EditEvent += LoadSelectDetailToEdit;
            this.view.DeleteEvent += DeleteSelectedDetail;
            this.view.SaveEvent += SaveDetail;
            this.view.CancelEvent += CancelAction;

            this.view.SetDetailListBildingSource(detailBindingSource);

            loadAllDetailList();

            this.view.Show();
        }

        private void loadAllDetailList()
        {
            detailList = repository.GetAll();
            detailBindingSource.DataSource = detailList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveDetail(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedDetail(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectDetailToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewDetail(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo Clic en el botón nuevo");
        }

        private void SearchDetail(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                detailList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                detailList = repository.GetAll();
            }
            detailBindingSource.DataSource = detailList;
        }
    }
}
