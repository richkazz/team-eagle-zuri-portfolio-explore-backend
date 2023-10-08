namespace Zuri_Portfolio_Explore.Domains.DTOs.Response{
    public class PortfolioResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Provider { get; set; }
        public List<string> Skills { get; set; }
        public int Projects { get; set; }
        //TODO:: Some more items to be added pending avaliablity in DB {Address, Role, Badge}
    }
}