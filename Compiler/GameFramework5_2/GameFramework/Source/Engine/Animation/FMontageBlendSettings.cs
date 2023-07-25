#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
///<summary>Montage blend settings. Can be used to overwrite default Montage settings on Play/Stop</summary>
public partial struct FMontageBlendSettings {
// MontageBlendSettings
	public UBlendProfile BlendProfile;
	public FAlphaBlendArgs Blend;
	public EMontageBlendMode BlendMode;
}
