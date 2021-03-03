using Builder.TeaFactory.Tea;

namespace Builder.TeaFactory
{
    public class UsualTeaBulder : ITeaBuilder
    {
        public UsualTeaBulder()
        {
            this.tea = new Tea.Tea();
        }

        public void AddHerb() { tea.Herb = new Herb(); }

        public void AddLemon() { }

        public void AddSugar() { }

        public ITea GetTea()
        {
            return tea;
        }

        ITea tea;
    }
}
