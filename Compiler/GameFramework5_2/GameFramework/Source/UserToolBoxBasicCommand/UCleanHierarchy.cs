namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CleanHierarchy.h")]
public partial class UCleanHierarchy : UUTBBaseCommand {
	public static UClass StaticClass() {return default;}
	///<summary>DSMetadataToPreserve</summary>
	public TArray<string> DSMetadataToPreserve;
	///<summary>RemoveEmptyBranches</summary>
	public bool RemoveEmptyBranches;
	///<summary>RemoveIntermediaryActorsWithoutGeometry</summary>
	public bool RemoveIntermediaryActorsWithoutGeometry;
}
