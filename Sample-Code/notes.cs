namespace hello-conditionals;

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(“Please enter your password:  ”);
			
			string thePassword  = Console.ReadLine();

			if (thePassword == “ABC123”)
			{
				Console.WriteLine(“Correct password, you are in!”);	
			} else{
				Console.WriteLine(“Correct password, you are not in!”);	
			}
		}
	}

// ===========================================================================

namespace hello-conditionals;

	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine(“Please enter a number:  ”);
			
			// Take a number from the user
			string inputFromUser = Console.ReadLine();
			
			// Transform string to number (parse)
			int theNumberVersion = int.Parse(inputFromUser);
			
			
			for(int i = 0; i<theNumberVersion; i++){
				
				Console.WriteLine(“Hello!”);
			} 
		}
	}
	
// ===========================================================================
namespace hello-conditionals;

	class Program
	{
		static void Main(string[] args)
		{
			int numberFromTheUser;
			
			
			do{
				Console.WriteLine(“Please enter a number (enter -1 to exit):  ”);
				
				// Take a number from the user
				string userInput = Console.ReadLine();
				
				// Transform string to number (parse)
				numberFromTheUser = int.Parse(userInput);
				
			}while(numberFromTheUser != -1);
			
		}
	}

// ============================================================================

namespace hello-conditionals;

	class Program
	{
		static void Main(string[] args)
		{
			int numberFromTheUser;
			string userInput;
			int sum = 0;
			
			do{
				Console.WriteLine(“Please enter a number (enter END to exit):  ”);
				
				// Take a number from the user
				userInput= Console.ReadLine();
				
				if(userInput != "END"){
					
					// Transform string to number (parse)
					numberFromTheUser = int.Parse(userInput);
					sum = sum + numberFromTheUser;
				}
				
			}while(userInput != "END");
			
			Console.WriteLine("The sum of the numbers are: " + sum);
			
		}
	}
	
// Functions ==================================================================
	namespace hello-functions;

	class Program
	{
		static void Main(string[] args)
		{
			//First Number
			Console.WriteLine("Enter a number: ");
			string firstInput = Console.ReadLine();
			 
			// Transform string to number (parse)
			int firstNumber = int.Parse(firstInput);
			
			Console.WriteLine("Enter a second number: ");
			string secondInput = Console.ReadLine();
			 
			// Transform string to number (parse)
			int secondNumber = int.Parse(secondInput);
			
			// Use or call the function
			int result = Add(firstNumber, secondNumber);
			Console.WriteLine("The result is: " + result)
			 
		}
		
		// Function to add two numbers
		public static int Add(int a, int b){
			return a + b;
		}
		
	}
	
// ========================================================================
	namespace hello-functions;

	class Program
	{
		static void Main(string[] args)
		{
			//Number
			Console.WriteLine("Enter a number: ");
			string firstInput = Console.ReadLine();
			 
			// Transform string to number (parse)
			int firstNumber = int.Parse(firstInput);
			
			bool result = IsPrime(firstNumber);
			
			if(result == true){
				Console.WriteLine("This number is prime!");
			}else{
				Console.WriteLine("This number is not prime!");
			}
			 
		}
		
		// Function to find out a number is prime
		public static bool IsPrime(int number){
			for(int i = 2; i < number; i++){
				if(number % i == 0)
					return false;
			}
			
			return true;
		}
	}
	
// Classes ====================================================================

namespace hello-classes;

	class Program
	{
		static void Main(string[] args)
		{
			// Create a new Person or initialize
			//Person me = new Person{FirstName = "Matthew", LastName ="Heino"};
			Person me = new Person{"Matthew", "Heino"};
			
			me.DisplayFullName();
			 
		}
		
	}
	
	// Class for a person -- keeps information about a person
	public class Person
	{
		// Attributes and fields
		public string FirstName{get; set;}
		public string LastName{get; set;}
		
		// Constructor
		public Person(string first, string last){
			FirstName = first;
			LastName = last;
		}
		
		// Function for the classes
		public void DisplayFullName(){
			Console.WriteLine(FirstName + " " + LastName);
		}
		
	}

// ==============================================================
// Building class ===============================================
namespace hello-classes;

	class Program
	{
		static void Main(string[] args)
		{
			string userInput;
			
			// Create a building
			Building myBuilding= new Building(5);
			
			// Display the building -----
			myBuilding.Display();
			
			do{
				Console.WriteLine("Type one of the commands: Add, Remove, or End");
				userInput = Console.ReadLine();
				
				if(userInput == "Add")
				{
					// Add a floor to the building
					myBuilding.AddOneFloor();
					
				}
				else if(userInput == "Remove")
				{
					// Remove a floor
					myBuilding.RemoveOneFloor();
				}
				
				// Display the building -----
				myBuilding.Display();
			}
			while(userInput != "End");
		}
	}
	
	// Class for a building-- keeps information about a person
	public class Building
	{
		int height;
		
		public Building(int initialHeight)
		{
			height = initialHeight;
		}
		
		// Display the building
		public void Display()
		{
			for(int i = 0; i < height; i++){
				Console.WriteLine("********");
			}
		
		}
		
		// Add
		public void AddOneFloor(){
			this.height = height + 1;
		}
		
		// Remove
		public void RemoveOneFloor(){
			this.height = height - 1;
		}
		
	}
	
