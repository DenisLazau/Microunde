using PAOO_Microunde;

namespace PAOO.Microunde
{
    public abstract class Stare
    {
        public Context context;

        public Stare()
        {
            context = Context.Instance();
        }

        public abstract void Tick_ceas();
        public abstract void deschideUsa();
        public abstract void inchideUsa();
        public abstract void porneste();
    }
}
