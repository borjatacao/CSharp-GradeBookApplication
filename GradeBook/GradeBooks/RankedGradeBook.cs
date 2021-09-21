namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : BaseGradeBook(name)
        {
            Type = StandardGradeBook.Ranked;
        }
    }
}