using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personenListe = new List<Person>();
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Person person5 = new Person();
            Person person6 = new Person();
            Person person7 = new Person();
            Person person8 = new Person();



            person1.Vorname = "Abdul";
            person1.Nachname = "Ghwaji";

            person2.Nachname = "Herb";
            person2.Vorname = "Sebastian";

            person4.Nachname = "Herb";
            person4.Vorname = "Sepp";

            person5.Nachname = "Herb";
            person5.Vorname = "Georg";

            person3.Vorname = "Daniel";
            person3.Nachname = "Will";

            person6.Vorname = "Daniel";
            person6.Nachname = "Will";

            person7.Vorname = "Peter";
            person7.Nachname = "Will";

            person8.Vorname = "Hans";
            person8.Nachname = "Will";


            personenListe.Add(person1);
            personenListe.Add(person2);
            personenListe.Add(person3);
            personenListe.Add(person4);
            personenListe.Add(person5);
            personenListe.Add(person6);
            personenListe.Add(person7);
            personenListe.Add(person8);


            //IEnumerable<Person> result = personenListe.Where(s => s.Nachname == "Herb" );

            // Action (Funktion), Parameter-Datentyp (IEnumerable<Person>), Action-Name (stringResult), Parameter (personen)
            Action<IEnumerable<Person>> findeVornamen = personen =>
            {
                // Auswählen des gewünschten Wertes -> Vorname
                IEnumerable<string> vornamen = personen.Select(p => p.Vorname);
                foreach (string vorname in vornamen) { Console.WriteLine(vorname); }
            };

            findeVornamen(personenListe.Where(s => s.Nachname == "Herb"));

            findeVornamen(personenListe.Where(s => s.Nachname == "Will"));


            //foreach (Person person in result)
            //{
            //    Console.WriteLine($"{person.Vorname}");
            //}

            Console.WriteLine("---- ENDE ----");
            Console.ReadLine();
        }


        //public IEnumerable<Person> stringResult2(IEnumerable<Person> personen)
        //{
        //    // Logik zum rausfiltern
        //}

    }
}
