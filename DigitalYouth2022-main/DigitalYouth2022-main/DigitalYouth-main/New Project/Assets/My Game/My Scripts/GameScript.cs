using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public EnemySpawner enemyspawner;
	public int enemiesToSpawn;
	public int waweToWin = 4;
	public int waweCount;



	// Use this for initialization
	protected void Start () {
		
	}

	public void Update ()
    {
		for (int i = 0; i < enemiesToSpawn; i++ )
        {
			//enemiesToSpawn.Spawn();
        }
    }
	
	
	
	
	
	
	
	// Update is called once per frame
	/*protected void Update ()
	{
		/*if (EnemiesSpawner.activate && enemySpawner.tranform.childCount == 0)
            if (waweCount == 0)

		{

        }
		if (waweCount<waweToWin )

        {
			waweCount++;
			HUD.Message("Welcome  Monkey");
			Spawnwawe();

        }*/









}