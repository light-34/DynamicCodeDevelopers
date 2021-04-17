namespace SchoolMangementSystem
{
    internal class ExperimentToQuestionAdapter : IQuestion
    {
        Experiment experiment;
        public ExperimentToQuestionAdapter(Experiment experiment)
        {
            this.experiment = experiment;
        }

        public void Explain()
        {
            experiment.Prove();
        }
    }
}