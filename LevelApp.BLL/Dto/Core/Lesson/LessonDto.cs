using System.ComponentModel.DataAnnotations;

namespace LevelApp.BLL.Dto.Core.Lesson
{
    public class LessonDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}