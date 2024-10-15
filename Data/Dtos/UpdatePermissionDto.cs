using System.ComponentModel.DataAnnotations;

namespace JwtAuthenticationCoreWebApi.Data.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
    }
}
