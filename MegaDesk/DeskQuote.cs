using System;

namespace MegaDesk
{
    public class DeskQuote
    {
        #region Constructor

        /// <summary>
        /// Class to hold information about each desk quote
        /// and the calculation method for the price.
        /// </summary>
        /// <param name="orderDesk">The desk being ordered</param>
        /// <param name="orderDate">The date the order was placed</param>
        /// <param name="customerName">The name of the customer placing the order</param>
        /// <param name="orderRushDays">The production time for the order.</param>
        public DeskQuote(Desk orderDesk, DateTime orderDate, string customerName, RushDays orderRushDays)
        {
            this.orderDesk = orderDesk;
            this.orderDate = orderDate;
            this.customerName = customerName;
            this.orderRushDays = orderRushDays;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Calculated the total price of the desk based
        /// on the specs of the desk ordered and the rush time
        /// </summary>
        /// <returns>The price of the desk</returns>
        public int CalculateTotal()
        {
            int area = orderDesk.width * orderDesk.depth;
            int baseCost = 200;
            int areaCost = (area > 1000) ? area - 1000 : 0;
            int drawerCost = orderDesk.drawers * 50;
            int materialCost;
            switch (orderDesk.material)
            {
                case SurfaceMaterial.Oak:
                    materialCost = 200;
                    break;
                case SurfaceMaterial.Laminate:
                    materialCost = 100;
                    break;
                case SurfaceMaterial.Pine:
                    materialCost = 50;
                    break;
                case SurfaceMaterial.Rosewood:
                    materialCost = 300;
                    break;
                case SurfaceMaterial.Veneer:
                    materialCost = 125;
                    break;
                default:
                    materialCost = 0;
                    break;
            }

            int rushOrderCost = 0;
            if (orderRushDays != RushDays.days14)
            {
                int sizeOfDeskIndex;
                if (area < 1000) sizeOfDeskIndex = 0;
                else if (area > 2000) sizeOfDeskIndex = 2;
                else sizeOfDeskIndex = 1;

                rushOrderCost = rushOrderCostTable[(int)orderRushDays, sizeOfDeskIndex];
            }

            int totalCost = baseCost
                            + areaCost
                            + drawerCost
                            + materialCost
                            + rushOrderCost;

            return totalCost;
            
        }

        #endregion

        #region Public Fields

        public Desk orderDesk;
        public DateTime orderDate;
        public string customerName;
        public RushDays orderRushDays;
        // Array to hold the rush order price based on
        // table size and production time.
        int[,] rushOrderCostTable = new int[3,3]
        {
            { 60, 70, 80 },
            { 40, 50, 60 },
            { 30, 35, 40 }
        };

        #endregion

    }
}

public enum RushDays
{
    days3,
    days4,
    days5,
    days14
}
