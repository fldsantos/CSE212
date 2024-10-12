﻿using System.Diagnostics;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        bool wasAdded = false;
        int qSize = _queue.Count;

        if(_queue.Count == 0) {
            _queue.Insert(0, newNode);
        } else {

            for (int i = 0; i < qSize; i++) {
                if (_queue[i].Priority == newNode.Priority) {
                    _queue.Insert(i, newNode);
                    wasAdded = true;
                }
             }

             if(!wasAdded) {_queue.Add(newNode);}
        }

        Debug.WriteLine(String.Join(", ", _queue));
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Remove and return the item with the highest priority
        var value = _queue[_queue.Count-1].Value;
        _queue.RemoveAt(_queue.Count-1);
        Debug.WriteLine(String.Join(", ", _queue));
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}