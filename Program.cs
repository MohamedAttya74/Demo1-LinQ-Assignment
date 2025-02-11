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
        }
    }
}
