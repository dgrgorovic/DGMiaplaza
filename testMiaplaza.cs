namespace PlaywrightTests;
using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;


[TestClass]
public class DGTest : PageTest
{
    

    [TestMethod]
    public async Task Task1()
    {
        // goest to the url
        await Page.GotoAsync("https://miacademy.co/#/");

        
        // finds the banner link and clicks it and then goes to the form
        await Page.GetByRole(AriaRole.Link, new() { Name = "Online High School" }).ClickAsync();
        await Page.GotoAsync("https://miacademy.co/#/");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Online High School" }).ClickAsync();
        await Page.Locator("#kt-layout-id_122039-b8").GetByRole(AriaRole.Link, new() { Name = "Apply to Our School" }).ClickAsync();

        //fills the Name, Email and Phone textboxes
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name Required" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name Required" }).FillAsync("Danijel");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name Required" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name Required" }).FillAsync("Grgorović");
        await Page.GetByLabel("Email *").ClickAsync();
        await Page.GetByLabel("Email *").FillAsync("dgrgorovic2@gmail.com");
        await Page.GetByLabel("Phone *").ClickAsync();
        await Page.GetByLabel("Phone *").FillAsync("12345678");

        // Opens the dropdown and selects Option Yes to Fill in Second Parent Information, and fills the data
        await Page.GetByRole(AriaRole.Combobox, new() { Name = "-Select-" }).Locator("span").Nth(1).ClickAsync();
        await Page.GetByRole(AriaRole.Treeitem, new() { Name = "Yes" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name", Exact = true }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name", Exact = true }).FillAsync("Name 2");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name", Exact = true }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name", Exact = true }).FillAsync("Last name 2");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email", Exact = true }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email", Exact = true }).FillAsync("secondname@gmail.com");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone", Exact = true }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone", Exact = true }).FillAsync("12345678");

        //Clicks on the checkboxes
        await Page.Locator("label").Filter(new() { HasText = "MiaPrep website" }).ClickAsync();
        await Page.Locator("label").Filter(new() { HasText = "Facebook - MOHS Post/Group" }).ClickAsync();
        await Page.Locator("label").Filter(new() { HasText = "TikTok" }).ClickAsync();

        // Opens the calendar and chooses the date
        await Page.GetByRole(AriaRole.Img, new() { Name = "..." }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "23" }).ClickAsync();

        // Goes to the next step
        await Page.GetByLabel("Next Navigates to page 2 out of").ClickAsync();

        await Page.CloseAsync();

      
    } 
}