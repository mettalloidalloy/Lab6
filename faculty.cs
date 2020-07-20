using System;
  
  class Faculty : Person
{
    public string Id{get; set;}
    public string Title{get; set;}
    public virtual DateTime DateOfEmployment{get; set;}
    public string Employer{get; set;}
    public bool Tenured{get; set;}

  public Faculty() : base()
  {
    Title = "Instructor";
  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Title = "Instructor";
  }  

  public void GrantTenure()
  {
   if (DateTime.Today.Year - 5 >= DateOfEmployment.Year)
   {
    Console.WriteLine("Member is tenured");
   }
  else
   {
    Console.WriteLine("Member not tenured");
   }
  }

  public void Promote()
  {
    if ((DateTime.Today.Year - 2 >= DateOfEmployment.Year)&&(DateTime.Today.Year - 5 < DateOfEmployment.Year))
    {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank");
    }
    else if ((DateTime.Today.Year - 5 >= DateOfEmployment.Year)&&(DateTime.Today.Year - 10 < DateOfEmployment.Year))
    {
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");
    }
    else if (DateTime.Today.Year - 10 >= DateOfEmployment.Year)
    {
      Title = " Professor";
      Console.WriteLine("Faculty promoted to Professor rank");
    }
    else 
    {
      Console.WriteLine("No more promotion possible");
    }
  }


  public override void Intro()
        {
        base.Intro();
        Console.WriteLine("I work as " + Title + " at " + Employer + " since " + DateOfEmployment);
        }
      
      
}