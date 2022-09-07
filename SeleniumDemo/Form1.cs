using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumDemo
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            driver = CreateDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Url = "https://bssurvey-beta.azurewebsites.net/";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            var signinButton = driver.FindElement(By.ClassName("nav-item"));
            signinButton.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("LoginInput_UserNameOrEmailAddress")));
            
            var usernameElement = driver.FindElement(By.Id("LoginInput_UserNameOrEmailAddress"));
            usernameElement.SendKeys("Admin");
            
            var passwordElement = driver.FindElement(By.Id("LoginInput_Password"));
            passwordElement.SendKeys("1q2w3E*");
            
            var loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            loginButton.Click();
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("open-surveys-count-lbl")));
                txtResults.Text = "Logged in successfully...\n";
            }
            catch (Exception)
            {
                txtResults.Text = "Login failed...\n";
            }
        }

        private void btnGetStatistics_Click(object sender, EventArgs e)
        {
            txtResults.Text += $"Open Surveys: {driver.FindElement(By.ClassName("open-surveys-count-lbl")).Text}\n";
            txtResults.Text += $"Drafted Surveys: {driver.FindElement(By.ClassName("draft-surveys-count-lbl")).Text}\n";
            txtResults.Text += $"Closed Surveys: {driver.FindElement(By.ClassName("closed-surveys-count-lbl")).Text}\n";
            txtResults.Text += $"Total Responses: {driver.FindElement(By.ClassName("total-responses-count-lbl")).Text}\n";
        }

        public static IWebDriver CreateDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            service.SuppressInitialDiagnosticInformation = true;

            return new ChromeDriver(service, options);
        }

        private void btnGetScreenShot_Click(object sender, EventArgs e)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("Image.png",ScreenshotImageFormat.Png);
            Process.Start("Image.png");
        }
    }
}
