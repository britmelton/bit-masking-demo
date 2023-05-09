namespace bit_masking_demo.Domain
{
    public class Sandwich
    {
        public OptionsEnum Regular { get; set; } = new OptionsEnum();
        public OptionsEnum Extra { get; set; } = new OptionsEnum();
        public OptionsEnum Lite { get; set; } = new OptionsEnum();
        public OptionsEnum Exclude { get; set; } = new OptionsEnum();

        public Sandwich()
        {
            Regular = OptionsEnum.Ketchup;
        }

        public void AddKetchup()
        {
            Regular = OptionsEnum.Ketchup;
        }

        public void AddMustard()
        {
           Regular = OptionsEnum.Mustard;
        }

        public void AddExtraMustard()
        {
            Extra = OptionsEnum.Mustard;
        }

        public void AddExtraCheese()
        {
            Extra = OptionsEnum.Cheese;
        }
    }
}
