//Inside SeleniumTest.cs

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;

namespace EtsTest

{
    public class EtsTurTests

    {
        
        IWebDriver driver;

        [SetUp]

        public void Setup()

        {

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;


            driver = new ChromeDriver(path + @"\drivers\");
            driver.Url = "https://www.etstur.com/";


        }

        [Test]

        public void listHotels()

        {
            //Click on the search box

            IWebElement firstSearchBox = driver.FindElement(By.Id("tb-autocomplete"));
            firstSearchBox.Click();

            //Click on the featured hotel option

            IWebElement secondFeaturedOptions = driver.FindElement(By.CssSelector(".autocomplete-result ul li"));
            secondFeaturedOptions.Click();

            //Click the check-in button

            IWebElement thirdCheckInOpen = driver.FindElement(By.ClassName("date-pipe-right"));
            thirdCheckInOpen.Click();

            System.Threading.Thread.Sleep(2000);
            //Click the check-in date

            IWebElement fourthCheckInDate = driver.FindElement(By.ClassName("today"));
            fourthCheckInDate.Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement fifthCheckOutDate = driver.FindElement(By.ClassName("today"));
            fifthCheckOutDate.Click();

            //Click the search button

            IWebElement sixthSearchButton = driver.FindElement(By.ClassName("btn-search"));
            sixthSearchButton.Click();
            System.Threading.Thread.Sleep(2000);
            //Click the hotel

            IWebElement seventhClickHotel = driver.FindElement(By.ClassName("etsfonticon-arrow-link"));
            seventhClickHotel.Click();

            System.Threading.Thread.Sleep(5000);
            //Click the hotel room

            IWebElement eighthClickRoom = driver.FindElement(By.ClassName("etsfonticon-arrow-link"));
            eighthClickRoom.Click();

            System.Threading.Thread.Sleep(2000);

            //Hotel reservation form
            /*
             IWebElement name = driver.FindElement(By.Id("tb-name_0_0"));
               name.Click();
               name.SendKeys("Mustafa");

               IWebElement surName = driver.FindElement(By.Id("tb-surname_0_0"));
               surName.Click();
               surName.SendKeys("Sami");

               IWebElement birthDate = driver.FindElement(By.Id("tb-birthdate_0_0"));

               birthDate.SendKeys("0101200");

               IWebElement email = driver.FindElement(By.Id("tb-email_0_0"));

               email.SendKeys("mustafas@etstur.com");

               IWebElement phone = driver.FindElement(By.Id("contactFormPhoneNumber-g1"));

               phone.SendKeys("9999999999");


               IWebElement idNumber = driver.FindElement(By.Id("tckn_0_0"));

               idNumber.SendKeys("99999999999");
   */



        }






        [TearDown]

        public void TearDown()

        {

            driver.Quit();

        }

    }

}
