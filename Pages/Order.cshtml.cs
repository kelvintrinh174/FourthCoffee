using System.ComponentModel.DataAnnotations;
using FourthCoffee.Models;
using FourthCoffee.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Net;

namespace FourthCoffee.Pages
{
    public class OrderModel : PageModel
    {
        private FourthCoffeeContext db;
        public OrderModel(FourthCoffeeContext db) => this.db = db;
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public Product Product { get; set;}

        [BindProperty, EmailAddress, Required, Display(Name="Your Email Address")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage="Please supply a shipping address"), Display(Name="Shipping Address")]
        public string OrderShipping { get; set; } 
        [BindProperty, Display(Name="Quantity")]
        public int OrderQuantity { get; set; } = 1;
        public async Task OnGetAsync() =>  Product = await db.Products.FindAsync(Id);

        public async Task<IActionResult> OnPostAsync()
        {
            Product = await db.Products.FindAsync(Id);
            if(ModelState.IsValid)
            {
                    var body = $@"<p>Thank you, we have received your order for {OrderQuantity} unit(s) of {Product.Name}!</p>
            <p>Your address is: <br/>{OrderShipping.Replace("\n", "<br/>")}</p>
            Your total is ${Product.Price * OrderQuantity}.<br/>
            We will contact you if we have questions about your order.  Thanks!<br/>";
            using(var smtp = new SmtpClient())
                {
                    smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    smtp.PickupDirectoryLocation = @"c:\mailpickup";
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "Fourth Coffee - New Order";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("sales@fourthcoffee.com");
                    await smtp.SendMailAsync(message);
                }

            using(var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "ttrinh22@my.centennialcollege.ca",  // replace with your outlook email
                        Password = "..."  // replace with your outlook email
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "Fourth Coffee - New Order";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("ttrinh22@my.centennialcollege.ca");//replace this
                    await smtp.SendMailAsync(message);
                }
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}