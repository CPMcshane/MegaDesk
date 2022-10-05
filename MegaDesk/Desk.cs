using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        #region Constructor
        /// <summary>
        /// Class to hold the specs of each table orderd.
        /// </summary>
        /// <param name="width">Width of the table</param>
        /// <param name="depth">Depth of the table</param>
        /// <param name="drawers">Number of drawers on the table</param>
        /// <param name="material">The surface material of the table</param>
        public Desk(int width, int depth, int drawers, SurfaceMaterial material)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;
        }
        #endregion

        #region Public Fields

        public int width;
        public int depth;
        public int drawers;
        public SurfaceMaterial material;

        // Contraints for the allowed table size.
        public const int MAXIMUMWIDTH = 96;
        public const int MINIMUMWIDTH = 24;
        public const int MAXIMUMDEPTH = 48;
        public const int MINIMUMDEPTH = 12;

        #endregion
    }
}

public enum SurfaceMaterial
{
    Oak,
    Laminate,
    Pine,
    Rosewood,
    Veneer
}

