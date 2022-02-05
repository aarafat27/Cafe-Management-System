using Cafe_Management.Data_Access_Layer;
using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.Presentation_Layer
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void ManageCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryWiseProductSearcgComboBox.DataSource = categoryDataAccess.GetCategoryNames();
        }

        void UpdateGridView()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            listOfCategoriesGridView.DataSource = categoryDataAccess.GetCategories();
        }
        void ClearFields()
        {
            addCategoryNameTextBox.Text = string.Empty;
            updateCategoryIdTextBox.Text = string.Empty;
            updateCategoryNameTextBox.Text = string.Empty;
            deleteCategoryIdTextBox.Text = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.CreateCategory(addCategoryNameTextBox.Text))
            {
                MessageBox.Show("New category added");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (updateCategoryIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a category id");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                Category category = categoryDataAccess.GetCategoryById(Convert.ToInt32(updateCategoryIdTextBox.Text));
                if (category == null)
                {
                    MessageBox.Show("Category is not available");
                    ClearFields();
                }
                else
                {
                    updateCategoryNameTextBox.Text = category.CategoryName;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.UpdateCategory(Convert.ToInt32(updateCategoryIdTextBox.Text), updateCategoryNameTextBox.Text))
            {
                MessageBox.Show("Category updated");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteCategoryIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a category id");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                Category category = categoryDataAccess.GetCategoryById(Convert.ToInt32(deleteCategoryIdTextBox.Text));
                if (category == null)
                {
                    MessageBox.Show("Category is not available");
                    ClearFields();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        categoryDataAccess = new CategoryDataAccess();
                        if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryIdTextBox.Text)))
                        {
                            MessageBox.Show("Category deleted");
                            UpdateGridView();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Error in deleting");
                        }
                    }
                }
            }
        }

        private void categoryWiseProductSearcgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(categoryWiseProductSearcgComboBox.Text).CategoryId;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            categoryWiseProductGridView.DataSource = productDataAccess.GetProductsById(categoryId);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProductDashboard productDashboard = new ProductDashboard();
            productDashboard.Show();
            this.Hide();
        }
    }
}
