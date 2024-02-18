using Intro.Business;
using Intro.Entities;

//string message1 = "Krediler";

//int term = 12;

//double amount = 1000.5;

////variables-->camelCase
//bool isAuthenticated = false;
//Console.WriteLine(message1);

////condition
//if (isAuthenticated)
//{
//    Console.WriteLine("Buton-->Hoşgeldin Engin");
//}
//else
//{
//    Console.WriteLine("Buton-->Sisteme giriş yap");
//}
//string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
////string [] loans = new string[6];
//for (int i = 0; i < loans.Length; i++)
//{
//    Console.WriteLine(loans[0]);
//}



//Course[] courses = {course1,course2, course3 }; 

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

CourseManager courseManager = new();
Course [] courses2= courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod Bitti");

IndividualCustomer customer1 = new();
customer1.Id = 1;
customer1.NationalIdentity = "65785678909";
customer1.FirstName = "Aslı";
customer1.LastName = "Kara";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new();
customer1.Id = 2;
customer1.NationalIdentity = "12345678909";
customer1.FirstName = "Murat";
customer1.LastName = "Karaçay";
customer1.CustomerNumber = "903456";

CoorporateCustomer customer3 = new();
customer3.Id = 3;
customer3.Name = "kodlama.io";
customer3.CustomerNumber = "903456";
customer3.TaxNumber = "123456987699";


CoorporateCustomer customer4 = new();
customer3.Id = 4;
customer4.Name = "Abc.io";
customer4.CustomerNumber = "9786456";
customer4.TaxNumber = "123006987699";

BaseCustomer[] customers = {customer1, customer2 ,customer3, customer4};

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);

}