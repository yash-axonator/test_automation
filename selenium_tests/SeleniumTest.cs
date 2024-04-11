using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Threading;
namespace selenium_tests;

public class SeleniumTest
{
    public ChromeOptions options;
    public IWebDriver driver;

    //created a class SeleniumFuctions to include functions used in tests
    public SeleniumFunctions seleniumFunctions;
    public ContainerFunctions containerFunctions;
    public static TestLogger testLogger = new TestLogger();

    public string reportPath = "./TestReport.html";

    

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup \n");
        // driver = new ChromeDriver();  //chrome driver initialization

        options = new ChromeOptions();
        // options.AddArgument("--headless"); // Run in headless mode without opening a browser window
        options.AddArgument("--window-size=1366,768");
        // // // Initialize ChromeDriver with headless options
        driver = new ChromeDriver(options);
        seleniumFunctions = new SeleniumFunctions(); //creating object of class containing fucntion
        containerFunctions = new ContainerFunctions(); //container page fucntions
        // driver.Navigate().GoToUrl("https://andromeda-identity-qa.axonator.com/"); https://app.axonator.com/
        // driver.Navigate().GoToUrl("https://andromeda-builder-qa.axonator.com/");
        driver.Navigate().GoToUrl("https://builder.axonator.com/");
        driver.Manage().Window.Maximize();
        

    }

    
    
    [Test]
    [Category("Selenium")]
    public void firstTest()
    {
               
       

        // seleniumFunctions.signUpQA(driver,"yash","lunkad","yashlunkad2121@axonator.com","Welcome@12345","India","Manufacturing","axonator","7448125003", "descdescdescdescdescdescdescdescdescdescdescdescdesc");
        seleniumFunctions.login(driver,"yash_test_x1_release@axonator.com","Welcome@12345",ref testLogger); //prod user
        // seleniumFunctions.login(driver,"yashlunkad2121@gmail.com","Welcome@12345"); 
        Thread.Sleep(TimeSpan.FromSeconds(5));
        // driver.Navigate().GoToUrl("https://builder-qa.axonator.com/");
        // seleniumFunctions.login(driver,"yash_test5@axonator.com","Welcome@12345"); //QA 
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.closePopUp2(driver);
        seleniumFunctions.closePopUp1(driver);
        seleniumFunctions.closePopUp2(driver);
        seleniumFunctions.closePopUp1(driver);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.createAppQA(driver,ref testLogger);
        Thread.Sleep(TimeSpan.FromSeconds(10));
        seleniumFunctions.createFormQA(driver,"safety",ref testLogger);
        Thread.Sleep(TimeSpan.FromSeconds(10));
        seleniumFunctions.addTextBoxQA(driver,"sample_text","Email","textbox_unique",ref testLogger);
        string[] choice_items = new string[] { "To Do", "In Progress", "Completed" };
        seleniumFunctions.addChoiceListQA(driver,choice_items,"Choice List",ref testLogger);
          
        Thread.Sleep(TimeSpan.FromSeconds(2));
        
        seleniumFunctions.addChoiceListQA(driver,"choice_label1",ref testLogger);
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addGroupHeaderQA(driver,"group header title",5,ref testLogger);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addPhotoQA(driver,"photo_label",ref testLogger);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addToggleQA(driver,"toggle_label","toggle_placeholder",ref testLogger);
        seleniumFunctions.addDateTimeQA(driver," Date",ref testLogger);
        seleniumFunctions.addGpsQA(driver," On Tap",ref testLogger);
        seleniumFunctions.addTimeStampQA(driver," On Open",ref testLogger);
        seleniumFunctions.addChildRecordQA(driver,ref testLogger);
        seleniumFunctions.addStaticMediaQA(driver,ref testLogger);  
        seleniumFunctions.addQrCodeQA(driver," Default",ref testLogger);
        seleniumFunctions.addStopWatchQA(driver,"5",ref testLogger);
        seleniumFunctions.addCounterQA(driver,"number","5",ref testLogger);
        seleniumFunctions.addGeoFenceQA(driver,"5",ref testLogger);
        // seleniumFunctions.addApplyGeoFenceQA(driver);
        seleniumFunctions.addBarcodeQA(driver,ref testLogger);
        seleniumFunctions.addDocumentQA(driver," doc","5",ref testLogger);
        seleniumFunctions.addAudioQA(driver,ref testLogger);
        seleniumFunctions.addVideoQA(driver,ref testLogger);
        seleniumFunctions.addFormulaQA(driver,ref testLogger);
        seleniumFunctions.addLanguageQA(driver,ref testLogger);
        seleniumFunctions.addWebLinkQA(driver,"https://andromeda-builder-qa.axonator.com/",ref testLogger);
        seleniumFunctions.addUniqueIdQA(driver,ref testLogger);
        seleniumFunctions.addAutoNumberQA(driver,"5",ref testLogger);

        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.saveFormQA(driver,ref testLogger);

        Thread.Sleep(TimeSpan.FromSeconds(20));
        seleniumFunctions.release_app_QA(driver,ref testLogger);

        
        //  var tabs = driver.WindowHandles;

        // // Switch to the new tab
        // driver.SwitchTo().Window(tabs[1]);

        // Thread.Sleep(TimeSpan.FromSeconds(5));
        // driver.Navigate().GoToUrl("https://container.axonator.com/apps");
        // Thread.Sleep(TimeSpan.FromSeconds(40));
        // containerFunctions.selectApp(driver," Untitled App 1","Untitled Form");
        //  Thread.Sleep(TimeSpan.FromSeconds(20));
        // containerFunctions.addText(driver,"hello@gmail.com","email");
        // containerFunctions.uploadPhoto(driver);
        // containerFunctions.selectChoice(driver,"Choice List","To Do");
        // containerFunctions.toggleChange(driver);
        //  Thread.Sleep(TimeSpan.FromSeconds(10));
        // containerFunctions.setDateTime(driver,"2024","MAY","2");
        // string filePath = "/home/l21/Downloads/doc.pdf";
        // containerFunctions.uploadDocument(driver,filePath);
        // containerFunctions.gpsLocateMe(driver);
        // containerFunctions.addChildRecord(driver,"yash@gmail.com");
        // containerFunctions.stopWatch(driver,10);
        // containerFunctions.incCounter(driver,10);
        // // containerFunctions.addUniqueId(driver);
        // // containerFunctions.uploadVideo(driver,"/home/l21/Downloads/video (2160p).mp4");
        // containerFunctions.submitForm(driver);
        // Thread.Sleep(TimeSpan.FromSeconds(5));

        // containerFunctions.viewFormData(driver,"Untitled Form");
        // containerFunctions.exportData(driver);
        
        
        //X1


        // seleniumFunctions.signUpQA(driver,"yash","lunkad","yash_test_x1_release@axonator.com","Welcome@12345","India","Manufacturing","axonator","7448125003", "descdescdescdescdescdescdescdescdescdescdescdescdesc");
        // // seleniumFunctions.login(driver,"yash1@axonator.com","Welcome@12345"); //prod user
        // // // Thread.Sleep(TimeSpan.FromSeconds(5));
        // // driver.Navigate().GoToUrl("https://qa.axonator.com/");
        // // seleniumFunctions.login(driver,"yash_test5@axonator.com","Welcome@12345"); //QA 
        // Thread.Sleep(TimeSpan.FromSeconds(30));
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        // Thread.Sleep(TimeSpan.FromSeconds(5));
        // seleniumFunctions.createApp(driver);
        // Thread.Sleep(TimeSpan.FromSeconds(10));
        // seleniumFunctions.createForm(driver,"safety");
        // Thread.Sleep(TimeSpan.FromSeconds(20));
        // seleniumFunctions.addTextBox(driver,"sample_text");
        // string[] choice_items = new string[] { "To Do", "In Progress", "Completed" };
        // seleniumFunctions.addChoiceList(driver,choice_items,"Choice List");
          
        // // Thread.Sleep(TimeSpan.FromSeconds(2));
        
        // // // seleniumFunctions.addChoiceListQA(driver,"choice_label1");
        // // // seleniumFunctions.scrollDown(driver);
        // seleniumFunctions.addGroupHeader(driver,"group header title",5);
        // Thread.Sleep(TimeSpan.FromSeconds(5));
        // // // seleniumFunctions.scrollDown(driver);
        // seleniumFunctions.addPhoto(driver,"photo_label");
    
        // Thread.Sleep(TimeSpan.FromSeconds(5));
        // seleniumFunctions.saveForm(driver);

        // Thread.Sleep(TimeSpan.FromSeconds(20));
        // seleniumFunctions.release_app(driver);

        

        Assert.Pass("test successful");
    }

    // [OneTimeTearDown]
    // public void GenerateReport()
    // {
    //     testLogger.GenerateHtmlReport("TestReport.html");
    // }

    [TearDown]
    public void Teardown()
    {
         
        // testLogger.GenerateHtmlReport("TestReport.html");    
        

    try
    {
    testLogger.GenerateHtmlReport("/home/l21/Documents/qa_automation/selenium_tests/bin/Debug/net8.0/TestReport.html");
    }
    catch (UnauthorizedAccessException ex)
    {
    Console.WriteLine($"Error: Unauthorized access to the report file: {ex.Message}");
    }
    catch (IOException ex)
    {
    Console.WriteLine($"Error: IO exception occurred: {ex.Message}");
    }   
        // driver.Quit();
    }



    


    
}
