#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation Composites serve as a way to combine multiple animations together and treat them as a single unit.</summary>
[CppInclude("Animation/AnimComposite.h")]
public partial class UAnimComposite : UAnimCompositeBase {
	public static UClass StaticClass() {return default;}
	///<summary>Serializable data that stores section/anim pairing *</summary>
	public FAnimTrack AnimationTrack;
	///<summary>Preview Base pose for additive BlendSpace *</summary>
	public UAnimSequence PreviewBasePose;
}
