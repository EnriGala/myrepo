
using Realwebbo.Model;

namespace Realwebbo.Services
{
    class CorporationServices
    {
        public Corporation FillCorp()
        {
            return new Corporation()
            {
                Name = "dodocorp",
                Code = "125",
                LegalAddress = new LegalAddress()
                {
                    Address = "via pastrengo",
                    City = "bolo",
                    Province = "bolo",
                    Region = "er",
                    Country = "IT"
                }
            };

        }

        public Corporation FillOtherCorp(string name, string code, LegalAddress legalAddress)
        {
            return new Corporation()
            {
                Name = name,
                Code = code,
                LegalAddress = legalAddress
            };
        }
    }
}
