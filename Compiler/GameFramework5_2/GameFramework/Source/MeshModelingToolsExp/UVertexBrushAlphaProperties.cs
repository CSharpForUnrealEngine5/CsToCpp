namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool Properties for a brush alpha mask</summary>
[CppInclude("MeshVertexSculptTool.h")]
public partial class UVertexBrushAlphaProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Alpha mask applied to brush stamp. Red channel is used.</summary>
	public UTexture2D Alpha;
	///<summary>Alpha is rotated by this angle, inside the brush stamp frame (vertically aligned)</summary>
	public float RotationAngle;
	///<summary>If true, a random angle in +/- RandomRange is added to Rotation angle for each stamp</summary>
	public bool bRandomize;
	///<summary>Bounds of random generation (positive and negative) for randomized stamps</summary>
	public float RandomRange;
}
