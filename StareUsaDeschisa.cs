namespace PAOO.Microunde
{
    class StareUsaDeschisa : Stare
    {
        private static StareUsaDeschisa instance;
        public static StareUsaDeschisa Instance()
        {
            if (instance == null)
            {
                instance = new StareUsaDeschisa();
            }
            return instance;
        }

        public override void DeschideUsa() { }

        public override void InchideUsa()
        {
            context.InchideUsa();
        }

        public override void Porneste()
        {
        }

        public override void Tick_ceas() { }
    }
}
