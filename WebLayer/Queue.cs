namespace WebLayer
{
    public class Queue<T>
    {
        private List<T> _queue = new List<T>();

        public void Enqueue(T item)
        {
            _queue.Add(item);
        }

        public T Dequeue()
        {
            if (_queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T item = _queue[0];
            _queue.RemoveAt(0);
            return item;
        }

        public int Count => _queue.Count;

        // Other queue methods can be added as needed
    }

}
// Example Queue<int> queue = new Queue<int>();
// queue.Enqueue(10);
// queue.Enqueue(20);
// int item = queue.Dequeue(); // Dequeues 10
