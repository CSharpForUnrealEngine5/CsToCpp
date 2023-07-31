#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of property paths used within a specific context (e.g. a class)</summary>
[CppInclude("PropertyAccess.h")]
public partial struct FPropertyAccessLibrary {
	public TArray<FPropertyAccessSegment> PathSegments;
	public TArray<FPropertyAccessPath> SrcPaths;
	public TArray<FPropertyAccessPath> DestPaths;
	public FPropertyAccessCopyBatch CopyBatches_DEPRECATED;
	public TArray<FPropertyAccessCopyBatch> CopyBatchArray;
}
