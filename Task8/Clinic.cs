using System.Security.Cryptography.X509Certificates;

class Clinic
{
    // Поля.
    private Pet[]? inside_rooms;
    private int index;

    // Конструктори.
    public Clinic(int idx)
    {
        if (idx % 2 == 0 || (idx < 1 || idx > 101))
            throw new ArgumentException("Invalid Operation!");
        else
        {
            inside_rooms = new Pet[idx];
            index = idx / 2;
        }
    }

    // Методи.
    public bool AddPet(Pet pet)
    {
        for (int i = 0; i < inside_rooms.Length; i++)
        {
            int idx = index;
            Change_pos();

            if (inside_rooms[idx] == null)
            {
                inside_rooms[idx] = pet;

                return true;
            }
        }
        return false;
    }

    public bool Release()
    {
        for (int i = 0; i < inside_rooms.Length; i++)
        {
            int idx = (inside_rooms.Length / 2 + i) % inside_rooms.Length;

            if (inside_rooms[idx] != null)
            {
                inside_rooms[idx] = null;
                return true;
            }
        }

        return false;
    }

    public void Print()
    {
        for (int i = 0; i < inside_rooms.Length; ++i)
            Print(i);
    }

    public void Print(int num)
    {
        if (inside_rooms[num] != null)
            Console.WriteLine(inside_rooms[num]);
        else
            Console.WriteLine("Room empty");
    }
    private void Change_pos()
    {
        int roomCount = inside_rooms.Length;

        if (index == roomCount - 1)
            index = roomCount / 2;
        else
        {
            if (index >= roomCount / 2)
                index = roomCount / 2 - index + roomCount / 2 - 1;
            else
                index = roomCount / 2 + roomCount / 2 - index;
        }
    }
    public bool HasEmptyRooms()
    {
        foreach(Pet p in inside_rooms)
            if (p == null)
                return true;

        return false;  
    }
}