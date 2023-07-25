#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Operators/UVEditorUVTransformOp.h")]
///<summary>UV Distribute Settings</summary>
public partial class UUVEditorUVDistributeProperties : UUVEditorUVTransformPropertiesBase {
// UVEditorUVDistributeProperties
	public EUVEditorDistributeMode DistributeMode;
	public EUVEditorAlignDistributeGroupingMode Grouping;
	public bool bEnableManualDistances;
	public float ManualExtent;
	public float ManualSpacing;
}
