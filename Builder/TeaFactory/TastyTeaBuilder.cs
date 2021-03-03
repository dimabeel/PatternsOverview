using Builder.TeaFactory.Tea;

namespace Builder.TeaFactory
{
    public class TastyTeaBuilder : ITeaBuilder
    {
        public TastyTeaBuilder()
        {
            this.tea = new Tea.Tea();
        }

        public void AddHerb() { tea.Herb = new Herb(); }

        public void AddLemon() { tea.Lemon = new Lemon(); }

        public void AddSugar() { tea.Sugar = new Sugar(); }

        public ITea GetTea()
        {
            return tea;
        }

        ITea tea;
    }
}
