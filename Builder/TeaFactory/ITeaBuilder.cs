using Builder.TeaFactory.Tea;

namespace Builder.TeaFactory
{
    public interface ITeaBuilder
    {
        void AddHerb();

        void AddSugar();

        void AddLemon();

        ITea GetTea();
    }
}
