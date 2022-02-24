using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class ContractStorage
    {
        public List<ContractModel> Contracts { get; private set; } = new List<ContractModel>();
        public List<ContractModel> ToAccept => Contracts.Where(E => !E.Accept).ToList();
        public List<ContractModel> Accepts => Contracts.Where(E => E.Accept).ToList();
        public List<ContractModel> ClientContracts(string phone) => Accepts.Where(E => E.Client.Phone==phone).ToList();
        public ContractStorage()
        {
            Load();
        }
        public void Load()
        {
            var text = File.ReadAllText("Договора.txt");
            Contracts = System.Text.Json.JsonSerializer.Deserialize<List<ContractModel>>(text);
        }

        public void Save()
        {
            var text = System.Text.Json.JsonSerializer.Serialize(Contracts);
            File.WriteAllText("Договора.txt", text);
        }

        internal void Accept(ContractModel contractModel)
        {
            contractModel.Accept = true;
        }

        public void Add(ContractModel contract)
        {
            Contracts.Add(contract);
        }

        public void Remove(ContractModel contract)
        {
            Contracts.Remove(contract);
        }
    }
}
