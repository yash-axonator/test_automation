using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing.Imaging; 
using System.Collections.ObjectModel; 
using OpenQA.Selenium.Support.UI;



public class SeleniumFunctions
{
   public XPathReader xpathReader;
   
   public SeleniumFunctions()
   {
      xpathReader = new XPathReader("/home/l21/Documents/qa_automation/selenium_tests/andromeda-builder-qa.xml");
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

   //CREATE FORM BUILDER QA
   public void createAppQA(IWebDriver driver){
      // IWebElement build = driver.FindElement(By.XPath(xpathReader.GetXPath("build")));
      // build.Click();
      
      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      // IWebElement build_btn = driver.FindElement(By.XPath(xpathReader.GetXPath("build_btn")));
      // build_btn.Click();

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      closePopUp2(driver);

      IWebElement create_app = driver.FindElement(By.XPath(xpathReader.GetXPath("create_app")));
      create_app.Click();

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
 
   }

   //CREATE FORM FOR BUILDER QA
   public void createFormQA(IWebDriver driver,string f_name){
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

      IWebElement create_form = driver.FindElement(By.XPath(xpathReader.GetXPath("create_form")));
      create_form.Click();

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
         
      //SET FORM  NAME
      IWebElement form_name = driver.FindElement(By.XPath(xpathReader.GetXPath("form_name")));
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
      form_name.Click();
      form_name.Clear();
      form_name.SendKeys(f_name);

   }
  

   //ADD TEXTBOX 
   public void addTextBox(IWebDriver driver, string text)
   {
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
      


      
   }
   public static bool IsElementPresent(IWebDriver driver, By by)
    {
        try
        {
            driver.FindElement(by);
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    static void HighlightElement(IWebDriver driver, IWebElement element)
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        string script = "arguments[0].style.border='3px solid red';";
        js.ExecuteScript(script, element);
    }

   public void addTextBoxQA(IWebDriver driver, string text,string optionText,string unique_text)
   {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("textbox")));
      HighlightElement(driver, source);
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here")));
      HighlightElement(driver, target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
    actions.DragAndDrop(source, target).Build().Perform();

      
      // if(IsElementPresent(driver, By.XPath("//*[@class='text-widget selected-widget ng-untouched ng-pristine ng-star-inserted ng-valid']")))
      // {
      //     Console.WriteLine("Drag-and-drop action was successful!");
      // }
      // else{
      //     Console.WriteLine("Drag-and-drop action was unsuccessful!");
      // }
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      IWebElement set_text = driver.FindElement(By.XPath(xpathReader.GetXPath("textbox_text")));
      set_text.Click();
      set_text.Clear();
      set_text.SendKeys(text);

      IWebElement input_type = driver.FindElement(By.XPath(xpathReader.GetXPath("input_type")));
      input_type.Click();


      string dropdown_value_xpath = $"//mat-option[@ng-reflect-value='{optionText}']";

      IWebElement dropdown = driver.FindElement(By.XPath(dropdown_value_xpath));
      dropdown.Click(); 


      IWebElement set_unique_text = driver.FindElement(By.XPath(xpathReader.GetXPath("unique_textbox")));
      set_unique_text.Click();
      set_unique_text.Clear();
      set_unique_text.SendKeys(unique_text);


      
   }

   public void addChoiceListQA(IWebDriver driver,string[] choice_items, string label)
   {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("choicelist")));
      HighlightElement(driver, source);
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver, target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
    actions.DragAndDrop(source, target).Build().Perform();

      
      // if(IsElementPresent(driver, By.XPath("//*[@class='text-widget selected-widget ng-untouched ng-pristine ng-star-inserted ng-valid']")))
      // {
      //     Console.WriteLine("Drag-and-drop action was successful!");
      // }
      // else{
      //     Console.WriteLine("Drag-and-drop action was unsuccessful!");
      // }
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement choice_text = driver.FindElement(By.XPath(xpathReader.GetXPath("choice_text")));
      choice_text.Click();
      choice_text.Clear();
      foreach (var item in choice_items)
      {
         choice_text.SendKeys(item);
         choice_text.SendKeys(",");

      }
      choice_text.SendKeys(Keys.Backspace);
      
