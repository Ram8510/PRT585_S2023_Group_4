using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class RegisterDto
    {
        public int RegisterId { get; set; }
        public string RegisterName { get; set; }
                        
    }

    public static class RegisterDtoMapExtensions
    {
        public static RegisterDto ToRegisterDto(this RegisterModel src)
        {
            var dst = new RegisterDto();
            dst.RegisterId = src.RegisterId;
            dst.RegisterName = src.RegisterName;            
            return dst;
        }

        public static RegisterModel ToRegisterModel(this RegisterDto src)
        {
            var dst = new RegisterModel();
            dst.RegisterId = src.RegisterId;
            dst.RegisterName = src.RegisterName;            
            return dst;
        }
    }
}
