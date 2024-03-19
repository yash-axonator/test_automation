﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Threading;
namespace selenium_tests;

public class SeleniumTest
{
    public ChromeOptions options;
    public IWebDriver driver;

    //created a class SeleniumFuctions to include functions used in tests
    public SeleniumFunctions seleniumFunctions;
    public ContainerFunctions containerFunctions;

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
        containerFunctions = new ContainerFunctions(); //container page fucntions
        // driver.Navigate().GoToUrl("https://andromeda-identity-qa.axonator.com/"); https://app.axonator.com/
        driver.Navigate().GoToUrl("https://andromeda-builder-qa.axonator.com/");
        driver.Manage().Window.Maximize();
        

    }

    [Test]
    [Category("Selenium")]
    public void firstTest()
    {
        
        // seleniumFunctions.signUpQA(driver,"yash","lunkad","yash_test5@axonator.com","Welcome@12345","India","Manufacturing","axonator","7448125003", "descdescdescdescdescdescdescdescdescdescdescdescdesc");
        // seleniumFunctions.login(driver,"yash1@axonator.com","Welcome@12345"); //prod user
        // Thread.Sleep(TimeSpan.FromSeconds(5));
        // driver.Navigate().GoToUrl("https://andromeda-builder-qa.axonator.com/");
        seleniumFunctions.login(driver,"yash_test5@axonator.com","Welcome@12345"); //QA 
        // Thread.Sleep(TimeSpan.FromSeconds(5));
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.createAppQA(driver);
        Thread.Sleep(TimeSpan.FromSeconds(10));
        seleniumFunctions.createFormQA(driver,"safety");
        Thread.Sleep(TimeSpan.FromSeconds(10));
        seleniumFunctions.addTextBoxQA(driver,"sample_text","email","textbox_unique");
        string[] choice_items = new string[] { "To Do", "In Progress", "Completed" };
        seleniumFunctions.addChoiceListQA(driver,choice_items,"Choice List");
          
        Thread.Sleep(TimeSpan.FromSeconds(2));
        
        seleniumFunctions.addChoiceListQA(driver,"choice_label1");
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addGroupHeaderQA(driver,"group header title",5);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addPhotoQA(driver,"photo_label");
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addToggleQA(driver,"toggle_label","toggle_placeholder");
        seleniumFunctions.addDateTimeQA(driver," Date");
        seleniumFunctions.addGpsQA(driver,"ontap");
        seleniumFunctions.addTimeStampQA(driver,"onopen");
        seleniumFunctions.addChildRecordQA(driver);
        seleniumFunctions.addStaticMediaQA(driver);  
        seleniumFunctions.addQrCodeQA(driver," Default");
        seleniumFunctions.addStopWatchQA(driver,"5");
        seleniumFunctions.addCounterQA(driver,"number","5");
        seleniumFunctions.addGeoFenceQA(driver,"5");
        // seleniumFunctions.addApplyGeoFenceQA(driver);
        seleniumFunctions.addBarcodeQA(driver);
        seleniumFunctions.addDocumentQA(driver," doc","5");
        seleniumFunctions.addAudioQA(driver);
        seleniumFunctions.addVideoQA(driver);
        seleniumFunctions.addFormulaQA(driver);
        seleniumFunctions.addLanguageQA(driver);
        seleniumFunctions.addWebLinkQA(driver,"https://andromeda-builder-qa.axonator.com/");
        seleniumFunctions.addUniqueIdQA(driver);
        seleniumFunctions.addAutoNumberQA(driver,"5");

        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.saveFormQA(driver);

        Thread.Sleep(TimeSpan.FromSeconds(20));
        seleniumFunctions.release_app_QA(driver);

        
         var tabs = driver.WindowHandles;

        // // Switch to the new tab
        driver.SwitchTo().Window(tabs[1]);

        Thread.Sleep(TimeSpan.FromSeconds(5));
        // driver.Navigate().GoToUrl("https://andromeda-container-qa.axonator.com/apps");
        Thread.Sleep(TimeSpan.FromSeconds(40));
        containerFunctions.selectApp(driver,"Untitled App 19","safety");
         Thread.Sleep(TimeSpan.FromSeconds(20));
        containerFunctions.addText(driver,"hello@gmail.com","email");
        containerFunctions.uploadPhoto(driver);
        containerFunctions.selectChoice(driver,"Choice List","To Do");
        containerFunctions.toggleChange(driver);
         Thread.Sleep(TimeSpan.FromSeconds(10));
        containerFunctions.setDateTime(driver,"2024","MAY","2");
        string filePath = "/home/l21/Downloads/doc.pdf";
        containerFunctions.uploadDocument(driver,filePath);
        containerFunctions.gpsLocateMe(driver);
        containerFunctions.addChildRecord(driver,"yash@gmail.com");
        containerFunctions.stopWatch(driver,10);
        containerFunctions.incCounter(driver,10);
        // containerFunctions.addUniqueId(driver);
        // containerFunctions.uploadVideo(driver,"/home/l21/Downloads/video (2160p).mp4");
        containerFunctions.submitForm(driver);
        Thread.Sleep(TimeSpan.FromSeconds(5));

        containerFunctions.viewFormData(driver,"safety");

        Assert.Pass();
    }

    [TearDown]
    public void Teardown()
    {
        // driver.Quit();
    }



    


    
}
