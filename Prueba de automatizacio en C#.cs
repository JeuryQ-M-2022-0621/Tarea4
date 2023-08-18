using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void Historiasdeusuario() {
    driver.Navigate().GoToUrl("https://plataformavirtual.itla.edu.do/login/index.php");
    driver.Manage().Window.Size = new System.Drawing.Size(955, 664);
    driver.FindElement(By.Id("loginbtn")).Click();
    driver.FindElement(By.CssSelector(".navicon > .fa-calendar")).Click();
    driver.FindElement(By.Id("drop-down-64d6be45d79d564d6be457f6c34")).Click();
    driver.FindElement(By.LinkText("Programación III (Presencial / Virtual) | 2023-C-2 | Kelyn Tejada Belliard")).Click();
    driver.FindElement(By.CssSelector(".fa-bell")).Click();
    driver.FindElement(By.CssSelector("#message-drawer-toggle-64d6be5a27fd064d6be59d36259 > .icon")).Click();
    driver.FindElement(By.CssSelector("#view-overview-group-messages-toggle .font-weight-bold")).Click();
    {
      var element = driver.FindElement(By.CssSelector("#yui_3_17_2_1_1691795036065_317 > .expanded-icon-container > .icon"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector("#view-overview-group-messages-target-64d6be5a39ccc64d6be59d362520 .rounded-circle"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.Id("yui_3_17_2_1_1691795036065_316")).Click();
    driver.FindElement(By.Id("action-menu-toggle-1")).Click();
    driver.FindElement(By.Id("actionmenuaction-7")).Click();
    driver.FindElement(By.Id("password")).SendKeys("");
  }
}
