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
    * This class contains stream form
    * </summary>
    * 
    * @class StreamForm
    */
    public partial class StreamForm : Form
    {
        /**
        * <summary>
        * This constructor builds the stream form 
        * </summary>
        * 
        * @constructor
        */
        public StreamForm(Movie movie, string total)
        {
            InitializeComponent();
            AmountLabel.Text = string.Format("Your credit card has been billed for {0}", total);
            SelectedLLabel.Text = string.Format("{0} will begin in about a minute", movie.Title);
        }

        /**
        * <summary>
        * This event handler closes the application
        * </summary>
        * 
        * @method OkButton_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
