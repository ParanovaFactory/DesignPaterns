namespace DesignPatern.TemplateMethod.TemplatePatern
{
    public class BasicPlan : Plans
    {
        public override string Content(string Content)
        {
            return Content;
        }

        public override int CountPerson(int countperson)
        {
            return countperson;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
