namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container that controls visibility based on Platform, Input</summary>
[CppInclude("CommonHardwareVisibilityBorder.h")]
public partial class UCommonHardwareVisibilityBorder : UCommonBorder {
	public static UClass StaticClass() {return default;}
	///<summary>VisibilityQuery</summary>
	public FGameplayTagQuery VisibilityQuery;
	///<summary>VisibleType</summary>
	public ESlateVisibility VisibleType;
	///<summary>HiddenType</summary>
	public ESlateVisibility HiddenType;
}
