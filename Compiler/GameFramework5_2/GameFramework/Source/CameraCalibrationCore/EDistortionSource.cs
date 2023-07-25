#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensComponent.h")]
///<summary>Specifies from where the distortion state information comes</summary>
public enum EDistortionSource {
	LensFile=0,
	LiveLinkLensSubject=1,
	Manual=2,
}
