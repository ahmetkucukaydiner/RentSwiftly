namespace RentSwiftly.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}