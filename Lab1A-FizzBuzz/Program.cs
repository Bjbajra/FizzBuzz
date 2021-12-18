// See https://aka.ms/new-console-template for more information
using Lab1A_FizzBuzz;

List<string>? fizzBuzzSeqeunce = new FizzBuzzListGenerator().Run();
new FizzBuzzListConsoleWriter().WriteList(fizzBuzzSeqeunce);