// Lists and Dictionaries =================================================

namespace hello;

	class Program
	{
		static void Main(string[] args)
		{
			// Create a list of integers
			List<int> someNumbers = new List<int>();
			
			// Add numbers to the list
			someNumbers.Add(4);
			someNumbers.Add(5);
			someNumbers.Add(-1);
			
			
			Console.WriteLine("Before removal.");
			
			// Traverse the list 
			foreach(int number in someNumbers){
				Console.WriteLine(number);
				
			}
			
			for(int i =0; i < someNumbers.Count; i++){
				Console.WriteLine(someNumbers[i]);
				
			}
			
			// Remove an element
			someNumbers.Remove(5);
			
			Console.WriteLine("After removal.");
			
			// Traverse the list 
			foreach(int number in someNumbers){
				Console.WriteLine(number);
				
			}
			
		}
	}
	// ========================================================================
	// Arrays =================================================================
	
	namespace hello;

	class Program
	{
		static void Main(string[] args)
		{
			// Create an array of integers
			int[] myArray = new int[10];
			
			// To access elements in the array
			myArray[0] = 3;
			myArray[1] = 5;
			myArray[2] = 1;
			
			// Convert an array to a list 
			List<int> listVersion = myArray.ToList();
		}
	}
	
// ========================================================================
	namespace hello;

	class Program
	{
		static void Main(string[] args)
		{
			string userInput;
			
			// Create a list of integers
			List<int> numbersFromUser = new List<int>();
			
			do{
				Console.WriteLine("Enter a number (enter END to finish): ");
				userInput = Console.ReadLine();
				
				if(userInput != "END"){
					
					int numberVersionOfTheUserInput = int.Parse(userInput);
					
					// Add to the list
					numberFromTheUser.Add(numberVersionOfTheUserInput);	
					
				}
				
			}while(userInput != "END");	
			
			// Print the contents of the list
			foreach(int num in numbersFromUser){
				Console.WriteLine(num);
			}
			
			// Save the result of the sum
			int sum = SumOfNumbers(numbersFromUser);
			
			// Show the sum
			Console.WriteLine("Sum of these numbers: " + sum);
		}
		
		// Function to sum the list
		public static int SumOfNumbers(List<int> input){
			
			int result = 0;
			
			foreach(var num in input){
				result = result + num;
			}
			
			return result;
		}
	}
// ============================================================================
// Dictionary =================================================================

namespace hello;

	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> writtenVersionOfNumbers = new Dictionary<int, string>();
			
			//Add elements to the dictionary
			writtenVersionOfNumbers.Add(5, "five");
			writtenVersionOfNumbers.Add(6, "six");
			writtenVersionOfNumbers.Add(9, "nine");
			
			Console.WriteLine("Contents before.");
			
			// Display the dictionary contents to the user
			foreach(var item in writtenVersionOfNumbers){
				
				Console.WriteLine(item.Key + ": " + item.Value);
			}
			
			// Remove a pair from the dictionary
			writtenVersionOfNumbers.Remove(5);
			
			// Display the dictionary contents to the user
			foreach(var item in writtenVersionOfNumbers){
				
				Console.WriteLine(item.Key + ": " + item.Value);
			}
			
			Console.WriteLine("Contents after.");
		}
	}

// ============================================================================
namespace hello;

	class Program
	{
		static void Main(string[] args)
		{
			string result;
			
			result = ExpandAbbreviations("omg");
			
			Console.WriteLine(result);
		}
		
		// Function to return expanded abbrev
		public static string ExpandAbbreviations(string abbreviation){
			
			Dictionary<string, string> popular = new Dictionary<string, string>();
			
			// Add elements
			popular.Add("lol", "laugh out loud");
			popular.Add("brb", "be right back");
			popular.Add("omg", "oh my god");
			popular.Add("fyi", "for your information");
			
			// check to see if the abbbrev exists
			if(popular.Contains(abbreviation)){
				return  popular[abbreviation]
			}
			
			// if not in the dictionary
			return "NOT FOUND";
		}
	}
	
	// ========================================================================
	// Clear command ==========================================================
	namespace hello-classes;

	class Program
	{
		static void Main(string[] args)
		{
			string userInput;
			
			// Create a building
			Building myBuilding= new Building(5);
			
			// Display the building -----
			myBuilding.Display();
			
			do{
				Console.WriteLine("Type one of the commands: Add, Remove, or End");
				userInput = Console.ReadLine();
				
				if(userInput == "Add")
				{
					// Add a floor to the building
					myBuilding.AddOneFloor();
					
				}
				else if(userInput == "Remove")
				{
					// Remove a floor
					myBuilding.RemoveOneFloor();
				}
				
				// Display the building -----
				myBuilding.Display();
			}
			while(userInput != "End");
		}
	}
	
	// Class for a building-- keeps information about a person
	public class Building
	{
		int height;
		
		public Building(int initialHeight)
		{
			height = initialHeight;
		}
		
		// Display the building
		public void Display()
		{
			
			// Clear the display terminal -----
			Console.Clear();
			
			Console.WriteLine("----------"); 
			for(int i = 0; i < height; i++){
				if(i % 5 == 0){
					Console.WriteLine("----------"); 
					
				}else{
					Console.WriteLine("********");
				}
			}
			Console.WriteLine("----------"); 
		}
		
		// Add
		public void AddOneFloor(){
			this.height = height + 1;
		}
		
		// Remove
		public void RemoveOneFloor(){
			this.height = height - 1;
		}
	}
	
