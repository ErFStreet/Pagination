using Server.Infrastructure;

namespace Server;

internal class Program
{
    static void Main()
    {
        var names = new List<string>
        {
            "Ali","Reza","Hoseein","Akbar","Mohammad"
            ,"Hashem","Gholam","Erfan","Roya","Amir","Asie"
            ,"Mostafa","Mehdi","Mahdi","Hasan","Asghar"
        };


        var result = new PagedList<string>(
            page: 1, pageSize: 5, totalCount: 15, items: names).Create();
            

        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}
