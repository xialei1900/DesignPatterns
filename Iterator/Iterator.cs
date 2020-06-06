using System.Collections;

namespace Iterator
{
    public abstract class Iterator:IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract bool MoveNext();
        public abstract void Reset();
        public abstract object Current();
    }
}