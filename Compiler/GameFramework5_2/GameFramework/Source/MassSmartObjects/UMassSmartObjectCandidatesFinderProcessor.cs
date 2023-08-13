namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Processor that builds a list of candidates objects for each users.</summary>
[CppInclude("MassSmartObjectProcessor.h")]
public partial class UMassSmartObjectCandidatesFinderProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>Extents used to perform the spatial query in the octree for world location queries.</summary>
	public float SearchExtents;
}
