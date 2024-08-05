using com.sun.tools.@internal.xjc.reader.gbind;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemoProject1.Pom
{
    public class pom1
    {
        public IWebDriver _driver;

        public void scrolldown_element(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                element.Click();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void e_click(IWebDriver driver, IWebElement element)
        {
            try
            {
                bool isvisible = element.Displayed;
                if (isvisible)
                {
                    element.Click();
                }
                else
                {
                    Console.WriteLine("Element is not visible");

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void hoverandclick(IWebDriver driver, IWebElement element, IWebElement subelement)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Perform();
                actions.MoveToElement(subelement).Click().Perform();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void change_window(IWebDriver driver)
        {
            try
            {
                string originalWindow = driver.CurrentWindowHandle;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                IReadOnlyCollection<string> all_windows = driver.WindowHandles;
                foreach (string window in all_windows)
                {
                    if (window != originalWindow)
                    {

                        driver.SwitchTo().Window(window);
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void sendvalue(IWebDriver driver, IWebElement element, String key)
        {
            try
            {
                bool isenable = element.Enabled;
                bool isvisible = element.Displayed;
                if (isenable)
                {
                    if (isvisible)
                    {
                        element.SendKeys(key);
                    }

                }
                else
                {
                    Console.WriteLine("the element is not allow the send keys");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void scroll(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,100);");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void screenShot(IWebDriver driver, IWebElement filename , string name)
        {
            try
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string title = ScenarioContext.Current.ScenarioInfo.Title;
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string ssFileName = "C:\\Users\\HariharanNagarajan\\source\\repos\\SpecFlowDemoProject1\\SpecFlowDemoProject1\\Screenshot\\" + name + " " + timestamp + ".png";
                screenshot.SaveAsFile(ssFileName);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
    }
