#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for all Slots in UMG.</summary>
[CppInclude("Components/PanelSlot.h")]
public partial class UPanelSlot : UVisual {
	public static UClass StaticClass() {return default;}
	///<summary>Parent</summary>
	public UPanelWidget Parent;
	///<summary>Content</summary>
	public UWidget Content;
}
