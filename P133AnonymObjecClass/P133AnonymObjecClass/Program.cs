using System;

namespace P133AnonymObjecClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonym Objec Type
            //Anonym Objec
            //var stu1 = new
            //{
            //    name="Hamid",
            //    surName="Mammadov",
            //    age = 32
            //};

            //Console.WriteLine(stu1.name+" "+stu1.surName);
            #endregion

            #region Custom Class type
            //Student stu1 = new Student();
            //Program program1 = new Program();
            //Int32 asd = new Int32();
            //int a = 54;
            //stu1.Age = 20;

            //stu1.Name = "Semed";
            //stu1.SurName = "Aliyev";

            //Console.WriteLine($"Name: {stu1.Name}\nSurName: {stu1.SurName}");
            //Console.WriteLine(stu1.GetFullName());

            //int age = stu1.Age;

            //Console.WriteLine(age);

            //Student stu2 = new Student();
            //stu2.Name = "Cavid";
            //stu2.SurName = "Aliyev";
            ////stu2 = stu1;

            //stu2.Age = 23;

            //Console.WriteLine(stu2.GetFullName());

            //Console.WriteLine(stu1.Age);


            //Test(stu1);

            //Console.WriteLine(stu1.Age);
            //Console.WriteLine(stu2.Age);
            //int b = 5;

            //int a = 5;



            #endregion

            #region Aggregate
            //Student student1 = new Student();
            //student1.Name = "Ramiz";
            //student1.SurName = "Quliyev";
            //student1.Age = 20;
            //student1.Address = new Address();
            //student1.Address.Country = "Azerbaijan";
            //student1.Address.City = "Baki";
            //student1.Address.ZipCode = "AZ1111";
            //Console.WriteLine(student1.GetFullInfo());

            //Company company = new Company();
            //company.Name = "Shop.Az";
            //company.Logo = "Shop.jpg";
            //company.Address = new Address();
            //company.Address.Country = "Azerbaijan";
            //company.Address.City = "Baki";
            //company.Address.ZipCode = "AZ1112";
            //Console.WriteLine(company.GetFullInfo());
            byte age = 20;

            Student student1 = new Student("Ramiz", "Quliyev",age);

            Company company = new Company();
            company.Name = "Shop.Az";
            company.Logo = "Shop.jpg";

            Address address = new Address();
            address.Country = "Azerbaijan";
            address.City = "Baki";
            address.ZipCode = "AZ1111";

            student1.Address = address;
            company.Address = address;

            Console.WriteLine(student1.GetFullInfo());
            Console.WriteLine(company.GetFullInfo());
            #endregion
        }

        static void Test(Student student)
        {
            student.Age = 70;

            //return student;
        }
    }

    #region Custom Type
    //Custom Type
    //class Student
    //{
    //    //Field
    //    public string Name;
    //    public string SurName;
    //    public byte Age;
    //}
    #endregion
}
