namespace ECommerce.Api.Customers.Profiles
{
    public class CustomersProfile : AutoMapper.Profile
    {
        public CustomersProfile()
        {
            CreateMap<Db.Customer, Models.Customer>();
        }
    }
}
