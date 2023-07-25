#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HierarchicalLODVolume.h")]
///<summary>An invisible volume used to manually define/create an HLOD cluster.</summary>
public partial class AHierarchicalLODVolume : AVolume {
// HierarchicalLODVolume
	public bool bIncludeOverlappingActors;
	public TArray<int> ApplyOnlyToSpecificHLODLevels;
}
