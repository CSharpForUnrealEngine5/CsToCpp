#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rendering settings.</summary>
[CppInclude("OpenColorIOSettings.h")]
public partial class UOpenColorIOSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to enable OCIO V1&#39;s legacy gpu processor.</summary>
	public bool bUseLegacyProcessor;
	///<summary>Whether to create lookup table texture resources in 32-bit float format (higher performance requirements).</summary>
	public bool bUse32fLUT;
	///<summary>Whether inverse view transforms are cached and supported. Disabled by default, to minimize the number of transform combinations.</summary>
	public bool bSupportInverseViewTransforms;
}
