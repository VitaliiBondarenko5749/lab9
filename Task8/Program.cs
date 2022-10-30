class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,Clinic> clinics = new Dictionary<string,Clinic>();
        Dictionary<string,Pet> pets = new Dictionary<string,Pet>();

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; ++i)
        {
            try
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "Create")
                {
                        if (input[1] == "Clinic")
                            clinics.Add(input[2], new Clinic(int.Parse(input[3])));
                        if (input[1] == "Pet")
                            pets.Add(input[2], new Pet(input[2], int.Parse(input[3]), input[4]));
                }
                if (input[0] == "Add")
                {
                    if (clinics[input[2]].HasEmptyRooms() == false)
                        Console.WriteLine(false);
                    else
                    {
                        Pet pet = pets[input[1]];
                        clinics[input[2]].AddPet(pet);
                    }
                }      
                if (input[0] == "Release")
                    Console.WriteLine(clinics[input[1]].Release());
                if (input[0] == "HasEmptyRooms")
                    Console.WriteLine(clinics[input[1]].HasEmptyRooms());
                if (input[0] == "Print")
                {
                    Clinic clinic = clinics[input[1]];
                    if (input.Length == 3)
                        clinic.Print(int.Parse(input[2]) - 1);
                    else if (input.Length == 2)
                        clinic.Print();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}