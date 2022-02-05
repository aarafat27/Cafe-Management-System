using Cafe_Management.Data_Access_Layer;
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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void ManageProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            addCategoryListComboBox.DataSource = categoryDataAccess.GetCategoryNames();
            categoryDataAccess = new CategoryDataAccess();
            updateCategoryComboBox.DataSource = categoryDataAccess.GetCategoryNames();
        }

        void UpdateGridView()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            listOfProductsGridView.DataSource = productDataAccess.GetProducts();
        }
        void ClearFields()
        {
            addProductNameTextBox.Text = string.Empty;
            addPriceTextBox.Text = string.Empty;
            addQuantityNumericUpDown.Text = string.Empty;
            updateProductNameTextBox.Text = string.Empty;
            updatePriceTextBox.Text = string.Empty;
            updateQuantityNumericUpDown1.Text = string.Empty;
            //deleteProductIdTextBox.Text = string.Empty;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(addCategoryListComboBox.Text).CategoryId;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            if (productDataAccess.CreateProduct(addProductNameTextBox.Text, Convert.ToDouble(addPriceTextBox.Text), Convert.ToInt32(addQuantityNumericUpDown.Text), categoryId))
            {
                MessageBox.Show("New product created");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in creating");
                ClearFields();
            }
        }

        private void listOfProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateProductIdTextBox.Text = listOfProductsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateProductNameTextBox.Text = listOfProductsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updatePriceTextBox.Text = listOfProductsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateQuantityNumericUpDown1.Text = listOfProductsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            int categoryId = (int)listOfProductsGridView.Rows[e.RowIndex].Cells[4].Value;
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            updateCategoryComboBox.Text = categoryDataAccess.GetCategoryById(categoryId).CategoryName;
           // deleteProductIdTextBox.Text = listOfProductsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(updateCategoryComboBox.Text).CategoryId;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            if (productDataAccess.UpdateProduct(Convert.ToInt32(updateProductIdTextBox.Text), updateProductNameTextBox.Text, Convert.ToDouble(updatePriceTextBox.Text), Convert.ToInt32(updateQuantityNumericUpDown1.Text), categoryId))
            {
                MessageBox.Show("Product updated");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
                ClearFields();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            if (productDataAccess.DeleteProduct(Convert.ToInt32(updateProductIdTextBox.Text)))
            {
                MessageBox.Show("Product deleted");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in deleting");
                ClearFields();
            }
        }

        private void searchProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            searchProductGridView.DataSource = productDataAccess.GetProductsByName(searchProductNameTextBox.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           ProductDashboard productDashboard = new ProductDashboard();
            productDashboard.Show();
            this.Hide();
        }
    }
    }

