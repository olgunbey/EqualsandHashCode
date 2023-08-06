// See https://aka.ms/new-console-template for more information




Student st1 = new Student() { ID = 1, Name = "Olgun" }; 
Student st2 = new Student() { ID = 1, Name = "Olgun" };
Student st3 = st1;
Student st4 = new Student() { ID = 2, Name = "Olgun" }; 

/*Console.WriteLine(st1.Equals(st2));*/ //true

Console.WriteLine(st1.GetHashCode());
Console.WriteLine(st3.GetHashCode());
Console.WriteLine(st2.GetHashCode());
Console.WriteLine(st4.GetHashCode());

HashSet<Student> HashsetList = new HashSet<Student>()
{
    st1,st2,st3,st4 //GetHasCode() return 0 olsa bile Equals'e de bakar bu yuzden bu st4 equals false döndügünden yeni bir nesne olarak algılanır count arttırır
};
Console.WriteLine(HashsetList.Count);







public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public override bool Equals(object? obj)
    {
        if(obj is not Student || obj is null)
        {
            return false;
        }
        Student objStuden= (obj as Student)!;
       return this.ID==objStuden.ID && this.Name==objStuden.Name?true:false;
    }
    public override int GetHashCode()
    {
        return 0;
        return (this.ID+this.Name).GetHashCode();
    }
}
