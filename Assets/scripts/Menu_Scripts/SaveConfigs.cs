using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace SlimUI.ModernMenu{
	public class SaveConfigs : MonoBehaviour
	{
		
		public TMP_Dropdown dropDown_temaMenu;
		
		
	    
	    void Start()
	    {
		    LoadConfigs();
	    }
	
	    
	    void Update()
	    {
	        
	    }
	    
		public void SaveConfig()
		{
			//dropdown de mudar o tema do menu
			int valorDrop = dropDown_temaMenu.value;
			PlayerPrefs.SetInt("valorDrop", valorDrop);
		}
		
		public void LoadConfigs()
		{
			//dropdown de mudar o tema do menu
			dropDown_temaMenu.value = PlayerPrefs.GetInt("valorDrop");
		}
	}
}
