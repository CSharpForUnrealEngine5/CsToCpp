#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Just a wrapper for the struct with real data in it.</summary>
[CppInclude("Styling/SlateWidgetStyleAsset.h")]
public partial class USlateWidgetStyleAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CustomStyle</summary>
	public USlateWidgetStyleContainerBase CustomStyle;
}
