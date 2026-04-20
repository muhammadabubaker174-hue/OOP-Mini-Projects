// Personalized Academic Record Analyzer
using System;
class StudentRecord{
    private string name;
    private int Roll_No;
    private double [] marks = new double [5];
    public StudentRecord(string name, int Roll_No,double m0,double m1,double m2,double m3, double m4){
                this.name=name;
                this.Roll_No=Roll_No;
                marks[0]=m0;
                marks[1]=m1;
                marks[2]=m2;
                marks[3]=m3;
                marks[4]=m4; 
    }
    public void SetMarks(int index, int mark )
    {
        if(index>=0 && index <= 4)
     {
            if (mark>=0 && mark <= 100)
            {
                marks[index]= mark;
            }
        } 
        else
        {
            Console.WriteLine("The collection for Marks does not Exits....... ");
        }
        for(int i=0 ; i<5 ; i++)
        {
            if (marks[i]<0)
            {
                marks[i]=0;
            }
            if (marks[i]>100)
            {
                marks[i]=100;
            }
        }      
    }
    public void GetName()
    {
         Console.WriteLine($" Student Name = {name}\n");
    }
    public void GetMarks()
    {
        foreach(double val in marks)
        {
            Console.Write($"Marks = {val}\n");
        }
    }
    public char CalculateGrade()
    {
        double sum=0;
        double average =0;
        foreach(double value in marks)
        {
                 sum += value; 
        }
        average=sum/5;
        if(average >= 85){
            return 'A' ;
        }
        else if (average>=70) { return 'B';
        }
        else if (average >= 50) {  return 'C';
        }
        else {  return 'F';
        }
    }
    public void AddBonusMarks()
    {
         Console.WriteLine("Enter Bonus Marks you want to Add : ");
        double bonus = Convert.ToDouble (Console.ReadLine());
        for(int i=0 ; i<5 ; i++){
             marks[i]+=bonus;
             if (marks[i]>100){
                marks[i]=100;
            }
        }
    }
}
class Program{
    static void Main()
    {
            StudentRecord S1 = new StudentRecord("Abubaker",269,92,81,74,82,86);
            S1.SetMarks(1,71);
            S1.AddBonusMarks();
            S1.GetName();
            S1.GetMarks();
            Console.WriteLine($"Grade = {S1.CalculateGrade()}");
    }
}
