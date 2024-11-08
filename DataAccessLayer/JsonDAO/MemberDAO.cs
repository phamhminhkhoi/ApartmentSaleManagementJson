using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccessLayer.JsonDAO
{
    public class MemberDAO
    {
        private readonly string _jsonFilePath = "..\\BusinessObjectLayer\\JsonModel\\data.json";
        private SaleManagementData _data;

        public MemberDAO()
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(_jsonFilePath))
            {
                string jsonData = File.ReadAllText(_jsonFilePath);
                _data = JsonSerializer.Deserialize<SaleManagementData>(jsonData) ?? new SaleManagementData();
            }
            else
            {
                _data = new SaleManagementData();
            }
        }

        private void SaveData()
        {
            string jsonData = JsonSerializer.Serialize(_data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_jsonFilePath, jsonData);
        }

        public Member GetMemberByEmail(string email)
        {
            return _data.Members?.FirstOrDefault(m => m.Email == email);
        }

        public Member GetMemberById(int memberId)
        {
            return _data.Members?.FirstOrDefault(m => m.MemberId == memberId);
        }

        public List<Member> GetAllMembers()
        {
            return _data.Members ?? new List<Member>();
        }
    }
}
