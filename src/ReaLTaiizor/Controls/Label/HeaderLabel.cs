﻿#region Imports

using System.Drawing;
using System.Windows.Forms;

#endregion

namespace ReaLTaiizor.Controls.Label
{
    #region HeaderLabel

    public class HeaderLabel : System.Windows.Forms.Label
    {
        public HeaderLabel()
        {
            Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            ForeColor = Color.FromArgb(255, 255, 255);
            BackColor = Color.Transparent;
        }
    }

    #endregion
}