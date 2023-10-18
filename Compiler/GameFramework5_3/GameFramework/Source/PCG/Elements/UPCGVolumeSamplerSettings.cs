namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGVolumeSampler.h")]
public partial class UPCGVolumeSamplerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>VoxelSize</summary>
	public FVector VoxelSize;
	///<summary>If no Bounding Shape input is provided, the actor bounds are used to limit the sample generation domain.</summary>
	public bool bUnbounded;
	///<summary>Each PCG point represents a discretized, volumetric region of world space. The points&#39; Steepness value [0.0 to</summary>
	public float PointSteepness;
}
