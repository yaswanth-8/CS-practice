﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace Training
{
    class pg {
        ~pg()
        {
            Console.WriteLine("invoked destructor");
        }
    }

    class Program
    {
        string Name;
        int id;
        string department;
        float grade;
        public Program(string myName,int myId,string myDepartment,float myGrade) {
           this.Name = myName;
            this.id = myId;
            this.department = myDepartment;
            this.grade = myGrade;
        }
        public void displayStudent()
        {
            Console.WriteLine("Details of the student are : " + Name+ " is the name ");
            Console.WriteLine(id + " is id " + department + " is dept " + grade + " is grade");
        }
       


        static void Main(string[] args)
        {

            Program myProgram = new Program("yaswanth",8,"automobile",8.8f);
            myProgram.displayStudent();
            Program myProgram1 = new Program("varun", 10, "cs", 9.2f);
            myProgram1.displayStudent();
            pg PG = new pg();
        }

        
    
    }
}
