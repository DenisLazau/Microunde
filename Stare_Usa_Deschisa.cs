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
