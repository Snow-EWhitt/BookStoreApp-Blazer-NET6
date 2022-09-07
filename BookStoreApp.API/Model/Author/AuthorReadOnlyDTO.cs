namespace BookStoreApp.API.Model.Author
{
    public class AuthorReadOnlyDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
    }
}
