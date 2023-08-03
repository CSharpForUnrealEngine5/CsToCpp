#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSpeedTree.h")]
public partial class UMaterialExpressionSpeedTree : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;WindType&#39; if not specified</summary>
	public FExpressionInput GeometryInput;
	///<summary>Defaults to &#39;GeometryType&#39; if not specified</summary>
	public FExpressionInput WindInput;
	///<summary>Defaults to &#39;LODType&#39; if not specified</summary>
	public FExpressionInput LODInput;
	///<summary>An extra bending of the tree for local effects</summary>
	public FExpressionInput ExtraBendWS;
	///<summary>The type of SpeedTree geometry on which this material will be used</summary>
	public ESpeedTreeGeometryType GeometryType;
	///<summary>The type of wind effect used on this tree. This can only go as high as it was in the SpeedTree Modeler, but you can set it to a lower option for lower quality wind and faster rendering.</summary>
	public ESpeedTreeWindType WindType;
	///<summary>The type of LOD to use</summary>
	public ESpeedTreeLODType LODType;
	///<summary>The threshold for triangles to be removed from the bilboard mesh when not facing the camera (0 = none pass, 1 = all pass).</summary>
	public float BillboardThreshold;
	///<summary>Support accurate velocities from wind. This will incur extra cost per vertex.</summary>
	public bool bAccurateWindVelocities;
}
