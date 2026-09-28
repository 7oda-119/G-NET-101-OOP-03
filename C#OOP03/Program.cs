namespace C_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            #region Question01
            //a)  What is the difference between Method Overloading and Method Overriding?
            /*
             * Method Overloading: Allows a class to declare sevsrel methods with the same name name but different parameters (count, type or order)
             *                     Resolved entirely at compile-time
             * Method Overriding: Lets a derived class supply its own implementation of a method that the base class already defined
             *                    Base method must be virsual, abstract or already an override
             *                    The derived method must use override keyword
             *                    The method segnature(name, return type and parameters) must be exactly
             *                    Resolved at run-time
             */

            //b)  What is the difference between Static Binding and Dynamic Binding?
            /*
             * Static Binding: Resolved at compile-time by the compiler so its faster
             *                 The reference type decides
             *                 Occurs with method overloading, method hiding, non-virsual methods and static methods
             * Dynamic Binding: Resolved at run-time by CLR so its slower
             *                  The actual object in memory decides 
             *                  Occurs with method overriding, abstract methods and interface methods
             */


            #endregion

            #endregion
        }
    }
}
