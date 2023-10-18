namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single object bound to a UMG sequence.</summary>
[CppInclude("Animation/WidgetAnimationBinding.h")]
public partial struct FWidgetAnimationBinding {
	public FName WidgetName;
	public FName SlotWidgetName;
	public FGuid AnimationGuid;
	public bool bIsRootWidget;
}
