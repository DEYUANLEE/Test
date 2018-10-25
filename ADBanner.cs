using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADBanner : MonoBehaviour {
	public enum Orientation{
		Portrait,
		Landscape
	}

	Orientation orientation;
	bool banner_Portrait_Loaded;
	bool banner_Landscape_Loaded;

	bool isBanner_Portrait_Show;
	bool isBanner_Landscape_Show;


	public bool IsBannerShow(){	
		return 	IsBannerShow (orientation);
	}


	public bool IsBannerShow(Orientation orientation){
		return orientation == Orientation.Portrait ? (isBanner_Portrait_Show && banner_Portrait_Loaded) : (banner_Landscape_Loaded && isBanner_Landscape_Show);
	}


	public void SetBannerV(bool b){
		isBanner_Portrait_Show = b;
		isBanner_Landscape_Show = b;

		bool loaded =orientation == Orientation.Portrait ? banner_Portrait_Loaded:banner_Landscape_Loaded;
		SetV (b&&loaded);
		 
	}

	public void SetCurrentBannerV(bool b){
		SetBannerV (b,orientation);
	}

	public void SetBannerV(bool b,Orientation orientation){
		bool loaded = false;
		if (orientation == Orientation.Portrait) {
			isBanner_Portrait_Show = b;
			loaded = banner_Portrait_Loaded;
		} else {
			isBanner_Landscape_Show = b;
			loaded = banner_Landscape_Loaded;
		}

		if (this.orientation == orientation) {
			SetV (b&&loaded);
		} 
	}



	void SetV(bool b){

	}

}
