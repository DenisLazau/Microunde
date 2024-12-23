namespace PAOO.Microunde
{
    internal class StareGatesteOn : Stare
    {
        private static StareGatesteOn instance;
        public static StareGatesteOn Instance()
        {
            if (instance == null)
            {
                instance = new StareGatesteOn();
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
            context.Timp_ramas += 30;
        }

        public override void Tick_ceas()
        {
            context.tickCeasContext();
        }
    }
}
