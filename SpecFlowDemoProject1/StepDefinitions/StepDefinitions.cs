using AventStack.ExtentReports.Model;
using Azure;
using com.sun.tools.javac.util;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowDemoProject1.Pom;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoProject1.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
       public IWebDriver driver;
        pom1 page = new pom1();
        public StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"user must launch the Url")]
        public void GivenUserMustLaunchTheUrl()
        {
            //driver = new ChromeDriver();
            driver.Url = "https://www.ajio.com/";
            //driver.Manage().Window.Maximize();

        }

        [When(@"user select the Mens for selecting items")]
        public void WhenUserSelectTheMensForSelectingItems()
        {

            IWebElement men = driver.FindElement(By.XPath("//span[text()='MEN']"));
            IWebElement Jean = driver.FindElement(By.XPath("//a[@title='Jeans']"));
            Thread.Sleep(3000);
            page.hoverandclick(driver,men, Jean);
            Thread.Sleep(2000);
            page.screenShot(driver, men, "Mensection");
            
        }
        [When(@"user click the men in gender")]
        public void WhenUserClickTheMenInGender()
        {
            IWebElement gender = driver.FindElement(By.XPath("//label[@class='facet-linkname facet-linkname-genderfilter facet-linkname-Men']"));
            page.e_click(driver,gender);
            Thread.Sleep(3000);
            page.screenShot(driver,gender, "GENDER");
            Thread.Sleep(2000);

        }

        [When(@"user click the jeans in  category")]
        public void WhenUserClickTheJeansInCategory()
        {
            
            IWebElement category = driver.FindElement(By.XPath("//label[@class='facet-linkname facet-linkname-l1l3nestedcategory facet-linkname-Men - Jeans']"));
            page.e_click(driver, category);
            Thread.Sleep(2000);
            page.screenShot(driver, category, "CATEGORY");

        }

        [When(@"user selecting U\.S polo jean")]
        public void WhenUserSelectingU_SPoloJean()
        {
            page.scroll(driver);
            IWebElement USJean = driver.FindElement(By.XPath("//img[@alt='Product image of U.S. Polo Assn. Mens Brandon Mid-Wash Slim Tapered Jeans']"));
            page.scrolldown_element(driver,USJean);
            Thread.Sleep(2000);
            page.screenShot(driver,USJean, "US JEAN");
            page.change_window(driver);
            Thread.Sleep(2000);

        }

        [When(@"user must click  size")]
        public void WhenUserMustClickSize()
        {
            page.scroll(driver);
            IWebElement size = driver.FindElement(By.XPath("//span[text()='36']"));
            Thread.Sleep(3000);
            page.screenShot(driver, size,"SIZE");
            page.e_click(driver,size);
            
        }

        [When(@"user move on the selected jean in added to Bag")]
        public void WhenUserMoveOnTheSelectedJeanInAddedToBag()
        {
            page.scroll(driver);
            IWebElement addtobag = driver.FindElement(By.XPath("//span[text()='ADD TO BAG']"));
            Thread.Sleep(2000);
            page.screenShot(driver, addtobag, "Added to bag");
            page.e_click(driver,addtobag);
            Thread.Sleep(8000);

        }

        [When(@"user click go to bag")]
        public void WhenUserClickGoToBag()
        {
          IWebElement go_to_bag=  driver.FindElement(By.XPath("//span[text()='GO TO BAG']"));
            page.screenShot(driver,go_to_bag,"Go to Bag");
            page.e_click(driver,go_to_bag);
            Thread.Sleep(2000);
        }

        [When(@"user click proceded to shipping for proceding the item")]
        public void WhenUserClickProcededToShippingForProcedingTheItem()
        {
            IWebElement proceding = driver.FindElement(By.XPath("//div[@class='button-wrapper cart-fixed-button']/child::button[text()='Proceed to shipping']"));
            Thread.Sleep(2000);
            page.screenShot(driver, proceding,"Proceding");
            page.e_click(driver, proceding);
        }

        [Then(@"user enter the mobile number")]
        public void ThenUserEnterTheMobileNumber()
        {
           IWebElement mobile = driver.FindElement(By.XPath("//input[@class='username remove-phonenumber-flownumberfield']"));
            String mobileNumber = "1111222233";
            Thread.Sleep(5000);
            page.sendvalue(driver,mobile, mobileNumber);
            page.screenShot(driver, mobile,"Mobile number");
            Thread.Sleep(5000);
            //driver.Quit();

        }
    }
}

