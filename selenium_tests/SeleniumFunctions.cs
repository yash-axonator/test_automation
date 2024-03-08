using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing.Imaging; 


public class SeleniumFunctions
{
   public XPathReader xpathReader;
   
   public SeleniumFunctions()
   {
      xpathReader = new XPathReader("/home/l21/Documents/qa_automation/selenium_tests/app_xpath_definitions.xml");
   }

   //LOGIN
   public void login(IWebDriver driver, string user , string pass)
   {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

      //enter username
      IWebElement username = driver.FindElement(By.XPath(xpathReader.GetXPath("username")));
      username.SendKeys(user);


      //enter password
      IWebElement password = driver.FindElement(By.XPath(xpathReader.GetXPath("password")));
      password.SendKeys(pass);

      //click on login button
      IWebElement  login_button= driver.FindElement(By.XPath(xpathReader.GetXPath("login_button")));
      login_button.Click();


   }
    
   //SIGN UP
   public void signUp(IWebDriver driver, string fname,string lname,string email,string pass, string org, string num, string desc)
   {
      IWebElement signup = driver.FindElement(By.XPath(xpathReader.GetXPath("signup")));
      signup.Click();

      //enter first name
      IWebElement firstname = driver.FindElement(By.XPath(xpathReader.GetXPath("firstname")));
      firstname.SendKeys(fname);

      //enter last name
      IWebElement lastname = driver.FindElement(By.XPath(xpathReader.GetXPath("lastname")));
      lastname.SendKeys(lname);

      //enter email
      IWebElement username = driver.FindElement(By.XPath(xpathReader.GetXPath("username")));
      username.SendKeys(email);

      //enter password
      IWebElement password = driver.FindElement(By.XPath(xpathReader.GetXPath("pass_sign")));
      password.SendKeys(pass);

      //enter organization
      IWebElement organization = driver.FindElement(By.XPath(xpathReader.GetXPath("organization")));
      organization.SendKeys(org);

       //enter number
      IWebElement number = driver.FindElement(By.XPath(xpathReader.GetXPath("number")));
      number.SendKeys(num);

       //enter description
      IWebElement  description= driver.FindElement(By.XPath(xpathReader.GetXPath("description")));
      description.SendKeys(desc);

      //click on sign in button
      IWebElement  signin= driver.FindElement(By.XPath(xpathReader.GetXPath("signin")));
      signin.Click();


   }

   public void createApp(IWebDriver driver){
      // IWebElement build = driver.FindElement(By.XPath(xpathReader.GetXPath("build")));
      // build.Click();
      
      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      // IWebElement build_btn = driver.FindElement(By.XPath(xpathReader.GetXPath("build_btn")));
      // build_btn.Click();

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      closePopUp2(driver);

      IWebElement create_app = driver.FindElement(By.XPath(xpathReader.GetXPath("create_app")));
      create_app.Click();

      

      IWebElement app_name = driver.FindElement(By.XPath(xpathReader.GetXPath("app_name")));
      app_name.SendKeys("app3");

      IWebElement app_desc = driver.FindElement(By.XPath(xpathReader.GetXPath("app_desc")));
      app_desc.SendKeys("desc1");

      IWebElement create_app_btn = driver.FindElement(By.XPath(xpathReader.GetXPath("create_app_btn")));
      create_app_btn.Click();

    Screenshot screenshot_app = ((ITakesScreenshot)driver).GetScreenshot();
      screenshot_app.SaveAsFile("createapp.png");




   }

   
   //CREATE FORM
   public void createForm(IWebDriver driver,string f_name){


   try
   { 
     IWebElement create_form = driver.FindElement(By.XPath(xpathReader.GetXPath("create_form")));
     closePopUp2(driver);
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    closePopUp2(driver);
    
     create_form.Click();
   }

   catch (WebDriverTimeoutException)
   {
    closePopUp2(driver);
    closePopUp1(driver);
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    closePopUp2(driver);
    IWebElement create_form = driver.FindElement(By.XPath(xpathReader.GetXPath("create_form")));
    closePopUp2(driver);
    closePopUp1(driver);
    closePopUp2(driver);
    create_form.Click();
   }


   try
   { 
     IWebElement form_name = driver.FindElement(By.XPath(xpathReader.GetXPath("form_name")));
    
      form_name.SendKeys(f_name);
   }

   catch (WebDriverTimeoutException)
   {
    
    IWebElement form_name = driver.FindElement(By.XPath(xpathReader.GetXPath("form_name")));
    form_name.SendKeys(f_name);
   }

   try
   { 
     IWebElement create_form_button = driver.FindElement(By.XPath(xpathReader.GetXPath("create_form_button")));
     
      create_form_button.Click();
   }

   catch (WebDriverTimeoutException)
   {
    
    IWebElement create_form_button = driver.FindElement(By.XPath(xpathReader.GetXPath("create_form_button")));
      create_form_button.Click();
   }

   IWebElement popup3_video = driver.FindElement(By.XPath(xpathReader.GetXPath("popup3_video")));
   try{
      if(popup3_video!=null)
      {
         popup3_video.Click();
      }
   }
   catch(ElementClickInterceptedException)
   {

   }
   Screenshot screenshot_form = ((ITakesScreenshot)driver).GetScreenshot();
      screenshot_form.SaveAsFile("createform.png");

 }


