// See https://aka.ms/new-console-template for more information

using Business.Concerete;
using Entities.Concrete;


List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir"};
sehirler.Add("Adana");
foreach (string s in sehirler)
{
    Console.WriteLine(s);
}

PttManager pttManager = new PttManager(new PersonManager());
Person person1 = new Person();
person1.FirstName = "Yusuf";
person1.LastName = "Kızgın";
person1.NationalIdentity = 13565461811;
person1.DateOfBirthYear = 2004;
pttManager.GiveMask(person1);