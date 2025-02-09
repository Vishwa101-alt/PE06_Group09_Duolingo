namespace FSDProject.Domain
{
    public class CourseDatabase : BaseDomainModel
    {
        public int CourseDatabaseId { get; set; }//Primary key property

        public string? LanguageName { get; set; }

        public ICollection<StoreItem>? StoreItems { get; set; }//Navigator Property
    }
}
