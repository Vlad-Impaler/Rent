using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class FlatStorage
    {
        public List<FlatModel> Flats { get; private set; } = new List<FlatModel>();
        public FlatStorage()
        {
            Load();
        }
        public void Load()
        {
            var text = File.ReadAllText("Список квартир.txt");
            Flats = System.Text.Json.JsonSerializer.Deserialize<List<FlatModel>>(text);
        }

        public void Save()
        {
            var text = System.Text.Json.JsonSerializer.Serialize(Flats);
            File.WriteAllText("Список квартир.txt", text);
        }

        public void Add(FlatModel flat)
        {
            Flats.Add(flat);
        }

        public void Remove(FlatModel flat)
        {
            Flats.Remove(flat);
        }

        public void Accept(string text)
        {
            var flat = Flats.Where(e => e.Adres == text).SingleOrDefault();
            flat.Chk = false;
        }
    }
}
