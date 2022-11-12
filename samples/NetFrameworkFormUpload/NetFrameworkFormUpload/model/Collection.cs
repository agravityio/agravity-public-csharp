namespace NetFrameworkFormUpload.model
{
    public class Collection
    {
        public Collection(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
