namespace SchoolMangementSystem
{
    internal class MidtermOne : AverageMark
    {
        private ISemester semester;
        private double midMark;

        public MidtermOne(ISemester semester, double midMark)
        {
            this.semester = semester;
            this.midMark = midMark;
        }

        public override double averageMark()
        {
            return (midMark + semester.averageMark());
        }
    }
}