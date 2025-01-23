namespace TEST_1
{
    public class Dictionary_data
    {
 
            public void distionay()
            {
                Dictionary<string,string> students = new Dictionary<string, string>();

                students.Add( "ghada","AA");
                students.Add( "afsana","AB");

                students.Add( "Rahimbhai","A+");
                Console.WriteLine("After Adding: " + string.Join(", ", students.Select(kv => kv.Key + "=" + kv.Value)));

                students.Remove("ghada");
                Console.WriteLine("After Removing: " + string.Join(", ", students.Select(kv => kv.Key + "=" + kv.Value)));

                
                Console.WriteLine("Contains Key 2: " + students.ContainsKey("afsana"));
                Console.WriteLine("Contains Value 'Alice': " + students.ContainsValue("Alice"));

                
                Console.WriteLine("After Clearing: Count = " + students.Count);
            }
        }
    }

