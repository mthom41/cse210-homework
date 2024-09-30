using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1  = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2004";
        job1._endYear = "2015";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Little Caesar's";
        job2._startYear = "2015";
        job2._endYear = "Present";

        Resume bill = new Resume();
        bill._name = "Billy G.";
        bill._jobs.Add(job1);
        bill._jobs.Add(job2);
        bill.Display();

    }
}