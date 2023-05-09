using bit_masking_demo.Domain;
using FluentAssertions;

namespace bit_masking_demo
{
    public class HotdogSpec
    {
        public class WhenAddingKetchup
        {
            [Fact]
            public void ThenHotdogHasKetchup()
            {
                var hotdog = new Hotdog();

                hotdog.AddKetchup();

                hotdog.Regular.Should().Be(OptionsEnum.Ketchup);
            }
        }

        public class WhenAddingMustard
        {
            [Fact]
            public void ThenHotdogHasMustard()
            {
                var hotdog = new Hotdog();

                hotdog.AddMustard();

                hotdog.Regular.Should().Be(OptionsEnum.Mustard);
            }

        }
    }
}
