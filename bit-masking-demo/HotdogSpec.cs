using bit_masking_demo.Domain;
using FluentAssertions;

namespace bit_masking_demo
{
    public class HotdogSpec
    {
        public class WhenAddingKetchup
        {
            [Fact]
            public void ThenMustardHasKetchup()
            {
                var hotdog = new Hotdog();

                hotdog.AddKetchup();

                hotdog.Options.HasKetchup.Should().BeTrue();
            }
        }
        public class WhenAddingMustard
        {
            [Fact]
            public void ThenHotdogHasMustard()
            {
                var hotdog = new Hotdog();

                hotdog.AddMustard();

                hotdog.Options.HasMustard.Should().BeTrue();
            }

        }
    }
}
