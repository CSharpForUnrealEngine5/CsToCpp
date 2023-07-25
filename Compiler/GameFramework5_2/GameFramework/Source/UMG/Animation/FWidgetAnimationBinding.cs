#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/WidgetAnimationBinding.h")]
///<summary>A single object bound to a UMG sequence.</summary>
public partial struct FWidgetAnimationBinding {
// WidgetAnimationBinding
	public string WidgetName;
	public string SlotWidgetName;
	public FGuid AnimationGuid;
	public bool bIsRootWidget;
}
