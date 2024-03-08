using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
namespace selenium_tests;

public class SeleniumTest
{
    public ChromeOptions options;
    public IWebDriver driver;

    //created a class SeleniumFuctions to include functions used in tests
    public SeleniumFunctions seleniumFunctions;

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup");
        driver = new ChromeDriver();  //chrome driver initialization

        // options = new ChromeOptions();
        // options.AddArgument("--headless"); // Run in headless mode without opening a browser window
        // options.AddArgument("--window-size=1366,768");
        // // // Initialize ChromeDriver with headless options
        // driver = new ChromeDriver(options);
        seleniumFunctions = new SeleniumFunctions(); //creating object of class containing fucntion
        // driver.Navigate().GoToUrl("https://andromeda-identity-qa.axonator.com/"); https://app.axonator.com/
        driver.Navigate().GoToUrl("https://andromeda-builder-qa.axonator.com/");
        driver.Manage().Window.Maximize();
        

    }

    [Test]
    [Category("Selenium")]
    public void firstTest()
    {
        
        // seleniumFunctions.signUp(driver,"yash","lunkad","yash2@axonator.com","1234","axonator","7448125003", "desc");
        seleniumFunctions.login(driver,"yash1@axonator.com","Welcome@12345");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        seleniumFunctions.createApp(driver);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        seleniumFunctions.createForm(driver,"safety");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        seleniumFunctions.addTextBox(driver,"sample_text");
        seleniumFunctions.saveForm(driver);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        seleniumFunctions.release_app(driver);
        seleniumFunctions.release_app(driver);
        Assert.Pass();
    }

    [TearDown]
    public void Teardown()
    {
        // driver.Quit();
    }



    


    
}
