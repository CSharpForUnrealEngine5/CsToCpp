#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshClipMorph.h")]
public partial class UCustomizableObjectNodeMeshClipMorph : UCustomizableObjectNodeModifierBase {
	public static UClass StaticClass() {return default;}
	///<summary>BoneName</summary>
	public string BoneName;
	///<summary>Tags</summary>
	public TArray<string> Tags;
	///<summary>ReferenceSkeletonIndex</summary>
	public uint ReferenceSkeletonIndex;
	///<summary>Offset from the origin of the selected bone to the actual start of the morph.</summary>
	public FVector StartOffset;
	///<summary>Toggles between a local or global start offset.</summary>
	public bool bLocalStartOffset;
	///<summary>The length from the morph start to the clip plane.</summary>
	public float B;
	///<summary>First radius of the ellipse that the mesh is morphed into.</summary>
	public float Radius;
	///<summary>Second radius of the ellipse that the mesh is morphed into.</summary>
	public float Radius2;
	///<summary>Ellipse Rotation in degrees around the bone axis.</summary>
	public float RotationAngle;
	///<summary>Controls the morph curve shape. A value of 1 is linear, less than 1 is concave and greater than 1 convex.</summary>
	public float Exponent;
	///<summary>Flag to invert the normal direction</summary>
	public bool bInvertNormal;
	///<summary>Origin</summary>
	public FVector Origin;
	///<summary>Normal</summary>
	public FVector Normal;
	///<summary>The maximum distance from the origin of the widget where vertices will be affected. If negative, there will be no limit.</summary>
	public float MaxEffectRadius;
}
