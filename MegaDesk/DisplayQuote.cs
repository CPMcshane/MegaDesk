using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote, string material, string rushOrderDays)
        {
            this.deskQuote = deskQuote;
            this.material = material;
            this.rushOrderDays = rushOrderDays;

            InitializeComponent();
            PopulateQuoteDisplay();
        }

        public void PopulateQuoteDisplay()
        {
            CustomerNameLabel.Text = $"Name: {deskQuote.customerName}";
            OrderDateLabel.Text = $"Date: {deskQuote.orderDate}";
            WidthLabel.Text = $"Width: {deskQuote.orderDesk.width}";
            DepthLabel.Text = $"Depth: {deskQuote.orderDesk.depth}";
            DrawerLabel.Text = $"Drawers: {deskQuote.orderDesk.drawers}";
            SurfaceMaterialLabel.Text = $"Material: {material}";
            RushOrderLabel.Text = $"Production Time: {rushOrderDays}";
            TotalCostLabel.Text = $"Total Cost: ${deskQuote.CalculateTotal()}";

        }

        private DeskQuote deskQuote;
        string material;
        string rushOrderDays;
    }
}
