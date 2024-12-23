namespace PAOO.Microunde
{
    class Stare_USA_INCHISA : Stare
    {
        //singleton implementation
        private static Stare_USA_INCHISA instance = null;
        public static Stare_USA_INCHISA Instance()
        {
            if (instance == null) instance = new Stare_USA_INCHISA();
            return instance;
        }
        public override void DeschideUsa()
        {
            context.DeschideUsa();
        }
        public override void InchideUsa() { }
        public override void Porneste()
        {
            context.Porneste();
        }
        public override void Tick_ceas() { }
    }
}
