namespace SchoolMangementSystem
{
    internal class MidtermThree : AverageMark
    {
        private ISemester semester;
        private double midMark;

        public MidtermThree(ISemester semester, double midMark)
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