#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows multiple animations to be blended between based on input parameters</summary>
[CppInclude("Animation/BlendSpace1D.h")]
public partial class UBlendSpace1D : UBlendSpace {
	public static UClass StaticClass() {return default;}
	///<summary>bDisplayEditorVertically_DEPRECATED</summary>
	public bool bDisplayEditorVertically_DEPRECATED;
	///<summary>If you have input smoothing, whether to scale the animation speed. E.g. for locomotion animation,</summary>
	public bool bScaleAnimation;
}
