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
        public override void deschideUsa()
        {
            context.deschideUsaContext();
        }
        public override void inchideUsa() { }
        public override void porneste()
        {
            context.pornesteContext();
        }
        public override void Tick_ceas() { }
    }
}
