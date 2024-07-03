using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Headless = false,
});
var context = await browser.NewContextAsync();

var page = await context.NewPageAsync();
await page.GotoAsync("https://miacademy.co/#/");
await page.GetByRole(AriaRole.Link, new() { Name = "Online High School" }).ClickAsync();
await page.Locator("#kt-layout-id_122039-b8").GetByRole(AriaRole.Link, new() { Name = "Apply to Our School" }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name Required" }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name Required" }).FillAsync("Danijel");
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name Required" }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name Required" }).FillAsync("Grgorović");
await page.GetByLabel("Email *").ClickAsync();
await page.GetByLabel("Email *").FillAsync("dgrgorovic2@gmail.com");
await page.GetByLabel("Phone *").ClickAsync();
await page.GetByLabel("Phone *").FillAsync("12345678");
await page.GetByRole(AriaRole.Combobox, new() { Name = "-Select-" }).Locator("span").Nth(1).ClickAsync();
await page.GetByRole(AriaRole.Treeitem, new() { Name = "Yes" }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name", Exact = true }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name First Name", Exact = true }).FillAsync("Name 2");
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name", Exact = true }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Name Last Name", Exact = true }).FillAsync("Last name 2");
await page.GetByRole(AriaRole.Textbox, new() { Name = "Email", Exact = true }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Email", Exact = true }).FillAsync("secondname@gmail.com");
await page.GetByRole(AriaRole.Textbox, new() { Name = "Phone", Exact = true }).ClickAsync();
await page.GetByRole(AriaRole.Textbox, new() { Name = "Phone", Exact = true }).FillAsync("12345678");
await page.Locator("label").Filter(new() { HasText = "MiaPrep website" }).ClickAsync();
await page.Locator("label").Filter(new() { HasText = "Facebook - MOHS Post/Group" }).ClickAsync();
await page.Locator("label").Filter(new() { HasText = "TikTok" }).ClickAsync();
await page.GetByRole(AriaRole.Img, new() { Name = "..." }).ClickAsync();
await page.GetByRole(AriaRole.Link, new() { Name = "23" }).ClickAsync();
await page.GetByLabel("Next Navigates to page 2 out of").ClickAsync();
