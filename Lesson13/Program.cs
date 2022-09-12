class Student
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Surname { get; set; }
}

class Program
{
	static void DoSomething(Action<Student> action)
	{
		var student = new Student();

		action.Invoke(student);

		Console.WriteLine(student.Id);
		Console.WriteLine(student.Name);
		Console.WriteLine(student.Surname);
	}

	static void Main()
	{
		DoSomething(s =>
		{
			s.Id = 1;
			s.Name = "Nuran";
			s.Surname = "Huseynova";
		});
	}
}