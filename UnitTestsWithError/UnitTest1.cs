using API.AutoMapperConfig;
using API.Controllers;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestsWithError
{
    public class UnitTest1
    {
        private ItemsStaticController controller;

        public UnitTest1()
        {
            AutoMapper.Mapper.Reset();
            MapperConfig.Initialize();

            var itemServiceMock = new Mock<IItemService>();
            itemServiceMock.Setup(service => service.Get()).ReturnsAsync(
                new List<Item>
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
                }
            );

            controller = new ItemsStaticController(itemServiceMock.Object);
        }

        [Fact]
        public async void GetItemsReturnsOk()
        {
            // Arrange

            // Act
            var result = await controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
