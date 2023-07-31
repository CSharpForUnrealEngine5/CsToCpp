#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for auto instanced and initialized subsystem that share the lifetime of UVCamComponents.</summary>
[CppInclude("VCamSubsystem.h")]
public partial class UVCamSubsystem : USubsystem {
	///<summary>GetVCamComponent</summary>
	public  UVCamComponent GetVCamComponent() { return default; }
}
