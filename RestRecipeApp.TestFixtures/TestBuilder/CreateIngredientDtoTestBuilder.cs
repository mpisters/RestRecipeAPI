using Bogus;
using RecipesApp.Domain;
using RestRecipeApp.Core.RequestDto.Recipe;

namespace RestRecipeAPI.TestFixtures.TestBuilder;

public sealed class CreateIngredientDtoTestBuilder : Faker<CreateIngredientDto>
{
    public CreateIngredientDtoTestBuilder()
    {
        CustomInstantiator(f => new CreateIngredientDto(
            new CreateProductDtoTestBuilder().Generate(), f.Random.Float(1, 100),
            f.PickRandom<UnitOfMeasurement>()));
    }
    
}