namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for auto instanced and initialized subsystem that share the lifetime of UVCamComponents.</summary>
[CppInclude("VCamSubsystem.h")]
public partial class UVCamSubsystem : USubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>GetVCamComponent</summary>
	public UVCamComponent GetVCamComponent() { return default; }
}
