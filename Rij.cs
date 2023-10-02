
namespace WerkenMetRijen
{
    internal class Rij <T>
    {
        List<T> container;

        internal Rij()
        {
            container = new List<T>(); // Bij elke aanmaak van contructor maak een lijst aan
        }

        public void Toevoegen(T i)
        {
            container.Add(i);
        }

        public bool isLeeg() {
            return container.Count == 0;
        }

        public T Uithalen()
        {
            //if (container.Count == 0)
            //    return T.MinValue;

            T even = container[0];
            container.RemoveAt(0);
            return even;
        }

        public void MaakLeeg()
        {
            container.Clear();
        }

        public override string ToString()
        {
            String s = "";
            foreach (T i in container)
            {
                s += i.ToString() + "\n";
            }
            return s;

        }
    }
}
