using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using System.Windows.Forms;
using Lynda_Browser.Properties;

namespace Lynda_Browser
{
    public partial class Form1 : Form
    {
        int action_state = 0;
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            //Raindrops
            GeckoPreferences.User["places.history.enabled"] = false;
            GeckoPreferences.User["security.warn_viewing_mixed"] = false;
            GeckoPreferences.User["plugin.state.flash"] = 0;
            GeckoPreferences.User["browser.cache.disk.enable"] = false;
            GeckoPreferences.User["browser.cache.memory.enable"] = false;
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = false;
            GeckoPreferences.User["dom.max_script_run_time"] = 0;
            GeckoPreferences.User["browser.download.manager.showAlertOnComplete"] = false;
            GeckoPreferences.User["privacy.popups.showBrowserMessage"] = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addr_bar.Text = "https://google.it";
            polyMo.Image = Resources.menu1;
            currentPage.Text = "Google | Welcome";
            UIActivePageElement.Navigate(addr_bar.Text);
            action_state = 0;
        }

        private void refreshPageButton_Click(object sender, EventArgs e)
        {
            //Pretty self explanatory
            UIActivePageElement.Reload();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            UIActivePageElement.GoBack();
        }

        private void goForward_Click(object sender, EventArgs e)
        {
            UIActivePageElement.GoForward();
        }

        private void addr_bar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                UIActivePageElement.Navigate(addr_bar.Text);
            }
        }

        private void addr_bar_TextChanged(object sender, EventArgs e)
        {
            action_state = 1;
            polyMo.Image = Resources.play_button;

        }

        private void addr_bar_Leave(object sender, EventArgs e)
        {
            //Nil
        }

        private void polyMo_Click(object sender, EventArgs e)
        {
            if (action_state == 0) {
                // 
                menuPanel.Visible = true;
                polyMo.Image = Resources.up;
                action_state = 2;
            }
            
            else if (action_state == 2)
            {
                // Close the Menu and revert to the menu icon.
                menuPanel.Visible = false;
                polyMo.Image = Resources.menu1;
                action_state = 0;
            }
        
            else if (action_state == 1)
            {
                action_state = 0;
                UIActivePageElement.Navigate(addr_bar.Text);
                polyMo.Image = Resources.menu1;
                
            }
            
        }

        private void SaveDoc_Click(object sender, EventArgs e)
        {
            string where = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            UIActivePageElement.ShowPageProperties();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewSource_Click(object sender, EventArgs e)
        {
            UIActivePageElement.ViewSource();
        }

        private void UIActivePageElement_DomContentChanged(object sender, DomEventArgs e)
        {
            currentPage.Text = UIActivePageElement.DocumentTitle;
        }

        private void creditsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lynda Browser\nBy GeoSn0w (@FCE365)\n\nA quick example of how to integrate Gecko 45 with a C# program to build a VERY bare-bones web browser.\nAll the icons were provided by https://www.flaticon.com for free.\nFeel free to reuse the code if you wish.\n\nhttps://twitter.com/FCE365", "Lynda Browser Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
