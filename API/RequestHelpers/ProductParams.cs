namespace API.RequestHelpers
{
    public class ProductParams :  PaginationParams
    {
        public string orderBy { get; set; } 
        public string searchTerm { get; set; }

        public string Types { get; set; }

        public string Brands { get; set; }

    }
}