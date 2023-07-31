#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsurface Scattering profile asset, can be specified at the material. Only for &quot;Subsurface Profile&quot; materials, is use during Screenspace Subsurface Scattering</summary>
[CppInclude("Engine/SubsurfaceProfile.h")]
public partial class USubsurfaceProfile : UObject {
	///<summary>Settings</summary>
	public FSubsurfaceProfileStruct Settings;
}
