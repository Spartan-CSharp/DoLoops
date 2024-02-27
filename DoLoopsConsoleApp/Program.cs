bool done = false;

do
{
	Console.Write("What is your first name (type 'exit' to quit): ");
	string? firstName = Console.ReadLine();

	if ( firstName?.ToLower() == "exit" )
	{
		done = true;
	}
	else if ( firstName?.ToLower() == "tim" )
	{
		Console.WriteLine($"Hi Professor {firstName}!");
	}
	else
	{
		Console.WriteLine($"Hi {firstName}!");
	}
} while ( !done );
