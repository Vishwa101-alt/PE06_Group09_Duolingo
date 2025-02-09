namespace FSDProject.Domain
{
    public class StoreItem : BaseDomainModel
    {
        
        public int StoreItemId { get; set; }//Primary key property
        public string? Questions { get; set; }
        public string? MultipleChoice1 { get; set; }
        public string? MultipleChoice2 { get; set; }
        public string? MultipleChoice3 { get; set; }
        public string? MultipleChoice4 { get; set; }

        public int? Answer{ get; set; }

        public int CourseDatabaseId { get; set; }//Foreign Key Property
        public CourseDatabase? CourseDatabase { get; set; }//Navigator Property
      
        public ICollection<Score>? Scores { get; set; }//Navigator Property

    

    }
}
