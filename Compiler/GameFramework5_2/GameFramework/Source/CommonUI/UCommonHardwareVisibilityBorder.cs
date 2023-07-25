#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonHardwareVisibilityBorder.h")]
///<summary>A container that controls visibility based on Platform, Input</summary>
public partial class UCommonHardwareVisibilityBorder : UCommonBorder {
// CommonHardwareVisibilityBorder
	public FGameplayTagQuery VisibilityQuery;
	public ESlateVisibility VisibleType;
	public ESlateVisibility HiddenType;
}
