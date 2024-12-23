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

        public override void DeschideUsa()
        {
            context.DeschideUsa();
        }

        public override void InchideUsa() { }

        public override void Porneste() { }

        public override void Tick_ceas()
        {
            context.tickCeasContext();
        }
    }
}
