using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Testing Person");
    Person p1 = new Person();
    p1.FirstName = "John";
    p1.LastName = "Smith";
    p1.PermanentAddress.AddressLine1 = "1234 Main St";
    p1.PermanentAddress.AddressLine2 = "Off of Side St";
    p1.PermanentAddress.City = "Cleveland";
    p1.PermanentAddress.State = "OH";
    p1.PermanentAddress.Zipcode = "44143";
    p1.DateOfBirth = Convert.ToDateTime("07/13/1994");
    p1.Intro();
    p1.IsBirthday();

    Console.WriteLine("Testing Faculty");
    Faculty f1 = new Faculty();
    f1.FirstName = "Jack";
    f1.LastName = "Lantern";
    f1.PermanentAddress.AddressLine1 = "6660 Spooky Blvd";
    f1.PermanentAddress.AddressLine2 = "Next to Town Square";
    f1.PermanentAddress.City = "Ghostown";
    f1.PermanentAddress.State = "OH";
    f1.PermanentAddress.Zipcode = "00000";
    f1.DateOfBirth = Convert.ToDateTime("10/31/1900");
    f1.Id = "1010";
    f1.Title = "Instructor";
    f1.DateOfEmployment = Convert.ToDateTime("06/06/12");
    f1.Employer = "Tri-C";
    f1.Intro();
    f1.IsBirthday();
    f1.GrantTenure();
    f1.Promote();
   
  
    
  }
}