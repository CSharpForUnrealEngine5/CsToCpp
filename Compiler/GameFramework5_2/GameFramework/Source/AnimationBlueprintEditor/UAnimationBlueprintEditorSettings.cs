#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Animation Blueprint Editor</summary>
[CppInclude("AnimationBlueprintEditorSettings.h")]
public partial class UAnimationBlueprintEditorSettings : UObject {
	///<summary>If true, automatically pose watch selected nodes.</summary>
	public bool bPoseWatchSelectedNodes;
	///<summary>Whether to display the corner text in an animation graph. Changing this only affects newly opened graphs.</summary>
	public bool bShowGraphCornerText;
}
