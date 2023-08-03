#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Reorient root bone in the animation while maintaining mesh position and rotation</summary>
[CppInclude("ReOrientRootBoneModifier.h")]
public partial class UReOrientRootBoneModifier : UAnimationModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Rotation to apply to the root</summary>
	public FRotator Rotator;
}
