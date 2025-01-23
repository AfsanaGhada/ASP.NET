using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_7
{
    internal class Hashtable_Operations
    {
        public void hash_demo()
        {
           

            Hashtable students = new Hashtable();

            // Add key-value pairs
            students.Add(1, "Ghada");
            students.Add(2, "Afsana");
            students.Add(3, "rahimbhai");
            Console.WriteLine("After Adding: " + string.Join(", ", students.Keys.Cast<int>().Select(k => k + "=" + students[k])));

            // Remove a key-value pair
            students.Remove(1);
            Console.WriteLine("After Removing: " + string.Join(", ", students.Keys.Cast<int>().Select(k => k + "=" + students[k])));

            // Check key and value existence
            Console.WriteLine("Contains Key 2: " + students.ContainsKey(2));
            Console.WriteLine("Contains Value 'Alice': " + students.ContainsValue("Alice"));

            // Clear hashtable
            students.Clear();
            Console.WriteLine("After Clearing: Count = " + students.Count);
        }
    }
}
