using System;
/// <summary>
/// Custom generic class Queue
/// </summary>
/// <typeparam name="T">Could be any type</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Used for getter and setter
    /// </summary>
    /// <value>The first element in the Queue.</value>
    public Node head { get; set; }
    /// <summary>
    /// Used for getter and setter
    /// </summary>
    /// <value>The Last element in the Queue.</value>
    public Node tail { get; set; }
    /// <summary>
    /// Number of queued elements.
    /// </summary>
    public int count;
    /// <summary>
    /// Checks the type of this generic class.
    /// </summary>
    /// <returns>Returns the type of the generic class.</returns>
    public String CheckType(){
        return (typeof(T).ToString());
    }
    /// <summary>
    /// Creates a new Node and adds it to the end of the queue.
    /// </summary>
    public void Enqueue(T value){
        Node n = new Node(value);
        if (count == 0){
            head = n;
            tail = n;
        }
        else{
            tail.next = n;
            tail = n;
        }
        this.count += 1;
    }
    /// <summary>
    /// Remove an element from the front of the queue
    /// </summary>
    /// <returns>Returns the value of removed element</returns>
    public T Dequeue(){
        if (head == null){
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        T val = head.value;
        head = head.next;
        count -= 1;
        return (val);
    }
    /// <summary>
    /// Gets the count of nodes in the queue.
    /// </summary>
    /// <returns>Returns the number of queued elements.</returns>
    public int Count(){
        return (this.count);
    }
    /// <summary>
    /// Node of the queue.
    /// </summary>
    public class Node{
        /// <summary>
        /// Node's value
        /// </summary>
        /// <value>Get or set the node's value</value>
        public T value { get; set; } = default(T);


        /// <summary>
        /// Next node
        /// </summary>
        /// <value>Get or set the next node</value>
        public Node next { get; set; } = null;


        /// <summary>
        /// Default constructor for node class.
        /// </summary>
        /// <param name="value">Setting up the node value on initialisation.</param>
        public Node(T value){
            this.value = value;
        }
    }
}
