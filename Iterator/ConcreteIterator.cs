using System;

namespace Iterator
{
    //字母顺序迭代器
    public class ConcreteIterator : Iterator
    {
        private ConcreteCollection _collection;

        private int _position = -1;

        private readonly bool _reverse = false;

        public ConcreteIterator(ConcreteCollection collection, bool reverse)
        {
            _collection = collection;
            _reverse = reverse;

            if (_reverse)
            {
                this._position = _collection.GetItems().Count;
            }
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatePosition = _position + (_reverse ? -1 : +1);

            if (updatePosition >= 0 && updatePosition < _collection.GetItems().Count)
            {
                _position = updatePosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }
    }
}