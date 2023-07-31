#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV Align Settings</summary>
[CppInclude("Operators/UVEditorUVTransformOp.h")]
public partial class UUVEditorUVAlignProperties : UUVEditorUVTransformPropertiesBase {
	///<summary>Controls what geometry the alignment is to be relative to when performed.</summary>
	public EUVEditorAlignAnchor AlignAnchor;
	///<summary>Manual anchor location for relative alignment</summary>
	public FVector2D ManualAnchor;
	///<summary>Controls what side of the island bounding boxes are being aligned</summary>
	public EUVEditorAlignDirection AlignDirection;
	///<summary>Controls how alignment considers grouping selected objects with respect to the alignment behavior.</summary>
	public EUVEditorAlignDistributeGroupingMode Grouping;
}
