namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings UObject for UDrawCurveOnMeshSampleTool. This UClass inherits from UInteractiveToolPropertySet,</summary>
[CppInclude("SampleTools/DrawCurveOnMeshSampleTool.h")]
public partial class UDrawCurveOnMeshSampleToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Color</summary>
	public FLinearColor Color;
	///<summary>Thickness</summary>
	public float Thickness;
	///<summary>MinSpacing</summary>
	public float MinSpacing;
	///<summary>NormalOffset</summary>
	public float NormalOffset;
	///<summary>DepthBias</summary>
	public float DepthBias;
	///<summary>bScreenSpace</summary>
	public bool bScreenSpace;
}