      //set label
      IWebElement choice_list_label = driver.FindElement(By.XPath(xpathReader.GetXPath("choice_list_label")));
      choice_list_label.Click();
      choice_list_label.Clear();
      choice_list_label.SendKeys(label);

      

      



   }

   public void addChoiceListQA(IWebDriver driver,string label)
   {

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("choicelist")));
      HighlightElement(driver, source);
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver, target);
    
      // Perform the drag and drop action
  
      Actions actions = new Actions(driver);
      actions.DragAndDrop(source, target).Build().Perform();

      //set label
      IWebElement choice_list_label = driver.FindElement(By.XPath(xpathReader.GetXPath("choice_list_label")));
      choice_list_label.Click();
      choice_list_label.Clear();
      choice_list_label.SendKeys(label);

      
      IWebElement choice_list_datatype  =driver.FindElement(By.XPath(xpathReader.GetXPath("choice_list_datatype_fixed")));
      choice_list_datatype.Click();

      IWebElement dropdown = driver.FindElement(By.XPath(xpathReader.GetXPath("choice_list_datatype_reference")));
      dropdown.Click(); 

       Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement reference_to = driver.FindElement(By.XPath(xpathReader.GetXPath("reference_to")));
      reference_to.Click();
       
       Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement reference_to_dropdown = driver.FindElement(By.XPath(xpathReader.GetXPath("reference_to_user")));
      reference_to_dropdown.Click();

         

   
   }


   public void addGroupHeaderQA(IWebDriver driver,string title, int indent)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(20));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 250);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(20));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("group_header")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 250);", widget_panel1);


      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();
   //   actions.ClickAndHold(source)
   //             .MoveToElement(target)
   //             .Release()
   //             .Build()
   //             .Perform();

      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      // IWebElement header_title = driver.FindElement(By.XPath(xpathReader.GetXPath("header_title")));
      // header_title.Clear();
      // header_title.SendKeys(title);
    Thread.Sleep(TimeSpan.FromSeconds(5));
    
    IWebElement header_title = driver.FindElement(By.XPath(xpathReader.GetXPath("header_title")));
    header_title.Click();
    header_title.Clear();
    header_title.SendKeys(title);

    IWebElement header_indent = driver.FindElement(By.XPath(xpathReader.GetXPath("header_indent")));
    header_indent.Click();
    header_indent.Clear();
    header_indent.SendKeys(indent.ToString());

    expand.Click();
    
      
   }

   public void addPhotoQA(IWebDriver driver,string title)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(20));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 250);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(20));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("photo")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 250);", widget_panel1);


      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();
   //   actions.ClickAndHold(source)
   //             .MoveToElement(target)
   //             .Release()
   //             .Build()
   //             .Perform();

      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      // IWebElement header_title = driver.FindElement(By.XPath(xpathReader.GetXPath("header_title")));
      // header_title.Clear();
      // header_title.SendKeys(title);
    Thread.Sleep(TimeSpan.FromSeconds(5));
    
    //add label
     IWebElement photo_label = driver.FindElement(By.XPath(xpathReader.GetXPath("photo_label")));
    photo_label.Click();
    photo_label.Clear();
    photo_label.SendKeys(title);

    IWebElement photo_required = driver.FindElement(By.XPath(xpathReader.GetXPath("photo_required")));
    photo_required.Click();

    expand.Click();
      
   }

   public void addToggleQA(IWebDriver driver, string label, string placeholder)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("toggle")));
      HighlightElement(driver,source);

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();
   //   actions.ClickAndHold(source)
   //             .MoveToElement(target)
   //             .Release()
   //             .Build()
   //             .Perform();

      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      // IWebElement header_title = driver.FindElement(By.XPath(xpathReader.GetXPath("header_title")));
      // header_title.Clear();
      // header_title.SendKeys(title);
    Thread.Sleep(TimeSpan.FromSeconds(5));
    IWebElement toggle_label= driver.FindElement(By.XPath(xpathReader.GetXPath("toggle_label")));
    toggle_label.Click();
    toggle_label.Clear();
    toggle_label.SendKeys(label);

     Thread.Sleep(TimeSpan.FromSeconds(2));
    IWebElement toggle_placeholder= driver.FindElement(By.XPath(xpathReader.GetXPath("toggle_placeholder")));
    toggle_placeholder.Click();
    toggle_placeholder.Clear();
    toggle_placeholder.SendKeys(placeholder);


      
   }

   public void addDateTimeQA(IWebDriver driver, string picker)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("date_time")));
      HighlightElement(driver,source);

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();
   //   actions.ClickAndHold(source)
   //             .MoveToElement(target)
   //             .Release()
   //             .Build()
   //             .Perform();

      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      // IWebElement header_title = driver.FindElement(By.XPath(xpathReader.GetXPath("header_title")));
      // header_title.Clear();
      // header_title.SendKeys(title);
    Thread.Sleep(TimeSpan.FromSeconds(5));

    IWebElement picker_type = driver.FindElement(By.XPath(xpathReader.GetXPath("date_time_picker")));
    picker_type.Click();


      string dropdown_value_xpath = $"//span[text()='{picker}']";

      IWebElement dropdown = driver.FindElement(By.XPath(dropdown_value_xpath));
      dropdown.Click(); 
    


      
   }

   public void scrollDown(IWebDriver driver)
   {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement phone_view = driver.FindElement(By.XPath(xpathReader.GetXPath("phone_view")));
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", phone_view);
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

    public void saveFormQA(IWebDriver driver)
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

   public void release_app_QA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement release = driver.FindElement(By.XPath(xpathReader.GetXPath("release_app")));
      release.Click();

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
