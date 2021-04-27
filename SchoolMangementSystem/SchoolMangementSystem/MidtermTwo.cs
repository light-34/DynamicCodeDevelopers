namespace SchoolMangementSystem
{
    internal class MidtermTwo : AverageMark
    {

        private ISemester semester;
        private double midMark;

        public MidtermTwo(ISemester semester, double midMark)
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