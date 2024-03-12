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
        // seleniumFunctions.login(driver,"yash1@axonator.com","Welcome@12345"); //prod user
        seleniumFunctions.login(driver,"yash_test@axonator.com","Welcome@12345"); //QA 
        Thread.Sleep(TimeSpan.FromSeconds(5));
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        // seleniumFunctions.closePopUp2(driver);
        // seleniumFunctions.closePopUp1(driver);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.createAppQA(driver);
        Thread.Sleep(TimeSpan.FromSeconds(10));
        seleniumFunctions.createFormQA(driver,"safety");
        Thread.Sleep(TimeSpan.FromSeconds(10));
        seleniumFunctions.addTextBoxQA(driver,"sample_text","email","textbox_unique");
        string[] choice_items = new string[] { "To Do", "In Progress", "Completed" };
        seleniumFunctions.addChoiceListQA(driver,choice_items,"choice_label");
          
        Thread.Sleep(TimeSpan.FromSeconds(2));
        
        seleniumFunctions.addChoiceListQA(driver,"choice_label1");
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addGroupHeaderQA(driver,"group header title",5);
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addPhotoQA(driver,"photo_lable");
        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.scrollDown(driver);
        seleniumFunctions.addToggleQA(driver,"toggle_label","toggle_placeholder");
        seleniumFunctions.addDateTimeQA(driver," Date");

        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.saveFormQA(driver);

        Thread.Sleep(TimeSpan.FromSeconds(5));
        seleniumFunctions.release_app_QA(driver);
        // seleniumFunctions.release_app(driver);
        Assert.Pass();
    }

    [TearDown]
    public void Teardown()
    {
        // driver.Quit();
    }



    


    
}