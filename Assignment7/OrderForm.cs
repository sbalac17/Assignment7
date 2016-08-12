using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    /**
    * <summary>
    * This class contains the order form 
    * </summary>
    * 
    * @class OrderForm
    */
    public partial class OrderForm : Form
    {
        private Movie _movie;

        /**
        * <summary>
        * This constructor builds the order form 
        * </summary>
        * 
        * @constructor
        */
        public OrderForm(Movie movie)
        {
            _movie = movie;

            InitializeComponent();

            TitleTextBox.Text = movie.Title;
            CategoryTextBox.Text = movie.Category.Name;
            CoverPictureBox.Image = movie.Cover;

            CalculateOrder();
        }

        /**
        * <summary>
        * This method calculates the order amount 
        * </summary>
        * 
        * @method CalculateOrder()
        */
        private void CalculateOrder()
        {
            CostTextBox.Text = string.Format("{0:C}", _movie.Category.Cost);

            PurchaseLabel.Visible = PurchaseCheckBox.Checked;
            PurchaseTextBox.Visible = PurchaseCheckBox.Checked;

            double subtotal = _movie.Category.Cost;
            if (PurchaseCheckBox.Checked)
            {
                subtotal = subtotal + 10;
            }

            SubTotalTextBox.Text = string.Format("{0:C}", subtotal);

            double tax = subtotal * 0.13;
            SalesTaxTextBox.Text = string.Format("{0:C}", tax);

            double total = subtotal + tax;
            GrandTotalTextBox.Text = string.Format("{0:C}", total);
        }

        /**
        * <summary>
        * This event handler exits the application when all forms are closed
        * </summary>
        * 
        * @method CancelButton_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectionForm sform = new SelectionForm();
            sform.Show();
            this.Close();
        }

        /**
        * <summary>
        * This event handler exits the application when all forms are closed
        * </summary>
        * 
        * @method helpToolStripMenuItem1_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to print?", "print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /**
        * <summary>
        * This event handler exits the application when all forms are closed
        * </summary>
        * 
        * @method aboutToolStripMenuItem_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutb = new AboutBox();
            aboutb.ShowDialog();

        }

        /**
        * <summary>
        * This event handler exits the application when all forms are closed
        * </summary>
        * 
        * @method PurchaseCheckBox_CheckedChanged
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void PurchaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        /**
        * <summary>
        * This event handler exits the application when all forms are closed
        * </summary>
        * 
        * @method StreamButton_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm sform = new StreamForm(_movie, GrandTotalTextBox.Text);
            sform.Show();

            this.Close();
        }
    }
}
