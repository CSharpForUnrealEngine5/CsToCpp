namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV Distribute Settings</summary>
[CppInclude("Operators/UVEditorUVTransformOp.h")]
public partial class UUVEditorUVDistributeProperties : UUVEditorUVTransformPropertiesBase {
	public static UClass StaticClass() {return default;}
	///<summary>Controls the distribution behavior</summary>
	public EUVEditorDistributeMode DistributeMode;
	///<summary>Controls how distribution considers grouping selected objects with respect to the distribution behavior.</summary>
	public EUVEditorAlignDistributeGroupingMode Grouping;
	///<summary>If true, enable overriding distances used in the distribution behavior with manually entered values.</summary>
	public bool bEnableManualDistances;
	///<summary>For Edge and Center distribution modes, specify the desired overall distance within which to evenly place the edges or centers.</summary>
	public float ManualExtent;
	///<summary>For Spacing and Remove Overlap distribution modes, specify the desired distance between objects.</summary>
	public float ManualSpacing;
}
