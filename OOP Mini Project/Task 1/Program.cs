// Personalized Health Tracker System
using System;
class User
{
    private string ? name;
    private string ? email;
    private int birthYear;
    private int age;
    private List<Workout> sessions = new List<Workout>();
    public User (string name , string email,int birthYear)
    {
        this.name=name;
        this.email=email;
        this.birthYear=birthYear;
    }
    public string GetName() {
        return name ?? "";
    }
    public string GetEmail() {
        return email ?? "";
    }
    public int GetBirthYear() {
        return birthYear;
    }
    public void SetAge(int age)
    {
        if (age > 0) {
            this.age = age;
        }
    }
    public int GetAge() {
        return age;
    }
    public List<Workout> GetSessions() {
        return sessions;
    }
    public void AddSession(Workout session) {
    sessions.Add(session);
    }
}
class Workout
{
    private int sessionID;
    private string ? date;
    private List<Exercise> exercises = new List<Exercise>();
    public Workout(int sessionID,string date)
    {
        this.sessionID=sessionID;
        this.date=date;
    }
    public int GetSessionID() {
        return sessionID;
    }
    public string GetDate() {
        return date ??"";
    }
        public List<Exercise> GetExercises() {
        return exercises;
    }
}
class Exercise
{
    private string ? name;
    private int duration;
    private int calories;
    public Exercise(string name, int duration,int calories)
    {
        this.name=name;
        this.duration=duration;
        this.calories=calories;
    }
    public string GetName() {
        return name ??"";
    }
    public int GetDuration() {
        return duration;
    }
    public int GetCalories() {
        return calories;
    }
}
class UserCRUD
{
    public int CalculateAge(int birthYear)
    {
        int age = DateTime.Now.Year - birthYear;
        return age;
    }
    public void AddSession(User user, Workout session) {
        user.GetSessions().Add(session);
    }
    public void DisplayUser(User user)
    {
        Console.WriteLine("----- User Details -----");
        Console.WriteLine($"Name = {user.GetName()}");
        Console.WriteLine($"Age = {user.GetAge()}");
        foreach (Workout w in user.GetSessions())
        {
            Console.WriteLine($"Session ID = {w.GetSessionID()}");
            Console.WriteLine($"Date = {w.GetDate()}");
            foreach (Exercise e in w.GetExercises())
            {
                Console.WriteLine($"   Exercise Name =  {e.GetName()}");
                Console.WriteLine($"   Calories =  {e.GetCalories()}");
                Console.WriteLine($"   Duration =  {e.GetDuration()}");
            }
        }
    }
}
class Program
{
    static void Main()
    {
        User user = new User("Abubaker","muhmmadabubaker174@gmail.com",2007);
        UserCRUD O = new UserCRUD();
        int age = O.CalculateAge(user.GetBirthYear());
        user.SetAge(age);
        Exercise e1 = new Exercise("Push Ups",20,200);
        Exercise e2 = new Exercise("Bench press",15,150);
        Workout session = new Workout(1,"17-April-2026");
        session.GetExercises().Add(e1);
        session.GetExercises().Add(e2);
        user.AddSession(session);
        O.DisplayUser(user);
    }
}
