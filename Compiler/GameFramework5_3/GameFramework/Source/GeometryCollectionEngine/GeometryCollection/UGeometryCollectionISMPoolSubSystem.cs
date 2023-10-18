namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem managing ISMPool actors.</summary>
[CppInclude("GeometryCollection/GeometryCollectionISMPoolSubSystem.h")]
public partial class UGeometryCollectionISMPoolSubSystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>For now we only use one ISMPool actor per world, but we could extend the system to manage many more and return the right one based on search criteria.</summary>
	public AGeometryCollectionISMPoolActor ISMPoolActor;
}
