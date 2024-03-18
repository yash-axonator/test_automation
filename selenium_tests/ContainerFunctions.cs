using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing.Imaging; 
using System.Collections.ObjectModel; 
using OpenQA.Selenium.Support.UI;
// using AutoIt;



public class ContainerFunctions
{
   public XPathReader xpathReader;
   
   public ContainerFunctions()
   {
      xpathReader = new XPathReader("/home/l21/Documents/qa_automation/selenium_tests/andromeda-container-qa.xml");
   }

   public void selectApp(IWebDriver driver, string appname,string formname){
      string app_xpath = $"//div[@ng-reflect-message='{appname}']";
      IWebElement app = driver.FindElement(By.XPath(app_xpath));
      app.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement form = driver.FindElement(By.XPath(xpathReader.GetXPath("forms")));
      form.Click();
      
      Thread.Sleep(TimeSpan.FromSeconds(10));
      string form_xpath = $"//div[@ng-reflect-message='{formname}']/ancestor::fuse-card//img";
      IWebElement form_select = driver.FindElement(By.XPath(form_xpath));
      form_select.Click();
      Thread.Sleep(TimeSpan.FromSeconds(5));



   }

   public void addText(IWebDriver driver, string text,string type)
   {
      
      string textbox_xpath = $"//input[@ng-reflect-type='{type}']";
      IWebElement textbox = driver.FindElement(By.XPath(textbox_xpath));
      textbox.SendKeys(text);
   }

   public void uploadPhoto(IWebDriver driver)
   {
      IWebElement choose_photo = driver.FindElement(By.XPath(xpathReader.GetXPath("choose_photo")));
      
      string filePath = "/home/l21/Downloads/download.jpeg";
      choose_photo.SendKeys(filePath);
      
   }

   public void toggleChange(IWebDriver driver)
   {
      IWebElement toggle = driver.FindElement(By.XPath(xpathReader.GetXPath("toggle")));
      toggle.Click();
   }

   public void setDateTime(IWebDriver driver, string inputYear, string inputMonth,string inputDate)
   {
      Thread.Sleep(TimeSpan.FromSeconds(10));
      IWebElement date_time = driver.FindElement(By.XPath(xpathReader.GetXPath("date_time")));
      date_time.Click();


      Thread.Sleep(TimeSpan.FromSeconds(10));
      IWebElement year = driver.FindElement(By.XPath(xpathReader.GetXPath("year")));
      year.Click();

      Thread.Sleep(TimeSpan.FromSeconds(10));

      string xpath_year = $"//div[text()=' {inputYear} ']";
      IWebElement input_year = driver.FindElement(By.XPath(xpath_year));
      input_year.Click();

      Thread.Sleep(TimeSpan.FromSeconds(10));

      string xpath_month = $"//div[text()=' {inputMonth} ']";
      IWebElement input_month = driver.FindElement(By.XPath(xpath_month));
      input_month.Click();

      Thread.Sleep(TimeSpan.FromSeconds(10));

      string xpath_date = $"//div[text()=' {inputDate} ']";
      IWebElement input_date = driver.FindElement(By.XPath(xpath_date));
      input_date.Click();






   }

   public void uploadDocument(IWebDriver driver,string path)
   {
       IWebElement choose_photo = driver.FindElement(By.XPath(xpathReader.GetXPath("choose_document")));
      
      
      choose_photo.SendKeys(path);
   }

   public void submitForm(IWebDriver driver)
   {
      IWebElement submit = driver.FindElement(By.XPath(xpathReader.GetXPath("submit")));
      submit.Click();
   }
}   