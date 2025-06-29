
namespace QtecLabTask.Core.Entities
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual ICollection<JournalEntryLine> JournalEntryLine { get; set; }
    }
}
