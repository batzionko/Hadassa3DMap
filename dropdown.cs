using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
    public Dropdown dropDownto;
    public Dropdown dropDownfrom;
    public Transform target;
    public Transform rigidbody;
    public Transform from;
    //public Text selectedName;


   // public Text selectName;
    public Dictionary<string, Vector3> map = new Dictionary<string, Vector3>();
    List<string> names = new List<string>();

    public void DropDownChange(int i)//string room
    {
        //var pair;
        //selectedName.text = names[i];
        target.position = map[names[i]];
    }

    public void DropDownfromChange(int i)//string room
    {
        //var pair;
       // selectedName.text = names[i];
        from.position = map[names[i]];
        target.position = map[names[i]];
        rigidbody.position = map[names[i]];
    }
    

    void Start()
    {
        PupulateList();
  
        
    }
    void PupulateList()
    {
        
        
    
        map.Add("2101", new  Vector3(9.91f, 15.89f, 63.69f));
        map.Add("2103", new Vector3(7.19f, 16.42f, 66.75f));
        map.Add("2104", new Vector3(8.43f, 15.71f, 59.13f));
       
        map.Add("2106", new Vector3(-4.37f, 19.19f, 63.15f));


        //map.Add("2107", new Vector3(-0.91f, 12.9f, 70.25f));




        names.Add("location");
        foreach (var pair in map)
        {
       
            names.Add(pair.Key);
         
        }
        
       
        dropDownfrom.AddOptions(names);
        
        names[0] = "destination";
        dropDownto.AddOptions(names);

    }


    }
