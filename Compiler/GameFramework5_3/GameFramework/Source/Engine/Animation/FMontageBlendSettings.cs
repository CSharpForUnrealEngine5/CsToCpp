namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Montage blend settings. Can be used to overwrite default Montage settings on Play/Stop</summary>
[CppInclude("Animation/AnimMontage.h")]
public partial struct FMontageBlendSettings {
	public UBlendProfile BlendProfile;
	public FAlphaBlendArgs Blend;
	public EMontageBlendMode BlendMode;
}
