#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties</summary>
[CppInclude("BakeTransformTool.h")]
public partial class UBakeTransformToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Bake rotation</summary>
	public bool bBakeRotation;
	///<summary>Bake scale</summary>
	public EBakeScaleMethod BakeScale;
	///<summary>Recenter pivot after baking transform</summary>
	public bool bRecenterPivot;
	///<summary>This variable is used to enable/disable the &quot;DoNotBakeScale&quot; option in the BakeScale enum</summary>
	public bool bAllowNoScale;
}
