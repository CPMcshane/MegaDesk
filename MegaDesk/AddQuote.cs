using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        #region Constructor

        public AddQuote()
        {
            InitializeComponent();
        }

        #endregion

        #region Non-Public Methods

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool IsError = false;
            ErrorMessageLabel.Visible = false;
            ErrorMessageLabel.Text = "";
            string ErrorMessage = "Error: ";

            try
            {
                width = int.Parse(WidthTextBox.Text);
                depth = int.Parse(DepthTextBox.Text);
            }
            catch (FormatException ex)
            {
                Debug.WriteLine(ex);
                ErrorMessage += "Must enter a width and depth.";
                ErrorMessageLabel.Text = ErrorMessage;
                ErrorMessageLabel.Visible = true;
                return;
            }

            if (width < Desk.MINIMUMWIDTH || width > Desk.MAXIMUMWIDTH)
            {
                ErrorMessage += "Width must be between 24 and 96 inches. ";
                IsError = true;
            }
            if (depth < Desk.MINIMUMDEPTH || depth > Desk.MAXIMUMDEPTH)
            {
                ErrorMessage += "\nDepth must be between 12 and 48 inches.";
                IsError = true;
            }
            if (IsError)
            {
                ErrorMessageLabel.Text = ErrorMessage;
                ErrorMessageLabel.Visible = true;
                return;
            }

            try
            {
                drawers = int.Parse(DrawerCombobox.Text);
                material = (SurfaceMaterial)SurfaceMaterialCombobox.SelectedIndex;
                orderName = CustomerNameTextBox.Text;
                rushDays = (RushDays)ProductionTimeCombobox.SelectedIndex;

                if (SurfaceMaterialCombobox.SelectedIndex == -1 || ProductionTimeCombobox.SelectedIndex == -1)
                {
                    throw new Exception("Comboboxes have no selection");
                }
                if (orderName == "")
                {
                    throw new Exception("Name not entered");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage += "Comboxes and Name must be filled out";
                ErrorMessageLabel.Text = ErrorMessage;
                ErrorMessageLabel.Visible = true;
                Debug.WriteLine(ex.Message);
                return;
            }
            Desk orderDesk = new Desk(width, depth, drawers, material);                               
            DateTime orderDate = DateTime.Now;

            DeskQuote quote = new DeskQuote(orderDesk, orderDate, orderName, rushDays);
            DisplayQuote displayQuoteView = new DisplayQuote(quote, SurfaceMaterialCombobox.Text, ProductionTimeCombobox.Text);
            displayQuoteView.Show();
        }

        #endregion

        #region Non-public Fields

        private int depth;
        private int width;
        private int drawers;
        private SurfaceMaterial material;
        private string orderName;
        private RushDays rushDays;

        #endregion
    }
}
