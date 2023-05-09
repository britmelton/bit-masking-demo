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

                sandwich.HasKetchup.Should().BeTrue();
            }
        }

        public class WhenAddingMustard
        {
            [Fact]
            public void ThenSandwichHasMustard()
            {
                var sandwich = new Sandwich();

                sandwich.AddMustard();

                sandwich.HasMustard.Should().BeTrue();
            }
        }
    }
}
