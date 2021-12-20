using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Part Time')]//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on salary
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion



        #region  Initialize Profile Web Elements 

        //Click on Edit name button
        [FindsBy(How = How.XPath, Using = "(//*[@class='dropdown icon'])[2]")]
        private IWebElement EditName { get; set; }

        //Click on Edit first name button
        [FindsBy(How = How.XPath, Using = "//*[@name='firstName']")]
        private IWebElement FirstName { get; set; }

        //Click on Edit last name button
        [FindsBy(How = How.XPath, Using = "//*[@name='lastName']")]
        private IWebElement LastName { get; set; }

        //Click on Save name button
        [FindsBy(How = How.XPath, Using = "(//*[@class='ui teal button'])[1]")]
        private IWebElement SaveName { get; set; }

        //Click on Edit availability button
        [FindsBy(How = How.XPath, Using = "(//*[@class='right floated outline small write icon'])[1]")]
        private IWebElement EditAvailability { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "//*[@name='availabiltyType']")]
        private IWebElement Availability { get; set; }

        //Click on Edit availability hour button
        [FindsBy(How = How.XPath, Using = "(//*[@class='right floated outline small write icon'])[2]")]
        private IWebElement EditAvailableHour { get; set; }

        //Click on Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@name='availabiltyHour']")]
        private IWebElement AvailabilityHour { get; set; }

        //Click on Edit Earn Target button
        [FindsBy(How = How.XPath, Using = "(//*[@class='right floated outline small write icon'])[3]")]
        private IWebElement EarnTargetEdit { get; set; }

        //Click enter target
        [FindsBy(How = How.XPath, Using = "//*[@name='availabiltyTarget']")]
        private IWebElement EarnTarget { get; set; }


        //Click Edit description
        [FindsBy(How = How.XPath, Using = "(//*[@class='outline write icon'])[1]")]
        private IWebElement EditDescription { get; set; }

        //Click Save description
        [FindsBy(How = How.XPath, Using = "(//*[@class='ui teal button'])[2]")]
        private IWebElement SaveDescription { get; set; }

        //Click Enter description
        [FindsBy(How = How.XPath, Using = "(//*[@name='value'])")]
        private IWebElement EnterDescription { get; set; }

        #endregion


        internal void EditProfile()
        {
            // Populate the data saved in Excel to Collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='account-profile-section']"), 10);
            int rowNum = 2;

            // Enter User Name
            Task.WaitAll(Task.Delay(2000));
            EditName.Click();
            FirstName.Clear();
            LastName.Clear();
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "FirstName"));
            LastName.Clear();
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "LastName"));
            SaveName.Click();

            //Enter availability
            Task.WaitAll(Task.Delay(1000));
            EditAvailability.Click();
            new SelectElement(Availability).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityType"));

            ////Enter availabile hours
            Task.WaitAll(Task.Delay(1000));
            EditAvailableHour.Click();
            new SelectElement(AvailabilityHour).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityHours"));

            ////Enter Earn target
            Task.WaitAll(Task.Delay(1000));
            EarnTargetEdit.Click();
            new SelectElement(EarnTarget).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "EarnTarget"));
           // GlobalDefinitions.driver.Navigate().Refresh();

            // Enter Description
            Task.WaitAll(Task.Delay(3000));
            EditDescription.Click();
            EnterDescription.Clear();
            EnterDescription.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description"));
            SaveDescription.Click();

        }

        internal void VerifyEditProfile()
        {
           // Populate the data saved in Excel to Collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
             int rowNum = 2;

            //Verify Name
            Task.WaitAll(Task.Delay(1000));
            string ExpectedFirstName = GlobalDefinitions.ExcelLib.ReadData(rowNum, "FirstName").ToString();
            string ExpectedLastName = GlobalDefinitions.ExcelLib.ReadData(rowNum, "LastName").ToString();
            string ExpectedName = ExpectedFirstName + " " + ExpectedLastName;
            IWebElement Name = GlobalDefinitions.driver.FindElement(By.XPath("   //*[text()='" + ExpectedName + "']"));
            string ActualName = Name.GetAttribute("innerText");
            GlobalDefinitions.wait(10);
            Assert.AreEqual(ActualName, ExpectedName);
            bool result = true;
            // Verify Availability type hours and target
            if (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityType")) &&
                (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityHours")) &&
                (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "EarnTarget")))))
            {
                Assert.IsTrue(result);

            }
            else
            {
                Assert.Fail("Data is incorrect");

            }

            // Verify Desciption
            if (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description")))
            {

                Assert.Pass("Verified correctly");

            }
            else
            {
                Assert.Fail("Description not present");

            }
        }

    }
}