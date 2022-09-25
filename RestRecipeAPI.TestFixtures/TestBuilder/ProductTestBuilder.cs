using Bogus;
using RecipesApp.Domain;

namespace RestRecipeAPI.TestFixtures.TestBuilder;

public class ProductTestBuilder: Faker<Product>
{
    public ProductTestBuilder()
    {
        CustomInstantiator(f => new Product()
        {
            Name = f.Lorem.Word()
        });
    }
}