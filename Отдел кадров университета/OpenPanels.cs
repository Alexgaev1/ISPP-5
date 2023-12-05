using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Отдел_кадров_университета
{
    static internal class OpenPanels
    {
        public static void openPanels(TableLayoutPanel tableLayoutPanel, int indexOfPanel)
        {
            (int column, int row) = GetIndexColumnAndRowIndexOfPanel(indexOfPanel);

            tableLayoutPanel.ColumnStyles[column] = new ColumnStyle(SizeType.Percent, 100);
            tableLayoutPanel.RowStyles[row] = new RowStyle(SizeType.Percent, 100);

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                if (i != column)
                {
                    tableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Absolute, 0);
                }
            }

            for (int j = 0; j < tableLayoutPanel.RowCount; j++)
            {
                if (j != row)
                {
                    tableLayoutPanel.RowStyles[j] = new RowStyle(SizeType.Absolute, 0);
                }
            }
        }

        static (int column, int row) GetIndexColumnAndRowIndexOfPanel(int indexOfPanel)
        {
            int column = 0;
            int row = 0;

            switch (indexOfPanel)
            {
                case 0: column = 0; row = 0; break;
                case 1: column = 1; row = 0; break;
                case 2: column = 2; row = 0; break;
                case 3: column = 3; row = 0; break;
                case 4: column = 0; row = 1; break;
                case 5: column = 1; row = 1; break;
                case 6: column = 2; row = 1; break;
                case 7: column = 3; row = 1; break;
                case 8: column = 0; row = 2; break;
            }

            return (column, row);
        }

    }
}
