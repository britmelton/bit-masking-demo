namespace bit_masking_demo.Domain
{
    public class Options : ValueObject
    {
        public bool HasKetchup { get; set; }

        public override IEnumerable<object> GetEqualityComponents() => throw new NotImplementedException();
    }
}
