using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriePresenter
    {
        private ICategorieView view;
        private ICategorieRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategorieModel> categorieList;

        public CategoriePresenter(ICategorieView view, ICategorieRepository repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);

            loadAllCategorieList();

            this.view.Show();
        }

        private void loadAllCategorieList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorie = new CategorieModel();
            categorie.Id = Convert.ToInt32(view.CategorieId);
            categorie.Name = view.CategorieName;
            categorie.Description = view.CategorieDescription;

            try
            {
                new Common.ModelDataValidation().Validate(categorie);
                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "CAtegorie Added Successfuly";
                }
                view.IsSuccessful = true;
                loadAllCategorieList();
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
            view.CategorieId = "0";
            view.CategorieName = "";
            view.CategorieDescription = "";
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categorie = (CategorieModel)categorieBindingSource.Current;

            view.CategorieId = categorie.Id.ToString();
            view.CategorieName = categorie.Name;
            view.CategorieDescription = categorie.Description;

            view.IsEdit = true;
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }
    }

}
