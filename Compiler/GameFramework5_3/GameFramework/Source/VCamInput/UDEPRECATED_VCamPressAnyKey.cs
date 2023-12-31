namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base widget class that allows you to wait for any input and then respond to the key pressed</summary>
[CppInclude("VCamAnyKeyWidget.h")]
public partial class UDEPRECATED_VCamPressAnyKey : UCommonActivatableWidget {
	public static UClass StaticClass() {return default;}
	///<summary>OnKeySelected</summary>
	public FOnKeySelected OnKeySelected;
	///<summary>OnKeySelectionCanceled</summary>
	public FOnKeySelectionCanceled OnKeySelectionCanceled;
}
