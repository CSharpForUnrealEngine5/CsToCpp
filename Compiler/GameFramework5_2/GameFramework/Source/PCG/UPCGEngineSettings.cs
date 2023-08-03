#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGEngineSettings.h")]
public partial class UPCGEngineSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies the scale of the volume created on PCG graph drag/drop</summary>
	public FVector VolumeScale;
	///<summary>Whether we want to generate PCG graph/BP with PCG after drag/drop or not</summary>
	public bool bGenerateOnDrop;
}
