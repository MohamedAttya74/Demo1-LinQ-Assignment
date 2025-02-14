using static Demo1_LinQ_Assignment.ListGenerator;
using System.Xml.Linq;
using System.Collections.Generic;

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

            #region Data Setup


            //  Console.WriteLine(ProductList[0]);
            //  Console.WriteLine();
            //  Console.WriteLine();
            //  Console.WriteLine();
            //  Console.WriteLine(CustomerList[0]); 

            #endregion

            #region Filtration [Restriction] Operators - Where 

            #region Get Product Out Of Stock 
            //    // Fluent Sentax
            //    var Result = ProductList.Where(P => P.UnitsInStock == 0);
            // 
            //    // Query Sentax 
            // 
            //    Result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P; 
            #endregion


            #region Ex02
            ///  // Fluent Sentax 
            ///  var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            ///  // Query Sentax 
            ///
            ///  Result = from P in ProductList
            ///           where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            ///           select P; 
            #endregion

            //    // Indexed Where 
            //    var Result = ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            //    // Search in First 10 Elements Only 
            //    // Indexed Where Valid Only Fluent Syntax , Can't Written Using Query Syntax 
            //
            //
            //
            //
            //    foreach (var Item in Result)
            //    {
            //        Console.WriteLine(Item);
            //    } 
            #endregion

            #region Transformation  [Projection] Operators [Select , Select Many] 

            #region Select Product Name 


            // Fiuent Sentax 
            // var Result = ProductList.Select(P => P.ProductName);

            // Query Sentax 
            // var Result = from P in ProductList
            //              select P.ProductName; 
            #endregion

            #region  Select Customer Name 



            #region Ex01
            //   //Fluent Syntax 
            //   var Result = CustomerList.Select(C => C.CustomerName);
            //   // Query Syntax
            //   Result = from C in CustomerList
            //            select C.CustomerName; 
            #endregion






            #endregion

            #region Customer Orders 


            ///  // Fluent Senatx 
            ///  var Result = CustomerList.SelectMany(C => C.Orders);  // واحده   Property   واحد لا هنا قصدي  Product   بنستخدمها لو عايز حاجه واحده ومش قصدي بحاجه واحده يعني  Select  بس مش هتنفع علشان ال  Select  هنا ال 
            ///                                              //   Array   هنا عباره عن  Orders  علشان ال   SelectMany انما استخدمنا هنا ال 
            ///  // Query Sentax 
            /// 
            ///  Result = from C in CustomerList
            ///           from O in C.Orders
            ///           select O;



            #endregion

            #region Select Product Id and Product Name 

            //   var Result = ProductList.Select(P => new { /*ProductID =*/ P.ProductID , ProductName = P.ProductName });
            //
            //   // Fluent Syntax 
            //   //  ProductID , ProductName  مثلا كل مره علشان اقدر اطلع ال  Class   علشان احنا مش هنحتاج نعمل كدا غير مره واحده ف مش هينفع نروح نعمل   Anonymous Type   هنا احنا استخدمنا ال 
            //   // CLR Will Creat Class In Runtime And Override Tostring 
            //
            //
            //   // Quer Syntax
            //
            //   Result = from P in ProductList
            //            select new
            //            {
            //
            //                /*ProductID =*/ P.ProductID,
            //                ProductName = P.ProductName
            //                              // خلي بالك ان لو غيرنا الترتيب هنا هيعترض ف لازم نحطها نفس ترتيب الي فوق علشان ميعترضش 
            //
            //
            //            }; 

            #endregion

            #region  Select Product In Stock And Apply Discount 10% On Its Price 

            // Fluent Syntax 
            //     var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                       .Select(P => new
            //                       {
            //                           ProductId = P.ProductID,
            //                           Name = P.ProductName,
            //                           OldPrice = P.UnitPrice,
            //                           NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //
            //                       });
            //
            //
            //     // Query Syntax 
            //
            //     Result = from P in ProductList
            //              where P.UnitsInStock > 0
            //              select new
            //              {
            //                  ProductId = P.ProductID,
            //                  Name = P.ProductName,
            //                  OldPrice = P.UnitPrice,
            //                  NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //              };



            #endregion


            ///     // Idexed Select  -->  Valid Only With Fluent Syntax 
            ///
            ///     var Result = ProductList.Where(P => P.UnitsInStock > 0)
            ///         .Select((P, I) => new
            ///     {
            ///         Index = I,
            ///         Name = P.ProductName,
            ///     });

            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]




            #region Get Products Ordered By Price Asc
            ///  // Fluent Syntax  
            ///  var Result = ProductList.OrderBy(P => P.UnitPrice); // Ascending Order 
            /// 
            ///  // Query Sentax 
            ///  Result = from P in ProductList
            ///           orderby P.UnitPrice
            ///           select P;     //  Ascending Order 
            #endregion

            #region Get Products Ordered By Price Desc
            //   // Fluent Syntax 
            //   var Result = ProductList.OrderByDescending(P => P.UnitPrice);   // Descending  Oreder 
            //   //Query Syntax 
            //   Result = from P in ProductList
            //            orderby P.UnitPrice descending   // Descending  Oreder 
            //            select P;


            #endregion

            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            // Fluent Syntax 
            //var Result = ProductList.OrderBy(P => P.UnitPrice).ThenBy(P => P.UnitsInStock);
            //var Result = ProductList.OrderBy(P => P.UnitPrice).ThenByDescending(P => P.UnitsInStock);
            //   var Result = ProductList.Where(P => P.UnitsInStock == 0).Reverse();

            #endregion

            #endregion

            #region Elements Operator - Immediate Execution [Valid Only With Fluent Syntax]
            #region Fluent Syntax  

            #region First , Last , LastOrDefault , FirstOrDefault
            //     //var Result = ProductList.First();  // Get First Element In Sequance
            //      //var  Result = ProductList.Last();      // Get Last Element In Sequance 
            //                                             //   Check  علشان كدا لازم اعمل  Product?  <-- Return   هنا بت  Result بس خلي بالك ان ال 
            //    //Console.WriteLine(Result);
            //    //  Console.WriteLine(Result?.ProductName ?? "Not Found ");
            // 
            //     List<Product> TestProduct =  new List<Product>();
            //     var Result = TestProduct.First();  // InvalidOperationException: Sequence contains no elements
            //     Result = TestProduct.Last();    // InvalidOperationException: Sequence contains no elements
            //     Console.WriteLine(Result);
            //     // First And Last May Be Throw Exception -> InvalidOperationException: Sequence contains no elements


            //  var Result = ProductList.FirstOrDefault();   // Get First Element In Sequance
            //  Result= ProductList.LastOrDefault();
            //  Console.WriteLine(Result);


            //   List<Product> TestProduct = new List<Product>();
            //       var Result = TestProduct.FirstOrDefault();   //  هنا  Exception   مش هيرمي 
            //           Result = TestProduct.LastOrDefault();
            // 
            //   Console.WriteLine(Result?.ProductName ?? "Not Found ");

            // FirstOrDefault ,LastOrDefault  => If Sequance Is Empty  -> Return  Null 
            Console.WriteLine("*****************");
            // Anther OverLoad 
            // var Result = ProductList.First(P => P.UnitsInStock == 0);  // Get First Element In Sequance Matcing the Condition 
            //  Result = ProductList.Last(P => P.UnitsInStock == 0);  // Get Last  Element In Sequance Matcing the Condition 

            //      List<Product> TestProduct = new List<Product>();
            //          var Result = TestProduct.First(P=>P.UnitsInStock==0);    //InvalidOperationException: Sequence contains no matching element
            //   Result = TestProduct.LastOrDefault(P => P.UnitsInStock == 0);  // InvalidOperationException: Sequence contains no matching element

            //   var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //   Result = ProductList.LastOrDefault(P => P.UnitsInStock == 0);

            // List<Product> TestProduct = new List<Product>();
            //     var Result = TestProduct.FirstOrDefault(P => P.UnitsInStock ==0);  //  Not Found 
            //         Result = TestProduct.LastOrDefault(P => P.UnitsInStock == 0);  //  Not Found 
            // If There Is No Matching Element  ->  Return Defult = Null


            //Console.WriteLine(Result?.ProductName ?? "Not Found ");


            #endregion

            #region Element At ,ElementAtOrDefault

            //     //  var Result = ProductList.ElementAt(0);     //  Element  بترجع ال  Index  بعطيها ال 
            //
            //     //  Result = ProductList.ElementAt(77);    // ArgumentOutOfRangeException: Index was out of range.
            //
            //     var Result = ProductList.ElementAtOrDefault(77);
            //
            //     // If Index Was out Of Rang => Return Defult  --> Null 
            //
            //     
            //     Console.WriteLine(Result?.ProductName ?? "Not Found ");



            #endregion

            #region Single  , SingleOrDefault


            //    //              برضو حتي لو فاضيه   Exception    وهيرمي  Sequance      واحد بس ف ال   Element    هتشتغل صح لما يكون عندي 
            //    //var Result = ProductList.Single(); // InvalidOperationException: Sequence contains more than one element
            //    //   var Result = ProductList.Single(P => P.ProductID == 1 );  // Chai
            //
            //    // If Sequance Contain  Only One Element   Match Condition  -> Return It 
            //    // Else Will Throw Exception ( Sequance Empty , Sequance Contain More than Element Match Condition   )
            //
            //
            //    //var  Result = ProductList.SingleOrDefault( P => P.UnitPrice >4); // InvalidOperationException: Sequence contains more than one matching element
            //    var Result = ProductList.SingleOrDefault(P => P.UnitPrice ==9999);  // Not Found
            //    // If Sequance Contain  No  Element   Match Condition  -> Return Null
            //    // If Sequance Contain  More Than   Element   Match Condition  -> Throw Exception
            //    //  If Sequance Contain  Just Only One Element   Match Condition  -> Return It
            //    Console.WriteLine(Result?.ProductName ?? "Not Found ");


            #endregion

            #endregion

            #region Hybrid Syntax

            // Hybrid Syntax = Fluent Synatx + Query Exprassion
            // Hybrid Syntax = (Query syntax ). Fluent Syntax  

            //    var Result = ( from P in ProductList
            //                 where P.UnitsInStock == 0
            //                 select new
            //                 {
            //                     P.ProductID,
            //                     P.ProductName,
            //                     P.UnitsInStock,
            //                     
            //                 }).FirstOrDefault();
            //
            //    Console.WriteLine(Result);
            //   foreach (var Product in Result)
            //   {
            //       Console.WriteLine(Product);
            //   }
            #endregion


            #endregion

            #region Aggregate Operators  - Immediate Execution

            #region Count 

            //Result = ProductList.Count;  // List Property 
            //  var Result = ProductList.Count(); // LINQ Operators 
            //  Result = ProductList.Count(P => P.UnitsInStock == 0);
            // 
            //  Console.WriteLine(Result);

            #endregion

            #region Max , Min



            //var Result = ProductList.Max();   // ArgumentException: At least one object must implement IComparable.
            //// Product Must Be Immplement Icombarable 
            //Console.WriteLine(Result);

            //var Result = ProductList.Max(P => P.ProductName.Length);  //    علشان انا عاطيه الحاجه الي يروح يقارن بيها  implement IComparable  ف الحاله دي مش محتاج اعمل 
            //var Result = ProductList.Min(P => P.ProductName.Length);    //    علشان انا عاطيه الحاجه الي يروح يقارن بيها  implement IComparable  ف الحاله دي مش محتاج اعمل 
            //Console.WriteLine(Result);


            //    var MinLength = ProductList.Min(P => P.ProductName.Length);
            //    //Console.WriteLine(MinLength);
            //    
            //    var Result = (from P in ProductList
            //                 where P.ProductName.Length == MinLength
            //                 select P).First();
            //    Console.WriteLine(Result);




            //  var Result = ProductList.Min();   // ArgumentException: At least one object must implement IComparable.
            //  // Product Must Be Immplement Icombarable 
            //  Console.WriteLine(Result);

            #endregion

            #region Sum , Average 

            //var Result = ProductList.Sum(P => P.UnitPrice);
            //Console.WriteLine(Result);

            //var Result = ProductList.Average(P => P.UnitPrice);
            //Console.WriteLine(Result);


            #endregion

            #region Aggregate 

        //    string[] Names = ["Aya" , "Omar" ,"Amr" , "Mohamed"];
        //      var Result = Names.Aggregate((Str01, Str02) => $"{Str01} {Str02}");
        //    Console.WriteLine(Result);    // Aya Omar Amr Mohamed



            #endregion
            #endregion







            #endregion


        }
    }
}
