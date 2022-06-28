namespace APSCore_CRUD_BookStore.Model
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string CoverImg { get; set; }
    }
}
