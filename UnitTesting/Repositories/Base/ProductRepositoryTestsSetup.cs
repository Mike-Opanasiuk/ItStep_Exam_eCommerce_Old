using ItStep_Exam_eCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.Base
{
    internal class ProductRepositoryTestsSetup : BaseRepositoryTestsSetup
    {
        protected CategoryEntity category;

        public override async Task Setup()
        {
            await base.Setup();

            category = (await Context.Categories.AddAsync(new CategoryEntity()
            {
                Title = "Test category"
            })).Entity;

            await Context.SaveChangesAsync();
        }
    }
}
