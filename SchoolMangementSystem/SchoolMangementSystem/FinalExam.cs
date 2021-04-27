namespace SchoolMangementSystem
{
    internal class FinalExam : AverageMark
    {
        private ISemester semester;
        private double midMark;

        public FinalExam(ISemester semester, double midMark)
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