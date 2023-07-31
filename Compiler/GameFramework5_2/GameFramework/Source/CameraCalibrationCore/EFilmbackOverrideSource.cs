#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensComponent.h")]
///<summary>Controls whether this component can override the camera&#39;s filmback, and if so, which override to use</summary>
public enum EFilmbackOverrideSource {
	LensFile=0,
	CroppedFilmbackSetting=1,
	DoNotOverride=2,
}
