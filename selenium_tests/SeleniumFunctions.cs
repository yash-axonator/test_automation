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
      // xpathReader = new XPathReader("/home/l21/Documents/qa_automation/selenium_tests/xpath_definitions.xml");
   }

   //LOGIN
   public void login(IWebDriver driver, string user , string pass)
   {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
       Thread.Sleep(TimeSpan.FromSeconds(10));
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
      Thread.Sleep(TimeSpan.FromSeconds(10));
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

   public void signUpQA(IWebDriver driver, string fname,string lname,string email,string pass,string country, string industry,string org, string num, string desc)
   {
      Thread.Sleep(TimeSpan.FromSeconds(10));
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

       //select country
      IWebElement select_country = driver.FindElement(By.XPath(xpathReader.GetXPath("select_country")));
      select_country.Click();

      string country_xpath = $"//option[text()='{country}']";
      IWebElement get_country = driver.FindElement(By.XPath(country_xpath));
      get_country.Click();


      //enter organization
      IWebElement organization = driver.FindElement(By.XPath(xpathReader.GetXPath("organization")));
      organization.SendKeys(org);

       //enter number
      IWebElement number = driver.FindElement(By.XPath(xpathReader.GetXPath("number")));
      number.SendKeys(num);

      //select industry
      IWebElement select_ind = driver.FindElement(By.XPath(xpathReader.GetXPath("select_ind")));
      select_ind.Click();

      string ind_xpath = $"//option[text()='{industry}']";
      IWebElement get_ind = driver.FindElement(By.XPath(ind_xpath));
      get_ind.Click();

       //enter description
      IWebElement  description= driver.FindElement(By.XPath(xpathReader.GetXPath("description")));
      description.SendKeys(desc);

      //click on sign in button
      IWebElement  signin= driver.FindElement(By.XPath(xpathReader.GetXPath("signin")));
      signin.Click();


   }

   public void createApp(IWebDriver driver){
      IWebElement build = driver.FindElement(By.XPath(xpathReader.GetXPath("build")));
      build.Click();
      
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement build_btn = driver.FindElement(By.XPath(xpathReader.GetXPath("build_btn")));
      build_btn.Click();

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      closePopUp2(driver);

      IWebElement create_app = driver.FindElement(By.XPath(xpathReader.GetXPath("create_app")));
      create_app.Click();

      

      IWebElement app_name = driver.FindElement(By.XPath(xpathReader.GetXPath("app_name")));
      app_name.SendKeys("testing_prod21");

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

   // IWebElement popup3_video = driver.FindElement(By.XPath(xpathReader.GetXPath("popup3_video")));
   // try{
   //    if(popup3_video!=null)
   //    {
   //       popup3_video.Click();
   //    }
   // }
   // catch(ElementClickInterceptedException)
   // {

   // }
 
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
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      
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
      // select_text_area.Click();

      // select_text_area.Clear();
      // select_text_area.SendKeys(text);

      // IWebElement add_text = driver.FindElement(By.XPath(xpathReader.GetXPath("set_text")));
      // add_text.SendKeys(text);
      


      
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


      string dropdown_value_xpath = $"//span[text()=' {optionText}']";

      IWebElement dropdown = driver.FindElement(By.XPath(dropdown_value_xpath));
      dropdown.Click(); 


      IWebElement set_unique_text = driver.FindElement(By.XPath(xpathReader.GetXPath("unique_textbox")));
      set_unique_text.Click();
      set_unique_text.Clear();
      set_unique_text.SendKeys(unique_text);


      
   }

   public void addChoiceList(IWebDriver driver,string[] choice_items, string label)
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
      // IWebElement choice_text = driver.FindElement(By.XPath(xpathReader.GetXPath("choice_text")));
      // choice_text.Click();
      // choice_text.Clear();
      // foreach (var item in choice_items)
      // {
      //    choice_text.SendKeys(item);
      //    choice_text.SendKeys(",");

      // }
      // choice_text.SendKeys(Keys.Backspace);
      // Thread.Sleep(TimeSpan.FromSeconds(5));
      
      // //set label
      // IWebElement choice_list_label = driver.FindElement(By.XPath(xpathReader.GetXPath("choice_list_label")));
      // choice_list_label.Click();
      // choice_list_label.Clear();
      // choice_list_label.SendKeys(label);

      

      



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
      Thread.Sleep(TimeSpan.FromSeconds(5));
      
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
       Thread.Sleep(TimeSpan.FromSeconds(5));

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

   public void addGroupHeader(IWebDriver driver,string title, int indent)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("group_header")));
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
    
   //  IWebElement header_title = driver.FindElement(By.XPath(xpathReader.GetXPath("header_title")));
   //  header_title.Click();
   //  header_title.Clear();
   //  header_title.SendKeys(title);

   //  IWebElement header_indent = driver.FindElement(By.XPath(xpathReader.GetXPath("header_indent")));
   //  header_indent.Click();
   //  header_indent.Clear();
   //  header_indent.SendKeys(indent.ToString());

   //  expand.Click();
    
      
   }


   public void addGroupHeaderQA(IWebDriver driver,string title, int indent)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 250);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
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

   public void addPhoto(IWebDriver driver,string title)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));


      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("photo")));
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
    
   //  //add label
   //   IWebElement photo_label = driver.FindElement(By.XPath(xpathReader.GetXPath("photo_label")));
   //  photo_label.Click();
   //  photo_label.Clear();
   //  photo_label.SendKeys(title);

   //  IWebElement photo_required = driver.FindElement(By.XPath(xpathReader.GetXPath("photo_required")));
   //  photo_required.Click();

   //  expand.Click();
      
   }

   public void addPhotoQA(IWebDriver driver,string title)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 250);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
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

     Thread.Sleep(TimeSpan.FromSeconds(5));
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


   //ADD GPS
   public void addGpsQA(IWebDriver driver, string capture_type)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("gps")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
   actions.DragAndDrop(source, target).Build().Perform();
   
    Thread.Sleep(TimeSpan.FromSeconds(5));
    
     IWebElement capturetype = driver.FindElement(By.XPath(xpathReader.GetXPath("capturetype")));
     capturetype.Click();
     Thread.Sleep(TimeSpan.FromSeconds(5));

     string capture_type_xpath = $"//span[text()='{capture_type}']";
     IWebElement select_capture_type = driver.FindElement(By.XPath(capture_type_xpath));
     select_capture_type.Click();


    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click();
    
      
   }

   public void addTimeStampQA(IWebDriver driver, string mode_value)
   {
      Thread.Sleep(TimeSpan.FromSeconds(10));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("timestamp")));
      HighlightElement(driver,source);

      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();

     Thread.Sleep(TimeSpan.FromSeconds(5));
    
     IWebElement mode = driver.FindElement(By.XPath(xpathReader.GetXPath("mode")));
     mode.Click();
     Thread.Sleep(TimeSpan.FromSeconds(5));

     string mode_value_xpath = $"//span[text()='{mode_value}']";
     IWebElement select_mode_value = driver.FindElement(By.XPath(mode_value_xpath));
     select_mode_value.Click();
   }

   public void addChildRecordQA(IWebDriver driver)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("childrecord")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    
    IWebElement childform = driver.FindElement(By.XPath(xpathReader.GetXPath("childform")));
    childform.Click();
    Thread.Sleep(TimeSpan.FromSeconds(5));
    IWebElement childform_user = driver.FindElement(By.XPath(xpathReader.GetXPath("childform_user")));
    childform_user.Click();

    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click();
    
      
   }

   public void addStaticMediaQA(IWebDriver driver)
   {
       Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("staticmedia")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    

    expand.Click();
    
      
   }

   public void addQrCodeQA(IWebDriver driver, string subtype)
   {
       Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("qrcode")));
      HighlightElement(driver,source);


      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();
     Thread.Sleep(TimeSpan.FromSeconds(5));

     IWebElement qrcode_subtype = driver.FindElement(By.XPath(xpathReader.GetXPath("qrcode_subtype")));
     qrcode_subtype.Click();
     Thread.Sleep(TimeSpan.FromSeconds(5));

     string subtype_xpath =$"//span[text()='{subtype}']";

     IWebElement select_subtype = driver.FindElement(By.XPath(subtype_xpath));
     select_subtype.Click();


   }

   public void addStopWatchQA(IWebDriver driver,string indent)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("stopwatch")));
      HighlightElement(driver,source);


      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement target = driver.FindElement(By.XPath(xpathReader.GetXPath("drop_here_inserted")));
      HighlightElement(driver,target);
    
      // Perform the drag and drop action
  
    Actions actions = new Actions(driver);
     actions.DragAndDrop(source, target).Build().Perform();

     Thread.Sleep(TimeSpan.FromSeconds(5));
     IWebElement increase_indent = driver.FindElement(By.XPath(xpathReader.GetXPath("stopwatch_indent")));
     increase_indent.Click();
     increase_indent.Clear();
     increase_indent.SendKeys(indent);
   }

   public void addCounterQA(IWebDriver driver,string unit, string indent)
   {
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("counter")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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

     IWebElement set_unit = driver.FindElement(By.XPath(xpathReader.GetXPath("counter_unit")));
     set_unit.Click();
     set_unit.Clear();
     set_unit.SendKeys(unit);
    

     IWebElement increase_indent = driver.FindElement(By.XPath(xpathReader.GetXPath("counter_indent")));
     increase_indent.Click();
     increase_indent.Clear();
     increase_indent.SendKeys(indent);
    
    
    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click();
    
      
   }

   public void addGeoFenceQA(IWebDriver driver, string radius)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("geofence")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    
    string select_centre_xpath = $"//div[@role='listbox']";

    IWebElement geofence_centre = driver.FindElement(By.XPath(xpathReader.GetXPath("geofence_centre")));
    geofence_centre.Click();
    Thread.Sleep(TimeSpan.FromSeconds(5));

    IWebElement select_centre = driver.FindElement(By.XPath(select_centre_xpath));    
    select_centre.Click();
    Thread.Sleep(TimeSpan.FromSeconds(5));

    IWebElement geofence_radius = driver.FindElement(By.XPath(xpathReader.GetXPath("geofence_radius")));
    geofence_radius.Click();
    geofence_radius.Clear();
    geofence_radius.SendKeys(radius);


   

    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click();
    
      
   }

   public void addApplyGeoFenceQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("applygeofence")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    
    string select_object_xpath = $"//div[@role='listbox']";

    IWebElement applygeofence_object = driver.FindElement(By.XPath(xpathReader.GetXPath("applygeofence_object")));
    applygeofence_object.Click();
    Thread.Sleep(TimeSpan.FromSeconds(5));

    IWebElement select_object = driver.FindElement(By.XPath(select_object_xpath));    
    select_object.Click();
    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click();
    
      
   }

   public void addBarcodeQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("barcode")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    

    expand.Click();
    
      
   }

   public void addDocumentQA(IWebDriver driver,string type,string size)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("document")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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

   //  IWebElement document_type_dropdown = driver.FindElement(By.XPath(xpathReader.GetXPath("document_type")));
   //  document_type_dropdown.Click();


   //  string document_type_xpath = $"//span[text()='{type}']";

   //  Thread.Sleep(TimeSpan.FromSeconds(5));
   //  IWebElement select_document_type = driver.FindElement(By.XPath(document_type_xpath));
   //  select_document_type.Click();
   //   Thread.Sleep(TimeSpan.FromSeconds(5));
   //   IWebElement click_event = driver.FindElement(By.XPath("//mat-label[text()='Generate public URL for accessing documents?']"));
   //  source.Click();

   IWebElement document_size = driver.FindElement(By.XPath(xpathReader.GetXPath("document_size")));
   document_size.Click();
   document_size.Clear();
   document_size.SendKeys(size);
    
    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click(); 

    
      
   }
   public void addAudioQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("audio")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    

    expand.Click();
    
      
   }

   public void addVideoQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("video")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    

    expand.Click();
    
      
   }

   public void addFormulaQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("formula")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    

    expand.Click();
    
      
   }

   public void addWebLinkQA(IWebDriver driver,string url)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("weblink")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    
    IWebElement target_url = driver.FindElement(By.XPath(xpathReader.GetXPath("target_url")));
    target_url.Click();
    target_url.Clear();
    target_url.SendKeys(url);

    Thread.Sleep(TimeSpan.FromSeconds(5));
    expand.Click();
    
      
   }

   public void addUniqueIdQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("uniqueid")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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
    

    expand.Click();
    
      
   }

   public void addAutoNumberQA(IWebDriver driver, string length)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement expand =  driver.FindElement(By.XPath(xpathReader.GetXPath("expand_widget")));
      expand.Click();

      Thread.Sleep(TimeSpan.FromSeconds(5));

      IWebElement widget_panel = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel);

      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("autonumber")));
      HighlightElement(driver,source);

      IWebElement widget_panel1 = driver.FindElement(By.CssSelector("[class*='builder-frame-left-panel']"));
      widget_panel1.Click();
      ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollBy(0, 350);", widget_panel1);


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
    
    IWebElement autonumber_length = driver.FindElement(By.XPath(xpathReader.GetXPath("autonumber_length")));
    autonumber_length.SendKeys(length);
    Thread.Sleep(TimeSpan.FromSeconds(5));
    
    expand.Click();
    
      
   }

   public void addLanguageQA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      // Actions actions1 = new Actions(driver);
      // actions1.SendKeys(Keys.PageDown).Perform();

      
      IWebElement source = driver.FindElement(By.XPath(xpathReader.GetXPath("language")));
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
      

       

      IWebElement release_version = driver.FindElement(By.XPath(xpathReader.GetXPath("release_version")));
      release_version.Click();
   }

   public void release_app_QA(IWebDriver driver)
   {
      Thread.Sleep(TimeSpan.FromSeconds(5));
      IWebElement release = driver.FindElement(By.XPath(xpathReader.GetXPath("release_app")));
      release.Click();

      Thread.Sleep(TimeSpan.FromSeconds(20));
      IWebElement release_version = driver.FindElement(By.XPath(xpathReader.GetXPath("release_version")));
      release_version.Click();

       Thread.Sleep(TimeSpan.FromSeconds(60));
       IWebElement container = driver.FindElement(By.XPath(xpathReader.GetXPath("container")));
       container.Click();

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
