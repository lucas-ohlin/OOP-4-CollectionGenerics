using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP4 {

    internal class Program {

        public static List<Employee> userList = new List<Employee>();
        public static Stack workerStack = new Stack();

        static void Main(string[] args) {

            //Creating the users / stack
            UserStackCreation();

            //Saving the users from the stack to a list
            UserListCreation();

            //Print out the stack
            PrintStack();

            //Print out the stack using the pop method
            Console.WriteLine("--------&&&&&&--------");
            PrintStackPop();

            //Print out two items from the stack using the peek method
            Console.WriteLine("--------&&&&&&--------");
            PrintStackPeek();

            //Check if the inputed position of the stack is occupied and print it out
            Console.WriteLine("--------&&&&&&--------");
            CheckStackIndex(2);

            //Check if the inputed position of the list is occupied and 
            CheckList(1);

            //Find the 1st instance of the gender male and all instances of it and print them out
            CheckListGender();

        }

        private static void CheckListGender() {

            //Find the first instance of "Male" in the userList
            var userMale = userList.Find(x => x.gender.Equals("Male"));
            if (userMale != null) {

                Console.WriteLine($"\nFirst instance of Male:\n{userMale}");

            }

            //Find all instances of "Male" in userList and parse those into menList
            List<Employee> menList = userList.FindAll(x => x.gender.Equals("Male"));
            if (menList.Count != 0) {

                Console.WriteLine($"\nAll instances of Male:");
                for (int i = 0; i < menList.Count; i++) {

                    Console.WriteLine(menList[i]);

                }

            }

        }

        private static void CheckList(int index) {

            //Check if the userList contains userList[number]
            if (userList.Contains(userList[index])) {

                Console.WriteLine($"\nEmployee{index + 1} exists in the list.");
                Console.WriteLine(userList[index]);

            }

            if (!userList.Contains(userList[index])) {

                Console.WriteLine($"\nEmployee{index + 1} does not exist in the list.");

            }

        } 

        private static void CheckStackIndex(int index) {

            //Converts the stack to an array and check if the index position isn't null
            if (workerStack.ToArray()[index] != null) {

                Console.WriteLine($"Index number {index + 1} is in stack.");
                Console.WriteLine($"{workerStack.ToArray()[index]}");

            }

            if (workerStack.ToArray()[index] == null) {

                Console.WriteLine($"Index number {index + 1} is not in the stack.");

            }

        }

        private static void PrintStackPeek() {

            Console.WriteLine("Peek Method.");

            for (int i = 0; i < 2; i++) {

                //Returns the same object twice
                Console.WriteLine($"Items left in stack: {workerStack.Count}");
                Console.WriteLine(workerStack.Peek());

            }

        }

        private static void PrintStackPop() {

            Console.WriteLine("Pop Method.");

            while (workerStack.Count != 0) {

                Console.WriteLine($"Items left in stack: {workerStack.Count}");
                Console.WriteLine(workerStack.Pop());

            }

            //Recreats the stack
            UserStackCreation();

        }

        private static void PrintStack() {

            foreach (Employee worker in workerStack) {

                Console.WriteLine($"Items left in stack: {workerStack.Count}");
                Console.WriteLine(worker);

            }

        }

        private static void UserStackCreation() {

            //Creating the items using the Employee class's constructor
            var worker1 = new Employee(1, "Lucas", "Male", 1000);
            var worker2 = new Employee(2, "Olivia", "Woman", 1000);
            var worker3 = new Employee(3, "Gurra", "Male", 1000);
            var worker4 = new Employee(4, "Edvin", "Male", 1000);
            var worker5 = new Employee(5, "Sara", "Woman", 1000);

            //Push the items into the stack
            workerStack.Push(worker1);
            workerStack.Push(worker2);
            workerStack.Push(worker3);
            workerStack.Push(worker4);
            workerStack.Push(worker5);

        }

        private static void UserListCreation() {

            //Foreach worker in the stack, add it to the userList
            foreach (Employee worker in workerStack) {

                userList.Add(worker);

            }

        }

    }

    class Employee {

        public int id;
        public string name;
        public string gender;
        public decimal salary;

        public Employee(int id, string name, string gender, decimal salary) {

            this.id = id;
            this.name = name;
            this.gender = gender;
            this.salary = salary;

        }

        //Each object has a ToString built in to itself, so when the object is written we override the normal function and write
        //$"{id} | {name} - {gender} - {salary}" instead
        public override String ToString() {

            return $"{id} | {name} - {gender} - {salary}";

        }

    }

}
