using ASPNET_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private static readonly PhoneModel[] phones = new[]
        {
            new PhoneModel("iPhone 14 PRO", "Apple", 78599, "512Gb", "6Gb", 6.1, "Super Retina", "IOS16", "48+12+12px"),
            new PhoneModel("Realme GT 2", "Realme", 23799, "256Gb", "12Gb", 6.6, "AMOLED", "Android 12", "50+8+2px"),
            new PhoneModel("Redmi K50", "Xiaomi", 21799, "128Gb", "12Gb", 6.1, "AMOLED", "Android 11", "64+8+2px"),
            new PhoneModel("Galaxy Flip 4", "SAMSUNG", 49999, "512Gb", "8Gb", 7.1, "Dynamic Amoled", "Android 12", "12+12px"),
            new PhoneModel("Galaxy S22", "SAMSUNG", 30599, "128Gb", "8Gb", 6.1, "Dynamic Amoled", "Android 11", "50+12+10px"),
            new PhoneModel("Xiaomi 12 Lite", "Xiaomi", 16899, "128Gb", "8Gb", 6.55, "AMOLED", "Android 11", "108+8+2x"),
            new PhoneModel("Reno 7 Lite", "Oppo", 13799, "128Gb", "8Gb", 6.43, "AMOLED", "Android 11", "64+2+2px"),
            new PhoneModel("OnePlus 10T", "OnePlus", 29499, "128Gb", "8Gb", 6.7, "AMOLED", "Android 11", "50+8+2px"),
            new PhoneModel("Mate Xs 2", "Huawei", 94499, "512Gb", "8Gb", 7.8, "OLED", "Android 12", "50+13+8px"),
            new PhoneModel("Pixel 6a", "Google", 18999, "128Gb", "6Gb", 6.1, "OLED", "Android 12", "12+12px")
        };

        public ProductsController()
        {

        }

        [HttpGet(Name = "GetPhones")]
        public IEnumerable<PhoneModel> Get()
        {
            return phones.ToArray();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (id <= phones.Length)
            {
                return Ok(phones[id]);
            }
            else
            { 
                return NoContent(); 
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {

            if (phones != null)
            {
                Array.Clear(phones, id, id);
                return Ok(phones);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
