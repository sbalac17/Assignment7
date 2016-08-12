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
    * This class contains the selection form
    * </summary>
    * 
    * @class SelectionForm
    */
    public partial class SelectionForm : Form
    {

        /**
        * <summary>
        * This constructor builds the selection form
        * </summary>
        * 
        * @constructor
        */
        public SelectionForm()
        {
            InitializeComponent();
            MovieDropDownList.DataSource = Movie.List;
            MovieDropDownList.DisplayMember = "Title";
        }

        /**
        * <summary>
        * This event handler updates the movie information when selecting a different one 
        * </summary>
        * 
        * @method MovieDropDownList_SelectedValueChanged
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void MovieDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)MovieDropDownList.SelectedItem;
            TitleTextBox.Text = movie.Title;
            CategoryTextBox.Text = movie.Category.Name;
            CostTextBox.Text = string.Format("{0:C}", movie.Category.Cost);
            CoverPictureBox.Image = movie.Cover;
        }

        /**
        * <summary>
        * This event handler opens the order form 
        * </summary>
        * 
        * @method NextButton_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void NextButton_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)MovieDropDownList.SelectedItem;
            OrderForm order = new OrderForm(movie);
            order.Show();

            this.Close();
        }
    }
}
