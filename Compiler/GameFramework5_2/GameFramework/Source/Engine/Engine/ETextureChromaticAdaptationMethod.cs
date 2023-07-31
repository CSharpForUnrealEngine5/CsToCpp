#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureDefines.h")]
///<summary>List of chromatic adaptation methods, matching the list in ColorManagementDefines.h.</summary>
public enum ETextureChromaticAdaptationMethod {
	TCAM_None=0,
	TCAM_Bradford=1,
	TCAM_CAT02=2,
}
