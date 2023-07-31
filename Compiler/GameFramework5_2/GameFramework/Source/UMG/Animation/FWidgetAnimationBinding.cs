#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single object bound to a UMG sequence.</summary>
[CppInclude("Animation/WidgetAnimationBinding.h")]
public partial struct FWidgetAnimationBinding {
	public string WidgetName;
	public string SlotWidgetName;
	public FGuid AnimationGuid;
	public bool bIsRootWidget;
}
