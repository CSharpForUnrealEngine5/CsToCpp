#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamAnyKeyWidget.h")]
///<summary>Base widget class that allows you to wait for any input and then respond to the key pressed</summary>
public partial class UDEPRECATED_VCamPressAnyKey : UCommonActivatableWidget {
// VCamPressAnyKey
	public FOnKeySelected OnKeySelected;
	public FOnKeySelectionCanceled OnKeySelectionCanceled;
}
