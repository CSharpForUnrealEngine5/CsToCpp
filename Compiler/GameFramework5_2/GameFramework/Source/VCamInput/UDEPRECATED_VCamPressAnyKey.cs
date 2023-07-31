#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base widget class that allows you to wait for any input and then respond to the key pressed</summary>
[CppInclude("VCamAnyKeyWidget.h")]
public partial class UDEPRECATED_VCamPressAnyKey : UCommonActivatableWidget {
	///<summary>OnKeySelected</summary>
	public FOnKeySelected OnKeySelected;
	///<summary>OnKeySelectionCanceled</summary>
	public FOnKeySelectionCanceled OnKeySelectionCanceled;
}
