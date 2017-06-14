using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Gem : MonoBehaviour 
{
	public GameObject gemHolder;
	public GameObject sphere;
	string[] gemColors ={"Red","Blue","Green","Yellow","Orange"};
	public string color="";
	public List<Gem> Neighbors = new List<Gem>();
	public bool isSelected =false;
	public bool isMatched = false;
    public bool isStarted = false;
	public int XCoord
	{
		get
		{
			return Mathf.RoundToInt(transform.localPosition.x);
		}
	}
	public int YCoord
	{
		get
		{
			return Mathf.RoundToInt(transform.localPosition.y);
		}
	}

	// Use this for initialization
	void Start () 
	{
		CreateGem();
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	public void AwakeSelector()
	{
		isSelected =!isSelected;
        gemHolder.SetActive(isSelected);
    }
	public void CreateGem()
	{
        color = gemColors[Random.Range(0, gemColors.Length)];
        Material mat = Resources.Load("Materials/" + color) as Material;
        sphere.GetComponent<Renderer>().material = mat;
        isMatched = false;
    }
	public void AddNeighbor(Gem g)
	{
		if(!Neighbors.Contains(g))
			Neighbors.Add(g);
	}
	public bool IsNeighborWith(Gem g)
	{
		if(Neighbors.Contains(g))
		{
			return true;
		}
		return false;
	}
	public void RemoveNeighbor(Gem g)
	{
		Neighbors.Remove(g);
	}
	void OnMouseDown()
	{
        isStarted = true;
        if (GameObject.Find("Board(Clone)").GetComponent<Board>().CheckStateOfBoard())
           return;
        if (!GameObject.Find("Board(Clone)").GetComponent<Board>().isSwapping)
		{
			AwakeSelector();
			GameObject.Find("Board(Clone)").GetComponent<Board>().SwapGems(this);
		}
	}
}