   //ADD TEXTBOX 
   public void addTextBox(IWebDriver driver, string text)
   {
      Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
      screenshot.SaveAsFile("addtextbox.png");
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("textbox")));
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here")));
      
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
      actions.ClickAndHold(source)
               .MoveToElement(target)
               .Release()
               .Build()
               .Perform();
      
       Screenshot screenshot1 = ((ITakesScreenshot)driver).GetScreenshot();
      screenshot1.SaveAsFile("addtextbox1.png");
      
      IWebElement select_text_area = driver.FindElement(By.XPath(xpathReader.GetXPath("select_textbox")));
      select_text_area.Click();

      IWebElement add_text = driver.FindElement(By.XPath(xpathReader.GetXPath("set_text")));
      add_text.SendKeys(text);
      add_text.SendKeys(Keys.Enter);


      
   }

   public void saveForm(IWebDriver driver)
   {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement save_form = driver.FindElement(By.XPath(xpathReader.GetXPath("save_form")));
      save_form.Click();
      Console.WriteLine("form saved");
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


      // IAlert alert = driver.SwitchTo().Alert();
      // //handle alert
      // if (alert!=null) {
      //      alert.Accept(); // or alert.dismiss();
      // }

   }

   public void release_app(IWebDriver driver)
   {
      //  try{
      //       //alert
      //       IAlert alert = driver.SwitchTo().Alert();
      //       alert.Accept();
      //   }
      //   catch (NoAlertPresentException)
      //   {
      //       Console.WriteLine("No alert present.");
      //   }
      int attempts = 0;
        const int maxAttempts = 3;
        while (attempts < maxAttempts)
        {
            try
            {
                IWebElement release = driver.FindElement(By.XPath(xpathReader.GetXPath("release_app")));
               release.Click();
               Console.WriteLine("release clicked");
                break;
            }
            catch (StaleElementReferenceException)
            {
                // Increment the attempts counter
                attempts++;
            }
        }
      

       try
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept(); // Or alert.Dismiss();
        }
        catch (NoAlertPresentException e)
        {
            
        }

      IWebElement release_version = driver.FindElement(By.XPath(xpathReader.GetXPath("release_version")));
      release_version.Click();
   }

   //CLOSE POPUP
   public void closePopUp1(IWebDriver driver)
   {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
       try
        {
            // Find the element
            
            IWebElement popup1 = driver.FindElement(By.XPath(xpathReader.GetXPath("popup1")));
            // If the element exists, click on it
            if (popup1 != null)
            {
               popup1.Click();
                Console.WriteLine("Element closed");
            }
            
            
   }
   catch (NoSuchElementException)
        {
            Console.WriteLine("Element not found.");
        }
   }


   public void closePopUp2(IWebDriver driver)
   {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
       try
        {
            // Find the element
            
            IWebElement popup2 = driver.FindElement(By.XPath(xpathReader.GetXPath("popup2")));

            if (popup2 != null)
            {
                popup2.Click();
                Console.WriteLine("Element closed");
            }

            
            
            
   }
   catch (NoSuchElementException)
        {
            Console.WriteLine("Element not found.");
        }
   }


}
