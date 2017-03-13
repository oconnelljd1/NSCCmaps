using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour {

	public GameObject panel;
	public Sprite[] cafeteria;
	public Sprite[] davis;
	public Sprite[] sports;
	public Sprite[] forrester;
	public Sprite[] mccarthy;
	public Sprite[] misc;

	public int cafeInt;
	public int davisInt;
	public int sportsInt;
	public int forresterInt;
	public int mccarthyInt;
	public int miscInt;

	public GameObject mccarthyArrow;
	public GameObject forresterArrow;
	public GameObject wellnessArrow;
	public GameObject davisArrow;
	public GameObject soloanArrow;

	public Image currentImage;
	public Text text;
	public int current;

	void Awake () {
		current = 0;

		panel.SetActive (false);
		mccarthyArrow.SetActive (false);
		forresterArrow.SetActive (false);
		wellnessArrow.SetActive (false);
		davisArrow.SetActive (false);
		soloanArrow.SetActive (false);
	}

	public void Exit () {
		current = 0;

		panel.SetActive (false);
		mccarthyArrow.SetActive (false);
		forresterArrow.SetActive (false);
		wellnessArrow.SetActive (false);
		davisArrow.SetActive (false);
		soloanArrow.SetActive (false);
	}

	void Update () {
		if (current == 0) {
			
			panel.SetActive (false);

			mccarthyArrow.SetActive (false);
			forresterArrow.SetActive (false);
			wellnessArrow.SetActive (false);
			davisArrow.SetActive (false);
			soloanArrow.SetActive (false);


			currentImage.sprite = null;
			text.text = "Soloan Hall Dining";
		}

		if (current == 1) {
			panel.SetActive (true);
			currentImage.sprite = cafeteria [cafeInt];
			text.text = "Soloan Hall Dining";

			mccarthyArrow.SetActive (false);
			forresterArrow.SetActive (false);
			wellnessArrow.SetActive (false);
			davisArrow.SetActive (false);
			soloanArrow.SetActive (true);
		}

		if (current == 2) {
			panel.SetActive (true);
			currentImage.sprite = davis [davisInt];
			text.text = "Davis Hall Residence";

			mccarthyArrow.SetActive (false);
			forresterArrow.SetActive (false);
			wellnessArrow.SetActive (false);
			davisArrow.SetActive (true);
			soloanArrow.SetActive (false);
		}

		if (current == 3) {
			panel.SetActive (true);
			currentImage.sprite = forrester [forresterInt];
			text.text = "Forrester Building";

			mccarthyArrow.SetActive (false);
			forresterArrow.SetActive (true);
			wellnessArrow.SetActive (false);
			davisArrow.SetActive (false);
			soloanArrow.SetActive (false);
		}

		if (current == 4) {
			panel.SetActive (true);
			currentImage.sprite = mccarthy [mccarthyInt];
			text.text = "McCarthy Hall";

			mccarthyArrow.SetActive (true);
			forresterArrow.SetActive (false);
			wellnessArrow.SetActive (false);
			davisArrow.SetActive (false);
			soloanArrow.SetActive (false);
		}

		if (current == 5) {
			panel.SetActive (true);
			currentImage.sprite = sports [sportsInt];
			text.text = "Wellness Centre";

			mccarthyArrow.SetActive (false);
			forresterArrow.SetActive (false);
			wellnessArrow.SetActive (true);
			davisArrow.SetActive (false);
			soloanArrow.SetActive (false);
		}

		if (current == 6) {
			panel.SetActive (true);
			currentImage.sprite = misc [miscInt];
			text.text = "Misc Areas";

			mccarthyArrow.SetActive (false);
			forresterArrow.SetActive (false);
			wellnessArrow.SetActive (false);
			davisArrow.SetActive (false);
			soloanArrow.SetActive (false);
		}
	}

	public void ResetCurrent() {
		current = 0;
	}

	public void Set1 () {
		current = 1;
	}

	public void Set2 () {
		current = 2;
	}

	public void Set3 () {
		current = 3;
	}

	public void Set4 () {
		current = 4;
	}

	public void Set5 () {
		current = 5;
	}

	public void Set6 () {
		current = 6;
	}

	public void Next () {
		if (current == 1) {
			cafeInt++;
			if (cafeInt >= cafeteria.Length) {
				cafeInt = 0;
			}
		}

		if (current == 2) {
			davisInt++;
			if (davisInt >= davis.Length) {
				davisInt = 0;
			}
		}

		if (current == 3) {
			forresterInt++;
			if (forresterInt >= forrester.Length) {
				forresterInt = 0;
			}
		}

		if (current == 4) {
			mccarthyInt++;
			if (mccarthyInt >= mccarthy.Length) {
				mccarthyInt = 0;
			}
		}

		if (current == 5) {
			sportsInt++;
			if (sportsInt >= sports.Length) {
				sportsInt = 0;
			}
		}

		if (current == 6) {
			miscInt++;
			if (miscInt >= misc.Length) {
				miscInt = 0;
			}
		}
	}
}
