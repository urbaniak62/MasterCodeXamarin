using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APImasterCode.Models;

namespace APImasterCode.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;
        List<Categorie> categories;

        public List<Categorie> Categorie { get; private set; }

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<IEnumerable<Categorie>>GetCategoriesAsync(bool forceRefresh=false)
        {
            categories = new List<Categorie>();
            var listCategorie = new List<Categorie>
            {
                new Categorie{Id =Guid.NewGuid().ToString(),LibelleCategorie="c#",},
                new Categorie{Id =Guid.NewGuid().ToString(),LibelleCategorie="HTML/css",}
            };
            foreach (var item in categories)              
            {
                categories.Add(item);
            }
            return await Task.FromResult(categories);
        }
        public async Task<Categorie>GetCategorieAsync(string id)
        {
            return await Task.FromResult(Categorie.FirstOrDefault(s => s.Id == id));
        }
    }
}