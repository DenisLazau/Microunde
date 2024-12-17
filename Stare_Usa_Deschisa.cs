namespace PAOO.Microunde
{
    class Stare_USA_DESCHISA : Stare
    {
        //singleton implementation
        private static Stare_USA_DESCHISA instance = null;
        public static Stare_USA_DESCHISA Instance()
        {
            if (instance == null) instance = new Stare_USA_DESCHISA();
            return instance;
        }

        public override void deschideUsa() { }

        public override void inchideUsa()
        {
            context.inchideUsaContext();
        }

        public override void porneste()
        {
            context.displayErrorUsa();
        }

        public override void Tick_ceas() { }
    }
}
