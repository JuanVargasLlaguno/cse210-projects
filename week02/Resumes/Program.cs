using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //create an object from the "Job" class
        job1._jobTitle = "Software Engineer"; //enter data into the attributes
        job1._company = "Apple"; //enter data into the attributes
        job1._startYear = 2013; //enter data into the attributes
        job1._endYear = 2021; //enter data into the attributes

        Job job2 = new Job();
        job2._jobTitle = "Administrative";
        job2._company = "Google";
        job2._startYear = 2008;
        job2._endYear = 2012;



        job1.Display();
        job2.Display();
    }
    

}