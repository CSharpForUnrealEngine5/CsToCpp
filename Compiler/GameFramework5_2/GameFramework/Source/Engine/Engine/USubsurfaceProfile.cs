#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SubsurfaceProfile.h")]
///<summary>Subsurface Scattering profile asset, can be specified at the material. Only for "Subsurface Profile" materials, is use during Screenspace Subsurface Scattering</summary>
public partial class USubsurfaceProfile : UObject {
// SubsurfaceProfile
	public FSubsurfaceProfileStruct Settings;
}
