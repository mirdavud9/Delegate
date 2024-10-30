namespace Delegate_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////////Person
            ///Muellim taskda bildirmisdi ki yasi 20den cox olan amma men sagirdlere aid misal goturdum deye bele yazdim
            List<Person> people = new List<Person>
        {
                new Person("Izzet", "Xanimeliyev", 9),
                new Person("Elvin", "Huseynov", 15),
                new Person("Leyla", "Karimova", 6),
                new Person("Aysel", "Aliyeva", 14),
                new Person("Kamil", "Zeynalli", 12)
        };


            List<Person> izzetPersons = people.FindAll(p => p.Name == "Izzet");
            Console.WriteLine("Adi Izzet olan sexsler:");
            foreach (Person p in izzetPersons)
            {
                Console.WriteLine($"{p.Name} , {p.Surname} , {p.Age}");
            }


            List<Person> surnameFiltered = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            Console.WriteLine("\nSoyadi 'ov' ve ya 'ova' ile biten sexsler:");
            foreach (Person p in surnameFiltered)
            {
                Console.WriteLine($"{p.Name} , {p.Surname} , {p.Age}");
            }


            List<Person> ageFiltered = people.FindAll(p => p.Age > 8);
            Console.WriteLine("\nYasi 8den boyuk olan sexsler:");
            foreach (Person p in ageFiltered)
            {
                Console.WriteLine($"{p.Name} , {p.Surname} , {p.Age}");
            }
             ///
            List<Exam> exams = new List<Exam>
        {
                new Exam("Programlasdirma", TimeSpan.FromHours(1.5), DateTime.Now.AddDays(-3)),
                new Exam("Herbi", TimeSpan.FromHours(4), DateTime.Now.AddDays(-6)),
                new Exam("Fiziki terbiye", TimeSpan.FromHours(2), DateTime.Now.AddHours(-1)),
                new Exam("Heyat bilgisi", TimeSpan.FromHours(2.5), DateTime.Now.AddDays(-5))
        };

            DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
            DateTime now = DateTime.Now;


            var upcomingExams = exams.Where(e => e._startDate >= oneWeekAgo && e._startDate <= now.AddDays(7));
            Console.WriteLine("\n\n1 heftede olan imtahanlar:");
            foreach (var exam in upcomingExams)
            {
                Console.WriteLine($"Movzu: {exam._subject}, Muddet: {exam._examDuration.TotalHours} saat");
            }


            var longDurationExams = exams.Where(e => e._examDuration.TotalHours > 2);
            Console.WriteLine("\n2 saatdan cox imtahanlar:");
            foreach (var exam in longDurationExams)
            {
                Console.WriteLine($"Movzu: {exam._subject}, muddet: {exam._examDuration.TotalHours} saat:");
            }


            var ongoingExams = exams.Where(e => e._startDate <= now && e.EndDate >= now);
            Console.WriteLine("\nDavam eden imtahanlar");
            foreach (var exam in ongoingExams)
            {
                Console.WriteLine($"Movzu: {exam._subject}, Muddet: {exam._examDuration.TotalHours} saat");
            }
        }
    }
}