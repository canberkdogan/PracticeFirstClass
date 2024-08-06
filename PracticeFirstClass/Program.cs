using PracticeFirstClass;

public class Program
{
    static void Main(string[] args)
    {
        Person ogrenci = new Person();
        
        ogrenci.Name = "Canberk";

        ogrenci.Surname = "Doğan";

        ogrenci.BirthDate = new DateTime(1999, 06, 21);


        Person ogrenci1 = new Person();

        ogrenci1.Name = "Ceyda";

        ogrenci1.Surname = "Yılmaz";

        ogrenci1.BirthDate = new DateTime(1999, 02, 07);



        Person ogretmen = new Person();

        ogretmen.Name = "Furkan";

        ogretmen.Surname = "Coşkun";

        ogretmen.BirthDate = new DateTime(1986, 10, 06);  


        Person ogretmen1 = new Person();

        ogretmen1.Name = "Walter";

        ogretmen1.Surname = "White";

        ogretmen1.BirthDate = new DateTime(1970, 05, 27);


        Console.WriteLine("Students");
        ogrenci.DisplayInfo();
        ogrenci1.DisplayInfo();

        Console.WriteLine("Teachers");
        ogretmen.DisplayInfo();
        ogretmen1.DisplayInfo();



    }

}
