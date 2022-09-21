using Microsoft.AspNetCore.Http;

namespace Test_List.DTOs
{
    public class PersonCreationDTO
    {
        //[FileSizeValidator(MaxFileSizeInMbs: 4)]
        //[ContentTypeValidator(ContentTypeGroup.Image)]
        public IFormFile Picture { get; set; }
    }
}