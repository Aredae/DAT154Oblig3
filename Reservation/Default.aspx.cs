using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reservation.DAL;
using System.Data.Entity;

namespace Reservation
{
    public partial class _Default : Page
    {
        HotelContext dx = new HotelContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            dx.Rooms.Load();

            GridView1.DataSource = dx.Rooms.Local;

        }

    }
}