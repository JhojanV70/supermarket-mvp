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
            CleanViewFields();
        }

        private void SaveDetail(object? sender, EventArgs e)
        {
            var detail = new DetailModel();
            detail.Id = Convert.ToInt32(view.DetailId);
            detail.Quantity = view.DetailQuantity;
            detail.Price = view.DetailPrice;

            try
            {
                new Common.ModelDataValidation().Validate(detail);
                if (view.IsEdit)
                {
                    repository.Edit(detail);
                    view.Message = "Detail edited Successfuly";
                }
                else
                {
                    repository.Add(detail);
                    view.Message = "Detail Added Successfuly";
                }
                view.IsSuccessful = true;
                loadAllDetailList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.DetailId = "0";
            view.DetailQuantity = "0";
            view.DetailPrice = "0";
        }

        private void DeleteSelectedDetail(object? sender, EventArgs e)
        {
            try
            {
                var detail = (DetailModel)detailBindingSource.Current;

                repository.Delete(detail.Id);
                view.IsSuccessful = true;
                view.Message = "Detail deleted successfully";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not deleted Detail";
            }
        }

        private void LoadSelectDetailToEdit(object? sender, EventArgs e)
        {
            var detail = (DetailModel)detailBindingSource.Current;

            view.DetailId = detail.Id.ToString();
            view.DetailQuantity = detail.Quantity;
            view.DetailPrice = detail.Price;

            view.IsEdit = true;
        }

        private void AddNewDetail(object? sender, EventArgs e)
        {
            view.IsEdit = false;
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
