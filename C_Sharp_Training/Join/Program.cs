using System;

namespace Join {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("************************** Group Join **********************");
            Sample_GroupJoin_LeftOuterJoin();

            Console.WriteLine("************************** Join **********************");
            Sample_Join_InnerJoin();
        }
        static void Sample_GroupJoin_LeftOuterJoin() {
            Language[] languages = new Language[] {
                new Language { Id=1, Name="English"},
                new Language { Id=2, Name="Russian"}
            };
            Person[] persons = new Person[] {
                new Person{ LanguageId=1, FirstName="Tom"},
                new Person{ LanguageId=1, FirstName="Sandy"},
                new Person{ LanguageId=2, FirstName="Vladimir"},
                new Person{ LanguageId=2, FirstName="Mikhail"}
            };
            //Lambda Expression
            var result = languages.GroupJoin(persons, lang => lang.Id, pers => pers.LanguageId, (lang, ps) => new { Key = lang.Name, Person = ps });

            //Query Expression
            //var result = from lang in languages join pers in persons on lang.Id equals pers.LanguageId into ps select new { Key = lang.Name, Person = ps };
            Console.WriteLine("Group-joined list of people speaking either English or Russian:");
            foreach (var lang in result) {
                Console.WriteLine(String.Format("Persons speaking {0}:", lang.Key));
                foreach (var person in lang.Person) {
                    Console.WriteLine(person.FirstName);
                }
            }
        }
        //Join: Joins two collections by a common key value, and is similar to inner join in SQL.
        //This Lambda Expression sample joins two arrays where elements match in both.

        //Join: Joins two collections by a common key value, and is similar to inner join in SQL.
        //This Query Expression sample joins two arrays where elements match in both.
        static void Sample_Join_InnerJoin() {
            string[] warmCountries = { "Turkey", "Itlay", "Spain", "Saudi Arabia", "Etiobia" };
            string[] europeanCountries = { "Denmark", "Germany", "Itlay", "Portugla", "Spain" };

            //Lambda Expression
            var result = warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm);

            //Query Expression
            var result1 = from w in warmCountries join e in europeanCountries on w equals e select w;

            Console.WriteLine("Joined Countries which are both warm and European");

            foreach (var country in result) {
                Console.WriteLine(country);
            }

        }
    }
}
