#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimComposite.h")]
///<summary>Animation Composites serve as a way to combine multiple animations together and treat them as a single unit.</summary>
public partial class UAnimComposite : UAnimCompositeBase {
// AnimComposite
	public FAnimTrack AnimationTrack;
	public UAnimSequence PreviewBasePose;
}
