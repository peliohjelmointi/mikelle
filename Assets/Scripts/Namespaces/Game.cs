using UnityEngine;
using P;
using E;

//"global namespace" jos ei määritelty

public class Game : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        player.PrintHello();
        enemy.PrintHello();
        Enemy.PrintMoro(); //koska PrintMoro static 
        player.PrintHello();

        //string s = "HELLO";
        //print(s.Length);
    }
}
