using System;
using System.Collections.Generic;

namespace AnimalShelterBuilderPool.Pool
{
    /// <summary>
    /// Узагальнений пул об'єктів: керує повторним використанням ресурсів.
    /// </summary>
    public sealed class ObjectPool<T> where T : class
    {
        private readonly Func<T> _factory;
        private readonly Action<T>? _reset;
        private readonly Stack<T> _items = new();
        private readonly int _maxSize;
        private int _created;

        public ObjectPool(Func<T> factory, Action<T>? reset = null, int maxSize = 100)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _reset = reset;
            _maxSize = Math.Max(1, maxSize);
        }

        public int AvailableCount => _items.Count;
        public int CreatedCount => _created;

        public T Acquire()
        {
            if (_items.Count > 0)
            {
                var item = _items.Pop();
                Console.WriteLine($"[Pool] Acquire → reuse {typeof(T).Name}");
                return item;
            }
            if (_created < _maxSize)
            {
                _created++;
                Console.WriteLine($"[Pool] Acquire → new {typeof(T).Name}");
                return _factory();
            }

            Console.WriteLine($"[Pool] Acquire → limit reached; creating extra {typeof(T).Name}");
            return _factory();
        }

        public void Release(T item)
        {
            _reset?.Invoke(item);
            if (_items.Count < _maxSize)
            {
                _items.Push(item);
                Console.WriteLine($"[Pool] Release → store {typeof(T).Name}");
            }
            else
            {
                Console.WriteLine($"[Pool] Release → drop (pool full) {typeof(T).Name}");
            }
        }
    }
}
