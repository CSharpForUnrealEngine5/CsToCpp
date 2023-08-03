#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Associates a button style for widgets that want to display a button for a modifier / connection point.</summary>
[CppInclude("Styling/ButtonWidgetStyleData.h")]
public partial class UButtonWidgetStyleData : UWidgetStyleData {
	public static UClass StaticClass() {return default;}
	///<summary>ButtonStyle</summary>
	public FButtonStyle ButtonStyle;
}
