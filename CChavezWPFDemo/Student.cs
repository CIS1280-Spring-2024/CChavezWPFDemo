﻿// Class: StudentClassDemo.Student.cs
// Programmer: Rob Garner (rgarner7@cnm.edu)
// Date: 20161003
// Purpose: Holds information for one student

using CChavezWPFDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    /// <summary>
    /// Stores information related to one student.
    /// </summary>
    class Student
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; private set; }

        //   instanitation method from live demo
        private List<Assignment> scores = new List<Assignment>();

        ////public List<int> Scores 
        ////{
        ////    get { return scores; }
        ////    set 
        ////    {
        ////        //Validate list of scores pased in as value
        ////        bool isValid = true;
        ////        foreach(int score in value)
        ////        {
        ////            isValid = isValid && score >= 0 && score <=100;
        ////        }
        ////        if (isValid) //it's valid, store it in the class
        ////        {
        ////            scores = value; 
        ////            CalcAverage(); 
        ////        }
        ////        else//it's not valid, throw an exception
        ////        {
        ////            throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
        ////        }
        ////    }
        ////}
        ///6.3.	Because we are now doing the validation for scores in the Assignment class we can simplify the Scores property in the student class:
        public List<Assignment> Scores
        {
            get { return scores; }
            set { scores = value; CalcAverage(); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Defaults StudentNumber to "Number Pending", names to "TBD" and Major to "Undeclared"
        /// </summary>
        public Student()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        /// <summary>
        /// Defaults names to "TBD" and Major to "Undeclared"
        /// </summary>
        /// <param name="sID">String representing students ID</param>
        public Student(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        /// <summary>
        /// Set all parameters except scores.
        /// </summary>
        /// <param name="sID">String representing students ID</param>
        /// <param name="firstName">Student's first name.</param>
        /// <param name="lastName">Student's last name.</param>
        /// <param name="maj">Student's major.</param>
        public Student(string sID, string firstName, string lastName, string maj)
        {
            StudentNumber = sID;
            FirstName = firstName;
            LastName = lastName;
            Major = maj;
            //  5.12.	Go into the class and add the following to our main constructor (the one all the other contstructors link to):
            //  scores = new List<int>();
        }

        /// <summary>
        /// Set all parameters including scores.
        /// </summary>
        /// <param name="sID">String representing students ID</param>
        /// <param name="firstName">Student's first name.</param>
        /// <param name="lastName">Student's last name.</param>
        /// <param name="maj">Student's major.</par
        /// <param name="score1">First score</param>
        /// <param name="score2">Second score</param>
        /// <param name="score3">Third score</param>
        /// <param name="maj"></param>
        public Student(string sID, string firstName, string lastName,
            string maj, List<Assignment> scores)
            : this(sID, firstName, lastName, maj)
        {
            this.scores = scores;
            CalcAverage();
        }
        #endregion

        #region Instance Methods
        /// <summary>
        /// Calculates score average
        /// </summary>
        ////public void CalcAverage()
        ////{
        ////    double sum = 0;
        ////    foreach (int score in scores)
        ////    {
        ////        sum += score;
        ////    }
        ////    Average = sum / scores.Count;

        ////}
        /// 6.5.	We also need to change the CalculateAverage method to:
        public void CalcAverage()
        {
            double sum = 0;
            foreach (Assignment assignment in scores)
            {
                sum += assignment.Score;
            }
            Average = sum / scores.Count;
        }

        /// <summary>
        /// Displays first name, last name, major and average.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return
                FirstName + " " + LastName
                + " Major: " + Major
                + " Average: " + Average.ToString("f2");
        }
        #endregion
    }
}
