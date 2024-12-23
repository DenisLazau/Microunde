namespace PAOO.Microunde
{
    class StareUsaInchisa : Stare
    {
        private static StareUsaInchisa instance;
        public static StareUsaInchisa Instance()
        {
            if (instance == null)
            {
                instance = new StareUsaInchisa();
            }
            return instance;
        }
        public override void DeschideUsa()
        {
            context.DeschideUsa();
        }
        public override void InchideUsa() { }
        public override void Porneste()
        {
            context.Timp_ramas += 10;
            context.Porneste();
        }
        public override void Tick_ceas() { }
    }
}
