namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompositeBase.h")]
public partial class UAnimCompositeBase : UAnimSequenceBase {
	public static UClass StaticClass() {return default;}
	///<summary>Frame-rate used to represent this Animation Montage (best fitting for placed Animation Sequences)</summary>
	public FFrameRate CommonTargetFrameRate;
}
