using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AgendaSQLiteMAUI.Models;
using AgendaSQLiteMAUI.Services;

// ✅ ESTO RESUELVE EL CS0104 — fuerza usar TU Contact
using Contact = AgendaSQLiteMAUI.Models.Contact;

namespace AgendaSQLiteMAUI.ViewModels;

public partial class ContactsViewModel : ObservableObject
{
    private readonly DatabaseService database;

    [ObservableProperty]
    private List<Contact> contacts = new();

    [ObservableProperty]
    private Contact current = new();

    public ContactsViewModel(DatabaseService db)
    {
        database = db;
        Load();
    }

    [RelayCommand]
    private async Task Load()
    {
        Contacts = await database.GetContactsAsync();
    }

    [RelayCommand]
    private async Task Save()
    {
        if (string.IsNullOrWhiteSpace(Current.Name))
            return;

        await database.SaveContactAsync(Current);
        Current = new Contact();
        await Load();
    }

    [RelayCommand]
    private async Task Delete(Contact contact)
    {
        await database.DeleteContactAsync(contact);
        await Load();
    }
}