/*
 * File Name: patel5k9_Assignment 10
* Name:Kush Patel
* email: Patel5k9@mail.uc.edu
* Assignment Number: Assignment 10
* Due Date:   4/10/2025
* Course #/Section: IS3050 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment: This assignment involves Re-create my submission from Assignment 02 as an ASP.Net web page in .aspx format. Using ASP.Net web controls where appropriate to replace the standard HTML controls I originally used.
* Brief Description of what this module does: This module This module focuses on showcasing the understanding of ASP.NET Web Forms page with images, statistics, and interactive elements.
* Citations: https://www.youtube.com/watch?v=cLr4_CgWqPM&ab_channel=VereMiller (to learn how to add IMG on a Mac)
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace patel5k9_Assignment10
{
    public partial class patel5k9_Assignment10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                LoadHighlights();
                LoadStatistics();
            
        }
            private void LoadHighlights()
            {
                HighlightsList.Items.Add(new ListItem("Former Captain of the Indian Cricket Team"));
                HighlightsList.Items.Add(new ListItem("Over 70 International Centuries"));
                HighlightsList.Items.Add(new ListItem("Winner of the ICC Cricketer of the Year Award"));
                HighlightsList.Items.Add(new ListItem("Key player in India's 2011 World Cup Victory"));
            }

            private void LoadStatistics()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Format");
                dt.Columns.Add("Matches");
                dt.Columns.Add("Runs");
                dt.Columns.Add("Average");

                dt.Rows.Add("Test", "111", "8676", "49.5");
                dt.Rows.Add("ODI", "265", "12300", "57.5");
                dt.Rows.Add("T20", "115", "4008", "52.7");

                StatsGrid.DataSource = dt;
                StatsGrid.DataBind();
            }
            protected void LinkButtonICC_Click(object sender, EventArgs e)
            {
                Response.Redirect("https://www.icc-cricket.com/rankings/mens/player-rankings/164");
            }

            protected void ButtonICC_Click(object sender, EventArgs e)
            {
                Response.Redirect("https://www.icc-cricket.com/rankings/mens/player-rankings/164");
            }


    }
}