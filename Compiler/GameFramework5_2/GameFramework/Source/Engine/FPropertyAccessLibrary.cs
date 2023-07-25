#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>A library of property paths used within a specific context (e.g. a class)</summary>
public partial struct FPropertyAccessLibrary {
// PropertyAccessLibrary
	public TArray<FPropertyAccessSegment> PathSegments;
	public TArray<FPropertyAccessPath> SrcPaths;
	public TArray<FPropertyAccessPath> DestPaths;
	public FPropertyAccessCopyBatch CopyBatches_DEPRECATED;
	public TArray<FPropertyAccessCopyBatch> CopyBatchArray;
}
