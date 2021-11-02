using WhatFun = System.Console;

namespace FizzBuzzUpdate {
    class Program {
        static void Main(string[] args) { 
            for (int i = 1; i < 100; i++) {
                
                var output = "";
                
                if (i % 3 == 0) { output += "Fizz"; }
                if (i % 5 == 0) { output += "Buzz"; }
                
                if (output == "") { output += i; }
                WhatFun.WriteLine(output);

            }
        }
    }
}
