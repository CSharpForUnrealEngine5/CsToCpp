namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockRootMotionSourceObject.h")]
public partial class UMockRootMotionSource_Montage : UMockRootMotionSource {
	public static UClass StaticClass() {return default;}
	///<summary>Montage</summary>
	public UAnimMontage Montage;
	///<summary>PlayRate</summary>
	public float PlayRate;
	///<summary>TranslationScale</summary>
	public FVector TranslationScale;
}
