using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_7
{
    internal class List_demo
    {
        public void list()
        {

            List<string> student = new List<string>();

            // Add students
            student.Add("afsana");
            student.Add("asma");
            Console.WriteLine("After Adding: " + string.Join(", ", student.ToArray()));

            // Remove a student by index
            student.RemoveAt(1);
            Console.WriteLine("After Removing: " + string.Join(", ", student.ToArray()));

            // Remove range
            student.AddRange(new List<string> { "Alice", "Bob", "Charlie" });
            student.RemoveRange(0, 2);
            Console.WriteLine("After Removing Range: " + string.Join(", ", student.ToArray()));

            // Clear all students
            student.Clear();
            Console.WriteLine("After Clearing: Count = " + student.Count);
        } 
    }
}
