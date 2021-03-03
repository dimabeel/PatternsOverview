namespace Builder.TeaFactory
{
    public class TeaDirector : ITeaDirector
    {
        public TeaDirector(ITeaBuilder teaBuilder)
        {
            this.teaBuilder = teaBuilder;
        }

        public void MakeTea()
        {
            teaBuilder.AddHerb();
            teaBuilder.AddSugar();
            teaBuilder.AddLemon();
        }

        public void ChangeBuilder(ITeaBuilder teaBuilder)
        {
            this.teaBuilder = teaBuilder;
        }

        ITeaBuilder teaBuilder;
    }
}
