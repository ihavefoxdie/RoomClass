namespace RoomClass
{
    static class Program
    {
        static void Main()
        {
            int[] origRoomDim = new int[] { 160, 80 };
            int[] roomDim = new int[] { 160, 80 };

            List<Furniture> furnitures = new()
            {
                new Furniture(1, "bed", 40, 32, "livingRoom", false),
                new Furniture(2, "table", 40, 40, "kitchen", false, 2)
            };

            furnitures[0].Move(-20, -16);
            furnitures[1].Move(-80, 80);
            //furnitures[0].Rotate(45);

            Console.WriteLine(furnitures[0].Vertices[0, 0] + " " + furnitures[0].Vertices[0, 1]);
            Console.WriteLine(furnitures[0].Vertices[1, 0] + " " + furnitures[0].Vertices[1, 1]);
            Console.WriteLine(furnitures[0].Vertices[2, 0] + " " + furnitures[0].Vertices[2, 1]);
            Console.WriteLine(furnitures[0].Vertices[3, 0] + " " + furnitures[0].Vertices[3, 1]);
            for (int i = 0; i < 1; i++)
                furnitures[0].Rotate(2);

            Console.WriteLine(furnitures[0].Rotation);
            int rotateFor = 360 - furnitures[0].Rotation;

            //furnitures[0].Rotate(rotateFor);

            Console.WriteLine(furnitures[0].Vertices[0, 0] + " " + furnitures[0].Vertices[0, 1]);
            Console.WriteLine(furnitures[0].Vertices[1, 0] + " " + furnitures[0].Vertices[1, 1]);
            Console.WriteLine(furnitures[0].Vertices[2, 0] + " " + furnitures[0].Vertices[2, 1]);
            Console.WriteLine(furnitures[0].Vertices[3, 0] + " " + furnitures[0].Vertices[3, 1]);

            List<Furniture> door = new()
            {
                new(-1, "door", 15, 5, "ROOM", false, 0)
            };
            door[0].Move(20, 0);

            Room newRoom = new(40, 40, door, furnitures, _ = false)
            {
                Rasterize = Rasterization.Line
            };
            //newRoom.Rasterize()


            newRoom.Rasterization();

            Rasterization.Print(newRoom.RoomArray);

            

            

            newRoom.FurnitureList[0].Rotate(31);

            Console.WriteLine(Room.Collision(newRoom.FurnitureList[0], newRoom.FurnitureList[1]));
            newRoom.PenaltyEvaluation();
            Console.WriteLine(newRoom.FurnitureList[0].IsOutOfBounds); Console.WriteLine(newRoom.FurnitureList[1].IsOutOfBounds);
            Console.WriteLine(newRoom.Penalty);
        }
    }
}
