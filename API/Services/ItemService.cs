using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Services
{
    public class ItemService : IItemService
    {
        /// <summary>
        /// Dummy get method implementation
        /// </summary>
        /// <returns>dummy list of data</returns>
        public async Task<List<Item>> Get()
        {
            var listToReturn = new List<Item>
            {
                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Juice",
                    Description = "Orange juice with 30% of orange.",
                    Price = 6.99
                },
                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Chocolate 80g",
                    Description = "Milk chocolate with pieces of almond and nuts.",
                    Price = 8.99
                },
                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Bread",
                    Description = "1 loaf of bread, white",
                    Price = 4.99
                }
            };
            return listToReturn;
        }

    }
}
