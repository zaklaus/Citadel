﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponButtonsManager : MonoBehaviour {
	[SerializeField] public GameObject[] wepButtons;
	[SerializeField] private GameObject[] wepCountsText;

	void Update() {
		for (int i=0; i<7; i++) {
			if (WeaponInventory.WepInventoryInstance.weaponInventoryIndices[i] > 0) {
				wepButtons[i].SetActive(true);
                wepButtons[i].GetComponent<WeaponButtonScript>().useableItemIndex = WeaponInventory.WepInventoryInstance.weaponInventoryIndices[i];
                wepCountsText[i].SetActive(true);
			} else {
				wepButtons[i].SetActive(false);
                wepButtons[i].GetComponent<WeaponButtonScript>().useableItemIndex = -1;
                wepCountsText[i].SetActive(false);
			}
		}
	}
}
