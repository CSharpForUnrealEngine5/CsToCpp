namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolClusterMagnet.h")]
public partial class UFractureClusterMagnetSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>How widely to search for neighboring bones to add to the new clusters: When Iterations is 1, only direct neighbors of the selected bones can be added to the new clusters; increasing Iterations allows additional layers of neighbors-of-neighbors to be added</summary>
	public uint Iterations;
}
