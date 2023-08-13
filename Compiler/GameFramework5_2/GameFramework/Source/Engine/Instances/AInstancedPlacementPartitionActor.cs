namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class used by any editor placement of instanced objects, which holds any relevant runtime data for the placed instances.</summary>
[CppInclude("Instances/InstancedPlacementPartitionActor.h")]
public partial class AInstancedPlacementPartitionActor : AISMPartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>PlacementGridGuid</summary>
	public FGuid PlacementGridGuid;
}
