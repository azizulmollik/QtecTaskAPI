
namespace QtecLabTask.Core.DTOs
{
    public class JournalEntryDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public List<JournalEntryLineDto> JournalEntryLine { get; set; }
    }
}
