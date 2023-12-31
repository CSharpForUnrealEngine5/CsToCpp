namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGWorldActor.h")]
public partial class APCGWorldActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Size of the grid for PCG partition actors</summary>
	public uint PartitionGridSize;
	///<summary>Contains all the PCG data required to query the landscape complete. Serialized in cooked builds only</summary>
	public UPCGLandscapeCache LandscapeCacheObject;
	///<summary>Disable creation of Partition Actors on the Z axis. Can improve performances if 3D partitioning is not needed.</summary>
	public bool bUse2DGrid;
}
