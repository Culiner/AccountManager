using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AccountManager.Helper;
using Newtonsoft.Json;

namespace AccountManager.Core
{
    public class Database
    {
        public string Key { get; set; }

        public string FilePath { get; set; }

        public Dictionary<string, Package> Data { get; set; }

        public List<string> SearchList { get; set; }

        public Database()
        {
            Data = new Dictionary<string, Package>();
            SearchList = new List<string>();
            Key = string.Empty;
            FilePath = string.Empty;
        }

        private Database(Dictionary<string, Package> data, string key, string filePath)
        {
            Data = data;
            Key = key;
            FilePath = filePath;
        }

        public static Database Create(string json, string key, string filePath)
        {
            try
            {
                if (json == string.Empty)
                    return new Database(new Dictionary<string, Package>(), key, filePath);

                return JsonConvert.DeserializeObject<Database>(json);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Save()
        {
            try
            {
                var json = JsonConvert.SerializeObject(this);
                var bytes = SecretHelper.AesEncrypt(System.Text.Encoding.Default.GetBytes(json), Key);
                File.WriteAllBytes(FilePath, bytes);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<string> GetTags()
        {
            return Data.Keys.ToList();
        }
    }

    public class Package
    {
        public List<Item> Items { get; set; }

        public string Tag { get; set; }
        
        public Package(string tag)
        {
            Tag = tag;
            Items = new List<Item>();
        }
    }

    public class Item
    {
        public string Subclass { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Addition { get; set; }
    }
}
