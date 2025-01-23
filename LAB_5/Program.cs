namespace PR_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choise two exicte program:");
            int i=int.Parse(Console.ReadLine());
            switch (i) {

                case 1:
                    Array_list array_List = new Array_list();
                    array_List.Array();

                break;
                case 2:
                
                    List_demo list1 = new List_demo();
                    list1.list();


                break;
                case 3:
                    Stack_opration listw=new Stack_opration();
                    listw.stack_demo();

                    break;
                case 4:
                    Queue_opration queue_Opration = new Queue_opration();
                    queue_Opration.Queue_demo();

                break;
                case 5:
                    Dictionary_Operations dictionary_Operations = new Dictionary_Operations();
                    dictionary_Operations.distionay();
                    break;
                case 6:
                    Hashtable_Operations hashtable_Operations = new Hashtable_Operations();
                    hashtable_Operations.hash_demo(); 
                break;
                 default:
                    Console.WriteLine("Please Enter A valid choise");
                    break;


            }
        }
    }
}
