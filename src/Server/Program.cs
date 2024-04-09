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
            page: 4, pageSize: 5, totalCount: names.Count, items: names).Create();


        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}
