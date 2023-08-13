namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGVolumeSampler.h")]
public partial class UPCGVolumeSamplerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>VoxelSize</summary>
	public FVector VoxelSize;
	///<summary>If no Bounding Shape input is provided the actor bounds are used to limit the sample generation area.</summary>
	public bool bUnbounded;
}
