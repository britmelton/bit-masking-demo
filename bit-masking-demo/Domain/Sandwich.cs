namespace bit_masking_demo.Domain
{
    public class Sandwich
    {
        public bool HasKetchup { get; set; }
        public bool HasMustard { get; set; }

        public void AddKetchup()
        {
            HasKetchup = true;
        }

        public void AddMustard()
        {
            HasMustard = true;
        }

    }
}
