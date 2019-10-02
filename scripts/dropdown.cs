using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class dropdown : MonoBehaviour
{
    
    private List<Dropdown.OptionData> dropdownOptions;

    [SerializeField]
    public Dropdown dropDownfrom;
    //public Comb
   public Dropdown dropDownto;
    public Transform target;
    public new Transform rigidbody;
    public  Transform fromposition;
    //NavMeshAgent agent;
    //public Text selectedName;

    List<string> names = new List<string>();

    public Dictionary<string, Vector3> map = new Dictionary<string, Vector3>();
    
    public void DropDownChange(int i)//string room
    {
        // target.position = new Vector3 (map[names[i]].x, map[names[i].y, map[names[i]].z);
        target.position = map[names[i]];
    }
  
    public void DropDownfromChange(int i)//string room
    {

        Vector3 pos = new Vector3(map[names[i]].x, map[names[i]].y, map[names[i]].z);

        rigidbody.position =pos;

        //fromposition.position = new Vector3(pos.x+0.2f,pos.y,pos.z+0.2f);
        fromposition.position = pos;

    }

    void Start()
    {
        
        //inputField.enabled = false;
        PupulateList();
    }
   
    void PupulateList()
    {
        //dropDownfrom.captionText.text = "Select Your Destination";
        buildMap();
        //names.Add("enterance");
        foreach (var pair in map)
        {
            names.Add(pair.Key);
        }
 
        dropDownfrom.AddOptions(names);
        dropdownOptions = dropDownfrom.options;
  
        dropDownto.AddOptions(names);
    }
    void buildMap()
    {
        map.Add("Enterance", new Vector3(13.72f, 0.813f, 32.38f));
        map.Add("1110", new Vector3(17.915f, 0.813f, 17.078f));
        map.Add("1111", new Vector3(17.874f, 0.813f, 16.915f));
        map.Add("2101", new Vector3(18.38f, 5.287f, 31.083f));
        map.Add("2102", new Vector3(30.05f, 5.287f, 27.5f));
        map.Add("2103", new Vector3(29.27f, 5.287f, 26.46f));
        map.Add("2104", new Vector3(33.28f, 5.287f, 26.29f));
        map.Add("3101", new Vector3(26.49f, 9.69f, 28f));
        map.Add("3103", new Vector3(33.369f, 9.69f, 26.569f));
        map.Add("3104", new Vector3(26.42f, 9.69f, 27.641f));
        map.Add("3105", new Vector3(17.019f, 9.69f, 16.463f));
        map.Add("4100", new Vector3(20.08f, 14.17f, 30.35f));
        map.Add("4116", new Vector3(16.58f, 14.17f, 15.24f));
        map.Add("4117", new Vector3(16.56f, 13.626f, 15.34f));
    }
}
