#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CleanHierarchy.h")]
public partial class UCleanHierarchy : UUTBBaseCommand {
	///<summary>DSMetadataToPreserve</summary>
	public TArray<string> DSMetadataToPreserve;
	///<summary>RemoveEmptyBranches</summary>
	public bool RemoveEmptyBranches;
	///<summary>RemoveIntermediaryActorsWithoutGeometry</summary>
	public bool RemoveIntermediaryActorsWithoutGeometry;
}