// ========================================================================
// String manipulation
namespace hello-string;

	class Program
	{
		static void Main(string[] args)
		{
			string example = "Hello";
			bool result = example.EndsWith("lo");
			
			Console.WriteLine(result);
		}	
	}

// =========================================================================	
namespace hello-string;

	class Program
	{
		static void Main(string[] args)
		{
			string example = "Hello";
			string result = example.Replace("llo","ck yea!");
			
			Console.WriteLine(result);
		}	
	}
	
// ============================================================================
namespace hello-string;

	class Program
	{
		static void Main(string[] args)
		{
			string example = "Hello World!";
			
			string[] result = example.Split("");
			
			foreach(string item in result){
				Console.WriteLine(item);
			}
		}	
	}
// ========================================================================
namespace hello-string;

	class Program
	{
		static void Main(string[] args)
		{
			string example = "Hello World!";
			string[] result = example.Split("");
			string finalResult = string.Join(",",result);

			Console.WriteLine(finalResult);
		}	
	}

//=============================================================================
namespace hello-string;

	class Program
	{
		static void Main(string[] args)
		{
			string example = "Hello World!";
			string result = example.Substring(4);

			Console.WriteLine(result);
		}	
	}
	
// ============================================================================
// File Input and Output ======================================================

namespace hello-files;

// need to have the following using statement
using System.IO;

	class Program
	{
		static void Main(string[] args)
		{
			// extract contents from the file
			string contentsFromFile = File.ReadAllText("hello.txt");
			
			// Display the contents of the file 
			Console.WriteLine(contentsFromFile);
			
			// Send content to a file
			File.WriteAllText("hello2.txt", "New content from the program");
			
		}	
	}
// ============================================================================
namespace hello;
using System.IO;

	class Program
	{
		static void Main(string[] args)
		{
			string userInput;
			
			// Create a list of integers
			List<int> numbersFromUser = new List<int>();
			
			do{
				Console.WriteLine("Enter a number (enter END to finish): ");
				userInput = Console.ReadLine();
				
				if(userInput != "END"){
					
					int numberVersionOfTheUserInput = int.Parse(userInput);
					
					// Add to the list
					numberFromTheUser.Add(numberVersionOfTheUserInput);	
					
				}
				
			}while(userInput != "END");	
			
			// Create a file 
			File.Create("numbers.txt");
			
			// Print the contents of the list
			foreach(var num in numbersFromUser){
				// Append to the file numbers.txt
				//File.AppendAllText("numbers.txt",num.ToString()+ " ");
				File.AppendAllText("numbers.txt",num+" ");
			}

		}
		
	}
// ==============================================================
// Read from a file

namespace hello;
using System.IO;

	class Program
	{
		static void Main(string[] args)
		{
			string contentsOfTheFile = File.ReadAllText("numbers.txt");
			
			// Display contents
			Console.WriteLine(contentsOfTheFile);
			
			// Split the contents of the string
			string[] result = contentsOfTheFile.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			
			int sum = 0;
			
			// Display the contents of the array
			foreach(string item in result){
				//Console.WriteLine(item);
				
				int numberVersion = int.Parse(item);
				
				// Sum the numbers in the array
				sum = sum + numberVersion;
			}
			
			Console.WriteLine(sum);
		}
	}
	
// Exceptions =============================================================
//
namespace hello;



	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number: ");
			string fromUser1 = Console.ReadLine();
			int numberFromUser1 = int.Parse(fromUser1);
			
			Console.WriteLine("Enter another number: ");
			string fromUser2 = Console.ReadLine();
			int numberFromUser2 = int.Parse(fromUser2);
			
			try{
				int result = numberFromUser1/numberFromUser2;
				Console.WriteLine("Result is:" + result)
			}
			catch(DivideByZeroException){
				Console.WriteLine("Can't divide by zero!");
			}
		}
	}
// 
namespace hello;
using System.IO;

	class Program
	{
		static void Main(string[] args)
		{
			string mySentence = "You are on top of the world!";
			string result = FirstWord(mySentence);
			
			Console.WriteLine(result);
		}
		
		public static string FirstWord(string sentence){
			
			if(sentence == ""){
				throw new ArgumentException("Empty Sentence!");
			}
			string[] splitted = sentence.Split(" ");
			return splitted[0];
		}
	}
	
//=============================================================================