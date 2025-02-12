using System.Xml.Linq;

namespace Demo1_LinQ_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Implicitly Typed Local Variable [Var , Dynamic] 

            #region Var
            ///  //string Data = "Ahmed";
            /// 
            ///  var Data = "Ahmed"; // Implicit Type 
            ///                      // Compiler Will Detect The Datatype Of Variable at Compilation Time
            ///                      // Base on Its Initial Value 
            /// 
            ///  //var X = null;  // Invalid 
            ///  // var  Can`t be Initialized With null 
            /// 
            /// 
            ///  Data = null;
            ///  //Data = 5;//Invalid 
            ///  // After Intialization , Yon Can't Chang Variable Datatype 
            /// 
            ///  //var X;// Invalid 
            ///  // var Must Be Intialize 
            /// Data = "May";

            // Var :    RunTime  الي بيبان اثناء ال  Dynamic   مش زي ال  Compilation Time بيكون اثناء ال  Error   بنستخدمها اكتر علشان لو في اي 


            #endregion

            #region Dynamic 
            /// dynamic Data = "Ali";
            /// // CLR Will Detect Datatypr Of Variable  At Runtime 
            /// // Based on Last Assigned Value 
            ///
            /// Data = 5;
            /// Data=true ;
            ///
            /// dynamic X; // Valid 
            /// // Can Declear Variable With Dynamic Without Intialization 
            ///
            /// dynamic Y = null; // Valid 
            /// // Can Be Intialized With null 
            ///
            ///
            /// Data = 6;
            /// // After Intialization , You Can Chang the  Datatype Of Variable 
            ///
            ///
            ///


            #endregion

            //Can't Use var In Parameter Or Return Type Or Attribute At Class
            // We Use It Only To Declear Local Variable 
            // for (var i = 0; i < 10; i++) { }
            //foreach (var x in Data) { }

            // Var Is Recommended 
            // Errors=> Compilation Time

            //var X = null; // Compilation Error 
            //  dynamic Y = null ;
            //  Console.WriteLine(Y); // RunTimeBinderExcepton 


            #endregion

            #region Extension Method 
            ///   int X = 12345;
            ///   int Y = intExtention.Reverse(X);
            ///   X.Reverse();
            ///   Console.WriteLine(Y);


            #endregion

            #region AnonymousType 

            ///    //Employee employee = new Employee() { Id=10 , Name=" Mona " , Salary= 1000 };     //  علشان استخدمه مره واحده بس   Class مش مستاهله اعمل  
            ///    //object employee = new { Id = 10, Name = " Ahmed  ", Salary = 5000 };             // كتيره  Object مكانه مش هيكون افضل حل لان مشاكل ال  Object  ولو قولنا هنستخدم ال 
            ///    //Console.WriteLine(employee.Salary); // Invalid 
            ///
            ///    //int X = 5;
            ///    //Console.WriteLine(X.GetType().Name  );
            ///
            ///    var Emp01 = new { Id = 10, Name = " Mona ", Salary = 1000 };
            ///    // Object that Will be Created From AnonymousType Is an Immutable Object [Can Not Be Changed  ] --> String  
            ///    // Console.WriteLine(Emp01.GetType().Name);     //  AnonymousType0`3   -->  ( ` =Tic 
            ///    //  Console.WriteLine(Emp01.Salary); // 1000
            ///    //Emp01.Salary = 5000; // Invalid
            ///
            ///    var Emp02 = new { Emp01.Id, Emp01.Name, Salary = 2000 };  // Till C# 9
            ///
            ///    var Emp03 = Emp01 with { Salary = 3000 };  // C# 10 Feature  .Net 6
            ///
            ///    Console.WriteLine($"Emp01 = {Emp01} ");
            ///    Console.WriteLine($"Emp02 = {Emp02} ");
            ///    Console.WriteLine($"Emp03 = {Emp03} ");
            ///
            ///    Console.WriteLine($"Emp01 = {Emp01.GetType().Name} "); // AnonymousType0`3
            ///    Console.WriteLine($"Emp02 = {Emp02.GetType().Name} "); // AnonymousType0`3
            ///    Console.WriteLine($"Emp03 = {Emp03.GetType().Name} "); // AnonymousType0`3
            ///
            ///    // The Same AnonymousType As Long As :
            ///    // 1.  Same Property Name [Case Sensitive]
            ///    // 2. Same Proprty Orderd 
            ///
            ///    var Emp04 = new { id = 70, Name = "Omar", Salary = 5000 };
            ///    Console.WriteLine($"Emp04 = {Emp04.GetType().Name}"); //AnonymousType1`3
            ///
            ///    var Emp05 = new { Name = "Omar", id = 70, Salary = 5000 };
            ///    Console.WriteLine($"Emp05 = {Emp05.GetType().Name}"); //AnonymousType2`3
            ///
            ///    var Emp06 = new { Id = 70, Name = "Salma " };
            ///    Console.WriteLine($"Emp06 = {Emp06.GetType().Name}"); //  AnonymousType3`2 


            #endregion

            #region What Is LINQ

            ///    // LINQ => Language Integrated Query 
            ///    // LINQ Has +40 Extension Methodes   -->  Method   بتاع كل   Overload     علشان هو حاسب ال   exactily  (40 Extension Methodes) هما مش   
            ///    // Extension Methods For All Collections That Implement Interface "IEnumerable"
            ///    // Named As LINQ Opertaors Existed At Class Enumrable 
            ///    // Categorized Into 13 Category 
            /// 
            /// 
            ///    List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// 
            ///     List<int> ODDNumbers= Numbers.Where(Num => Num % 2 == 1).ToList();
            /// 
            ///    foreach (int Num in ODDNumbers)
            ///    {
            ///        Console.WriteLine($"Numbers = {Num} ");
            ///    }
            /// 
            ///    // You Can Use "LINQ OPertators" Aganist The Data [ Stored In Sequence ]
            ///    // RegardLess  Data Stored [ SQL Server , Oracl , MySql  ] 
            /// 
            ///    // Sequance => The Object From Class That Immplement Built In Interface "IEnumerable" 
            ///   // 1. Local -> Static [ L2Object ]  ,XML File
            ///   // 2. Remote ->  L2EF (EntityFrameWork Core )
            /// 
            /// 







            #endregion

            #region LINQ Syntax [Fluant Syntax , Query Syntax ]


           //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Fluant Syntax
            ///   // 1. Fluant Syntax 
            ///   // 1.1 Call " LINQ Operators " As Static Method 
            ///     
            ///     //List<int> ODDNumbers =  Enumerable.Where(Numbers,X => X %2 == 1 ).ToList(); 
            ///     var  ODDNumbers =  Enumerable.Where(Numbers,X => X %2 == 1 );
            /// 
            ///   // 1.2 Call " LINQ Operators " As Extension Method [Recommended]
            /// 
            ///   ODDNumbers = Numbers.Where(X => X % 2 == 1 );   // Easy To Use And The Sentaic Sugar And Most Redability 
            /// 
            ///   foreach (int Num in ODDNumbers)
            ///   {
            ///       Console.Write($" {Num} "); // 1  3 5 7 9 
            ///   } 
            #endregion

            #region Query Syntax

            ///  //  Query Syntax -> Like Sql Server Style
            ///  // select *
            ///  //from Numbers  N 
            ///  // where N % 2 == 1 
            /// 
            ///  var ODDNumbers = from N in Numbers
            ///                   where N % 2 == 1
            ///                   select N;
            /// 
            ///  foreach (int Number in ODDNumbers)
            ///  {
            ///      Console.Write($" {Number} ");
            ///  }
            /// 
            ///  // Must Be Begin With Kyword " from "
            ///  //Must Be End With  Select OR GroupBy 









            #endregion





            #endregion

             #region LINQ Execution Ways 
            

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Deferred Execution [ Latest Version Of Data  ]

            ///  var ODDNumbers = Numbers.Where(X => X % 2 == 1);
            ///  Numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });
            /// 
            ///  // Where Is Execution  Deferred Execution 
            ///  // Deferred Execution :   Execute  مؤجل لما بحتاجه بيعمل  Execution  هنا مثلا او بمعني اصح هو  Add بيحصل  فالاخر بعد ما عملت   Execution  يعني ال 
            /// 
            ///  foreach (int Num in ODDNumbers)
            ///  {
            ///      Console.Write($" {Num} "); // 1 3 5 7 9 11 13 15
            ///  }


            #endregion

            #region Immediate Execution[  Element Operators , Casting Operators , Aggregate Operators  ] 


            ///   var ODDNumbers = Numbers.Where(X => X % 2 == 1).ToList(); // 1 3 5 7 9   // مره واحده يعني   Execution   ف الحال مستناش للاخر وعمل   Execution   دا اتعمله  Line  كدا ال 
         ///  Numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });
         ///  // Where Is Execution  Deferred Execution 
         ///   // Immediate Execution   الي شغالين  Categorys في 3 بس من ال 13 
         ///   //1. Element Operators 
         ///   //2. Casting Operators    -> To List() ;
         ///   //3. Aggregate Operators 
         /// 
         /// 
         ///  foreach (int Num in ODDNumbers)
         ///  {
         ///      Console.Write($" {Num} "); // 1 3 5 7 9 
         ///  }


            #endregion


            #endregion


        }
    }
}
