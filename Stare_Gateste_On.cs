namespace PAOO.Microunde
{
    internal class Stare_GATESTE_ON : Stare
    {
        //singleton implementation
        private static Stare_GATESTE_ON instance = null;
        public static Stare_GATESTE_ON Instance()
        {
            if (instance == null) instance = new Stare_GATESTE_ON();
            return instance;
        }

        public override void deschideUsa()
        {
            context.deschideUsaContext();
        }

        public override void inchideUsa() { }

        public override void porneste() { }

        public override void Tick_ceas()
        {
            context.tickCeasContext();
        }
    }
}
