namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters that control projection behaviour.</summary>
[CppInclude("Elements/PCGProjectionParams.h")]
public partial struct FPCGProjectionParams {
	public bool bProjectPositions;
	public bool bProjectRotations;
	public bool bProjectScales;
	public bool bProjectColors;
	public string AttributeList;
	public EPCGMetadataFilterMode AttributeMode;
	public EPCGMetadataOp AttributeMergeOperation;
}
