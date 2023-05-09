using bit_masking_demo.Domain;
using FluentAssertions;

namespace bit_masking_demo
{
    public class SandwichSpec
    {
        public class WhenAddingKetchup
        {
            [Fact]
            public void ThenSandwichHasKetchup()
            {
                var sandwich = new Sandwich();

                sandwich.AddKetchup();

                sandwich.Regular.Should().Be(OptionsEnum.Ketchup);
            }
        }

        public class WhenAddingMustard
        {
            [Fact]
            public void ThenSandwichHasMustard()
            {
                var sandwich = new Sandwich();

                sandwich.AddMustard();

                sandwich.Regular.Should().Be(OptionsEnum.Mustard);
            }
        }

        public class WhenAddingExtraCheese
        {
            [Fact]
            public void ThenSandwichHasExtraCheese()
            {
                var sandwich = new Sandwich();

                sandwich.AddExtraCheese();

                sandwich.Extra.Should().Be(OptionsEnum.Cheese);
            }

        }

        public class WhenCreatingASandwich
        {
            [Fact]
            public void ThenSandwichHasDefaultOptions()
            {
                var sandwich = new Sandwich();

                sandwich.Regular.Should().Be(OptionsEnum.Ketchup);
                sandwich.Extra.Should().Be(OptionsEnum.None);
            }
        }
    }
}
