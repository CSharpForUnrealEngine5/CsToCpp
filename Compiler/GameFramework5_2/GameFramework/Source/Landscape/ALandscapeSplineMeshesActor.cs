#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is only intended to be used by UWorldPartitionLandscapeSplineMeshesBuilder which extracts and clones</summary>
[CppInclude("LandscapeSplineMeshesActor.h")]
public partial class ALandscapeSplineMeshesActor : APartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>StaticMeshComponents</summary>
	public TArray<UStaticMeshComponent> StaticMeshComponents;
	///<summary>GridGuid</summary>
	public FGuid GridGuid;
}
