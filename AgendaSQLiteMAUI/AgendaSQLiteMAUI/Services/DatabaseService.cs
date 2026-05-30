using SQLite;
using AgendaSQLiteMAUI.Models;

// ✅ ESTO RESUELVE EL CS0104 — fuerza usar TU Contact
using Contact = AgendaSQLiteMAUI.Models.Contact;

namespace AgendaSQLiteMAUI.Services;

public class DatabaseService
{
    private readonly SQLiteAsyncConnection db;

    public DatabaseService()
    {
        var path = Path.Combine(
            FileSystem.AppDataDirectory,
            "contacts.db3");

        db = new SQLiteAsyncConnection(path);
        db.CreateTableAsync<Contact>().Wait();
    }

    public Task<List<Contact>> GetContactsAsync()
    {
        return db.Table<Contact>().ToListAsync();
    }

    public Task<int> SaveContactAsync(Contact contact)
    {
        if (contact.Id == 0)
            return db.InsertAsync(contact);

        return db.UpdateAsync(contact);
    }

    public Task<int> DeleteContactAsync(Contact contact)
    {
        return db.DeleteAsync(contact);
    }
}