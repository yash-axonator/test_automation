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
      string app_xpath = $"//div[text()='{appname}']";
      IWebElement app = driver.FindElement(By.XPath(app_xpath));
      app.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement form = driver.FindElement(By.XPath(xpathReader.GetXPath("forms")));
      form.Click();
      
      Thread.Sleep(TimeSpan.FromSeconds(10));
      string form_xpath = $"//div[text()='{formname}']/ancestor::fuse-card//img";
      IWebElement form_select = driver.FindElement(By.XPath(form_xpath));
      form_select.Click();
      Thread.Sleep(TimeSpan.FromSeconds(5));



   }

   public void addText(IWebDriver driver, string text,string type)
   {
      
      string textbox_xpath = $"//input[@type='{type}']";
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

   public void gpsLocateMe(IWebDriver driver)
   {
      IWebElement locateme = driver.FindElement(By.XPath(xpathReader.GetXPath("gps_locateme")));
      locateme.Click();
   }

   public void stopWatch(IWebDriver driver,int time)
   {
      IWebElement start = driver.FindElement(By.XPath(xpathReader.GetXPath("stopwatch_start")));
      start.Click();

      Thread.Sleep(TimeSpan.FromSeconds(time));

      IWebElement stop = driver.FindElement(By.XPath(xpathReader.GetXPath("stopwatch_stop")));
      stop.Click();
   }

   public void incCounter(IWebDriver driver,int num)
   {
      IWebElement counter_inc = driver.FindElement(By.XPath(xpathReader.GetXPath("counter_inc")));

      for(int i=1;i<=num;i++)
      {
         counter_inc.Click();
      }
   }

   public void uploadVideo(IWebDriver driver,string path)
   {
       IWebElement choose_video = driver.FindElement(By.XPath(xpathReader.GetXPath("choose_video")));
      
      
      choose_video.SendKeys(path);
   }

   public void selectChoice(IWebDriver driver,string listname,string choice)
   {
      string choicelist_xpath = $"//div[contains(.,'{listname}')]/mat-select";

      IWebElement choicelist = driver.FindElement(By.XPath(choicelist_xpath));
      choicelist.Click();

      string choice_xpath = $"//span[text()='{choice}']";

      IWebElement select_choice = driver.FindElement(By.XPath(choice_xpath));
      select_choice.Click();

   }

   public void addChildRecord(IWebDriver driver,string mail)
   {
      IWebElement child_record = driver.FindElement(By.XPath(xpathReader.GetXPath("child_form")));
      child_record.Click();

      Thread.Sleep(TimeSpan.FromSeconds(10));

      IWebElement child_form_email = driver.FindElement(By.XPath(xpathReader.GetXPath("child_form_email")));
      child_form_email.SendKeys(mail);

      IWebElement child_form_submit = driver.FindElement(By.XPath(xpathReader.GetXPath("child_form_submit")));
      child_form_submit.Click();
   }

   public void addUniqueId(IWebDriver driver)
   {
      IWebElement tap_here = driver.FindElement(By.XPath(xpathReader.GetXPath("tap_here")));
      tap_here.Click();
      Thread.Sleep(TimeSpan.FromSeconds(3));
   }

   public void submitForm(IWebDriver driver)
   {
      IWebElement submit = driver.FindElement(By.XPath(xpathReader.GetXPath("submit")));
      submit.Click();
   }

   public void viewFormData(IWebDriver driver, string form)
   {
      string form_xpath=$"//span[text()=' {form} ']";
      IWebElement select_form = driver.FindElement(By.XPath(form_xpath));
      select_form.Click();
      Thread.Sleep(TimeSpan.FromSeconds(20));

      IWebElement view_data = driver.FindElement(By.XPath(xpathReader.GetXPath("view_data")));
      view_data.Click();

      select_form.Click();
      Thread.Sleep(TimeSpan.FromSeconds(20));
   }

   public void exportData(IWebDriver driver)
   {
      IWebElement excel = driver.FindElement(By.XPath(xpathReader.GetXPath("excel")));
      excel.Click();

      Thread.Sleep(TimeSpan.FromSeconds(10));

      IWebElement export = driver.FindElement(By.XPath(xpathReader.GetXPath("export")));
      export.Click();
   }
}   