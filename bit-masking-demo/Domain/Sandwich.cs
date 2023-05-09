namespace bit_masking_demo.Domain
{
    public class Sandwich
    {
        public bool HasKetchup { get; set; }

        public void AddKetchup()
        {
            HasKetchup = true;
        }

    }
}
