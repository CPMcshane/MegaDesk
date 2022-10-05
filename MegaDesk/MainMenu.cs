using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        #region Constructor

        public MainMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Non-Public Methods

        private void AddQuoteNavButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteNav = new AddQuote();
            addQuoteNav.Tag = this;
            addQuoteNav.Show(this);
            this.Hide();
        }
        private void ViewAllQuotesNavButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesNav = new ViewAllQuotes();
            viewAllQuotesNav.Tag = this;
            viewAllQuotesNav.Show(this);
            this.Hide();
        }

        private void SearchQuotesNavButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesNav = new SearchQuotes();
            searchQuotesNav.Tag = this;
            searchQuotesNav.Show(this);
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
