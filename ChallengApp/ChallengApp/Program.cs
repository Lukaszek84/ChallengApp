string personsName = "Lukasz Kostek" ;

int personsAge = 38 ;

bool men = true ;

string result1 = "Meżczyna, w wieku 38 lat.";
string result2 = "Chodzi o kogoś, innego";

if (personsName == "Lukasz Kostek" && personsAge == 38 && men != false)
{
    Console.WriteLine(result1);
}
else
{
    Console.WriteLine(result2);
}