namespace DesignPatern.TemplateMethod.TemplatePatern
{
    public abstract class Plans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }
        public abstract string PlanType (string planType);
        public abstract int CountPerson (int countperson);
        public abstract double Price (double price);
        public abstract string Resolution (string resolution);
        public abstract string Content (string Content);
    }
}
