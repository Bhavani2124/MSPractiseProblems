using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;



namespace MicrosoftProblems
{
    using System;
    using System.Collections.Generic;

   
    public class Map<K, V>
    {
        private List<MapNode<K, V>> buckets;
        private int count;
        private int numBuckets;

        public Map()
        {
            buckets = new List<MapNode<K, V>>(new MapNode<K, V>[20]);
            numBuckets = 20;
            count = 0;
        }

        private int getBucketIndex(K key)
        {
            int hc = key.GetHashCode();
            return Math.Abs(hc % numBuckets); // Ensure non-negative index
        }

        public void inser(K key, V value)
        {
            int bucketIndex = getBucketIndex(key);
            MapNode<K, V> head = buckets[bucketIndex];

            // Check if the element is already present
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value; // Update value
                    return;
                }
                head = head.next;
            }

            // Insert new node at the beginning of the list
            MapNode<K, V> newNode = new MapNode<K, V>(key, value);
            newNode.next = buckets[bucketIndex];
            buckets[bucketIndex] = newNode;
            count++;

            // Check load factor and rehash if necessary
            if (loadFactor() > 0.7)
            {
                reHash();
            }
        }

        public double loadFactor()
        {
            return (1.0 * count) / numBuckets;
        }

        private void reHash()
        {
            List<MapNode<K, V>> temp = buckets;
            buckets = new List<MapNode<K, V>>(new MapNode<K, V>[numBuckets * 2]);
            count = 0; // Reset count for rehashing
            numBuckets *= 2; // Double the number of buckets

            // Re-insert all existing elements
            foreach (var head in temp)
            {
                MapNode<K, V> current = head;
                while (current != null)
                {
                    inser(current.Key, current.Value);
                    current = current.next;
                }
            }
        }

        public int size()
        {
            return count;
        }

        public V getValue(K key)
        {
            int bucketIndex = getBucketIndex(key);
            MapNode<K, V> head = buckets[bucketIndex];

            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    return head.Value;
                }
                head = head.next;
            }

            return default(V); // Return default value if not found
        }

        public V removeKey(K key)
        {
            int bucketIndex = getBucketIndex(key);
            MapNode<K, V> head = buckets[bucketIndex];
            MapNode<K, V> prev = null;

            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    if (prev != null)
                    {
                        prev.next = head.next;
                    }
                    else
                    {
                        buckets[bucketIndex] = head.next; // Remove head
                    }
                    count--;
                    return head.Value; // Return the removed value
                }

                prev = head;
                head = head.next;
            }

            return default(V); // Return default value if key not found
        }
    }

    public class MapUse
    {
        public static void SMain(string[] args)
        {
            Map<string, int> map = new Map<string, int>();
            for (int i = 0; i < 20; i++)
            {
                map.inser("abc" + i, i + 1);
                Console.WriteLine($"Load factor after inserting abc{i}: {map.loadFactor():F2}");
            }

            map.removeKey("abc3");
            map.removeKey("abc5");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"abc{i}: {map.getValue("abc" + i)}");
            }
        }
    }



}
