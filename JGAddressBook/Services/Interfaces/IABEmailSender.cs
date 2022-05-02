using JGAddressBook.Models;
using JGAddressBook.Models.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace JGAddressBook.Services.Interfaces
{

    public interface IABEmailSender : IEmailSender
    {
        string ComposeEmailBody(AppUser sender, EmailData emailData);
        Task SendEmailAsync(AppUser appUser, List<Contact> contacts, EmailData emailData);
    }
}
