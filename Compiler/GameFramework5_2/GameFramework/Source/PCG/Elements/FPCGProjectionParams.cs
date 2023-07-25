#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGProjectionParams.h")]
///<summary>Parameters that control projection behaviour.</summary>
public partial struct FPCGProjectionParams {
// PCGProjectionParams
	public bool bProjectPositions;
	public bool bProjectRotations;
	public bool bProjectScales;
	public bool bProjectColors;
	public string AttributeList;
	public EPCGMetadataFilterMode AttributeMode;
	public EPCGMetadataOp AttributeMergeOperation;
}
