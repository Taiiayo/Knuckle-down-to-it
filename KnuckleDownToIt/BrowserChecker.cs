using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using Timer = System.Windows.Forms.Timer;

namespace KnuckleDownToIt
{
    class BrowserChecker
    {
        readonly List<string> listOfDirtyApps;
        private char[] tempStringUrlArray;
        private string tempStringUrl = "";
        private ChromeDriver chromeDriver;
        private readonly Timer checkBrowserTimer;

        public BrowserChecker(List<string> list)
        {
            checkBrowserTimer = new Timer();
            checkBrowserTimer.Tick += DoOnCheckBrowserTick;
            checkBrowserTimer.Interval = 1000;

            listOfDirtyApps = list;
        }
        public void DoOnCheckBrowserTick(object sender, EventArgs e)
        {
            if (chromeDriver.WindowHandles.Count == 1)
            {
                tempStringUrlArray = chromeDriver.Url.ToCharArray();
                for (int i = 8; i < tempStringUrlArray.Length; i++)
                {
                    if (tempStringUrlArray[i] != '/')
                    {
                        tempStringUrl += tempStringUrlArray[i];
                    }
                    else
                    {
                        break;
                    }
                }
                foreach (string url in listOfDirtyApps)
                {
                    if (tempStringUrl.Equals(url))
                    {
                        chromeDriver.Navigate()
                            .GoToUrl(
                                "https://ru.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D0%BA%D1%80%D0%B0%D1%81%D1%82%D0%B8%D0%BD%D0%B0%D1%86%D0%B8%D1%8F");
                    }
                }
                tempStringUrl = "";
            }
            else
            {
                checkBrowserTimer.Stop();

                DialogResult dialogResult = MessageBox.Show("Press yes to close browser or press no and close other tabs but first",
                    "Only one-tab sessions allowed ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.Yes)
                {
                    Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(1000);
                        checkBrowserTimer.Stop();

                        chromeDriver.Quit();
                    });
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("15 seconds to close other tabs", "Warning");
                    Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(10000);

                        if (chromeDriver.WindowHandles.Count > 1)
                        {
                            checkBrowserTimer.Stop();
                            chromeDriver.Quit();
                        }
                    });
                }
            }
        }

        public void StartSafeChrome()
        {
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            chromeDriver = new ChromeDriver();
            checkBrowserTimer.Start();
        }
    }
}
