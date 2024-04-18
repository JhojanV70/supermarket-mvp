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
        }
    }
}
