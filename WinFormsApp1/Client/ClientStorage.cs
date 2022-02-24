using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace WinFormsApp1.Client
{
    public class ClientStorage
    {
        public List<ClientModel> Clients { get; private set; } = new List<ClientModel>();
        public ClientStorage()
        {
            Load();
        }
        public void Load()
        {
            var text = File.ReadAllText("Список клиентов.txt");
            Clients = System.Text.Json.JsonSerializer.Deserialize<List<ClientModel>>(text);
        }

        public void Save()
        {
            var text = System.Text.Json.JsonSerializer.Serialize(Clients);
            File.WriteAllText("Список клиентов.txt", text);
        }

        public void Add(ClientModel client)
        {
            Clients.Add(client);
        }

        public void Ban(ClientModel client)
        {
            Clients.Remove(client);
        }

        internal ClientModel Find(string text)
        {
            return Clients.Where(e => e.Phone == text).SingleOrDefault();
        }
    }
}
