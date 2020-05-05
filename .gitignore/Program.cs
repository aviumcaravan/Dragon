using System;

public class Program
{
	static void Main(string[] args)
	{
		//root method scope

		//part 1
		Player player = new Player(35, 60); //Player = new Player(float, float)
		Dragon dragon = new Dragon(70, 15); //Dragon = new Dragon(float, float)
		Console.WriteLine("distance between player and dragon: " + player.GetDistanceToTarget(player, dragon));
		Console.WriteLine("distance between dragon and player: " + dragon.GetDistanceToTarget(dragon, player));
		
		//part 2
		Player player1 = new Player(35, 60); //Player = new Player(float, float)
		Dragon dragon1 = new Dragon(70, 15); //Dragon = new Dragon(float, float)
		Dragon dragon2 = new Dragon(65, 20); //Dragon = new Dragon(float, float)
		Character[] characters = {
			dragon1, //characters[0]
			dragon2 //characters[1]
		}; //array of Character class type objects

		Console.WriteLine("distance to nearest target: " + player1.FindNearestTarget(player1, characters));

		Console.ReadKey(true);
	}
}