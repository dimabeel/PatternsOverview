namespace Builder.TeaFactory
{
    public interface ITeaDirector
    {
        void MakeTea();

        void ChangeBuilder(ITeaBuilder teaBuilder);
    }
}
