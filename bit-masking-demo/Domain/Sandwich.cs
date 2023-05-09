namespace bit_masking_demo.Domain
{
    public class Sandwich
    {
        public Options Options { get; set; } = new Options();

        public void AddKetchup()
        {
            Options.HasKetchup = true;
        }

        public void AddMustard()
        {
            Options.HasMustard = true;
        }

    }
}
