#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensComponent.h")]
///<summary>Controls whether this component can override the camera's filmback, and if so, which override to use</summary>
public enum EFilmbackOverrideSource {
	LensFile=0,
	CroppedFilmbackSetting=1,
	DoNotOverride=2,
}
