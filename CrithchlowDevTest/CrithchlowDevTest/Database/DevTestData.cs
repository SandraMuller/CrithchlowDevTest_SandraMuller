using System;
using CrithchlowDevTest.Models;
using System.Collections.Generic;

namespace CrithchlowDevTest.Database
{
    public class DevTestData
    {
        public IEnumerable<DevTestModel> SeedData()
        {
            var list = new List<DevTestModel>() {
                new DevTestModel() {
                    ID = 1,
                    Name = "Jaytamit",
                    Description = "Integer non turpis vitaeorci tincidunt ullamcorperid pretium lectus.",
                    Price = 45.8655,
                    CurrencyCode = "NZD",
                    UnitsAvailable = 5,
                    DefaultSort = 2},
                new DevTestModel() {
                    ID = 2,
                    Name = "Canlux",
                    Description = "Aenean interdum dapibusenim, vel pulvinar erospharetra nec.",
                    Price = 23.5874,
                    CurrencyCode = "NZD",
                    UnitsAvailable = 0,
                    DefaultSort = 4},
                new DevTestModel() {
                    ID = 3,
                    Name = "Sunkix",
                    Description = "Pellentesque nisi leo,laoreet vel ex eu, ultriciespharetra ligula.",
                    Price = 14.2565,
                    CurrencyCode = "AUD",
                    UnitsAvailable = 7,
                    DefaultSort = 1},
                new DevTestModel() {
                    ID = 4,
                    Name = "Kay-Lex",
                    Description = "Ut tempus tempor mi, involutpat lorem varius a.",
                    Price = 26.5862,
                    CurrencyCode = "NZD",
                    UnitsAvailable = 2,
                    DefaultSort = 3},
                new DevTestModel() {
                    ID = 5,
                    Name = "Zamstring",
                    Description = "Proin finibus leo nulla, inelementum erat suscipitnon.",
                    Price = 56.2518,
                    CurrencyCode = "USD",
                    UnitsAvailable = 0,
                    DefaultSort = 5},
            };
            return list;
        }
    }
}