namespace InterfaceExample
{
    class Test : ITest
    {
        int testX;

        public int X
        {
            get => testX;
            set => testX = value;
        }

        public virtual int Test1()
            => X + 1;

        public int Test2()
            => X + 2;
    }
}