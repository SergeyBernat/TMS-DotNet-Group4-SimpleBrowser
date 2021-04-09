using Flurl;
using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using TeachMeSkills.DotNet.Group4.SimpleBrowser.Api.wheather_Api;

namespace TeachMeSkills.DotNet.Group4.SimpleBrowser
{
    public partial class Form1 : Form
    {
        HttpClient httpClient = new HttpClient();
        WebBrowser web = new WebBrowser();
        int i = 0;
        public Form1(WeatherModel weather)
        {
            InitializeComponent();
            GetCurrentDayInfo(weather);
            GetInfo(weather);
        }
        public void GetCurrentDayInfo(WeatherModel weather)
        {
            pictureBox1.ImageLocation = URL_Weather.Url.AppendPathSegments("static", "img", "weather", "png", $"{weather.consolidated_weather.First().weather_state_abbr}.png");
            day1.Text = weather.title;
            currentT.Text = String.Format("{0:0}'C", weather.consolidated_weather.First().the_temp);
            dayofweek.Text = weather.time.DayOfWeek.ToString();
        }
        public void GetInfo(WeatherModel weather)
        {
            day2.Text = Convert.ToDateTime(weather.consolidated_weather.ElementAt(1).applicable_date).DayOfWeek.ToString();
            day3.Text = Convert.ToDateTime(weather.consolidated_weather.ElementAt(2).applicable_date).DayOfWeek.ToString();
            day4.Text = Convert.ToDateTime(weather.consolidated_weather.ElementAt(3).applicable_date).DayOfWeek.ToString();
            day5.Text = Convert.ToDateTime(weather.consolidated_weather.ElementAt(4).applicable_date).DayOfWeek.ToString();
            day6.Text = Convert.ToDateTime(weather.consolidated_weather.ElementAt(5).applicable_date).DayOfWeek.ToString();
            Tmin2.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(1).min_temp);
            Tmin3.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(2).min_temp);
            Tmin4.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(3).min_temp);
            Tmin5.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(4).min_temp);
            Tmin6.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(5).min_temp);
            Tmax2.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(1).max_temp);
            Tmax3.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(2).max_temp);
            Tmax4.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(3).max_temp);
            Tmax5.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(4).max_temp);
            Tmax6.Text = String.Format("{0:0}'C", weather.consolidated_weather.ElementAt(5).max_temp);
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("New page");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
            if (tabControl1.Visible != true)
            {
                tabControl1.Visible = true;
            }
            else
            {

            }
        }
        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (Search.Text != null)
            {
                try
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Search.Text);
                }
                catch (NullReferenceException)
                {
                    toolStripButton5_Click(sender, e);
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Search.Text);
                }
            }
            else
            {

            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count != 0)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count != 0)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count != 0)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                if (tabControl1.TabPages.Count != 0)
                {
                    tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                }
                i -= 1;
                if (tabControl1.Visible != true)
                {
                    tabControl1.Visible = true;
                }
                else
                {

                }
            }
            else
            {

                if (tabControl1.TabPages.Count != 0)
                {
                    tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                    i -= 1;
                }
                tabControl1.Visible = false;
            }
        }
        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Search.Text);
                }
                catch (NullReferenceException)
                {
                    toolStripButton5_Click(sender, e);
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Search.Text);
                }

            }
            if (e.KeyCode == Keys.F5)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
            }
        }
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.Visible == true)
            {
                tabControl1.Visible = false;
            }
            else
            {
                if (tabControl1.TabPages.Count != 0)
                {
                    tabControl1.Visible = true;
                }
            }
        }
        private async void getIpv4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApiOut.Text = $"ipv4: {await httpClient.GetStringAsync("https://api.ipify.org")}";
        }
    }
}
