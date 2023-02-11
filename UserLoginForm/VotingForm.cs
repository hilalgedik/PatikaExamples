using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginForm.Business;
using UserLoginForm.Entities;

namespace UserLoginForm
{
    public partial class VotingForm : DevExpress.XtraEditors.XtraForm
    {
        CategoryManager _categoryManager;
        public VotingForm(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
            InitializeComponent();
            CategorySource();
        }

        public void CategorySource()
        {
            IList<Category> items;
            items = _categoryManager.GetDistincCategory();

            for (int i = 0; i < items.Count; i++)
            {
                cmdCategories.Properties.Items.Add(items[i].CategoryName);
            }

        }

        private void btnVoting_Click(object sender, EventArgs e)
        {
            if (txtVote.Text != "" && cmdCategories.EditValue != "Kategori Seçiniz...")
            {
                var category = new Category
                {
                    CategoryName = cmdCategories.EditValue.ToString(),
                    Vote = Convert.ToInt32(txtVote.Text)
                };

                _categoryManager.Add(category);
            }

            txtVoteRate.Text = GetVoteRate(cmdCategories.EditValue.ToString()).ToString();
            MessageBox.Show("Oyunuz kaydedildi!");
            txtVote.Text = "";
            
        }

        public int GetVoteRate(string categoryName)
        {
            IList<Category> categories;
            categories = _categoryManager.GetCategoryByName(categoryName);
            int toplam = 0;

            for (int i = 0; i < categories.Count; i++)
            {
                toplam = toplam + categories[i].Vote;
            }

            int ort;

            if (toplam != 0)
            {
                ort = toplam / (categories.Count);
            }
            else
            {
                ort = 0;
            }

            return ort;
        }
    }
}