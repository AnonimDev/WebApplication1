using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category> {
                    new Category { categoryName = "Электромобили", desc = "Описание" },
                    new Category { categoryName = "Классика", desc = "Описание" }
                };
            }
        }
    }
}
