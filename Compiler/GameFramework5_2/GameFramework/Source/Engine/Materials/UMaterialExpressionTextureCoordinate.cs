#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureCoordinate.h")]
public partial class UMaterialExpressionTextureCoordinate : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Texture coordinate index</summary>
	public int CoordinateIndex;
	///<summary>Controls how much the texture tiles horizontally, by scaling the U component of the vertex UVs by the specified amount.</summary>
	public float UTiling;
	///<summary>Controls how much the texture tiles vertically, by scaling the V component of the vertex UVs by the specified amount.</summary>
	public float VTiling;
	///<summary>Would like to unmirror U or V</summary>
	public bool UnMirrorU;
	///<summary>UnMirrorV</summary>
	public bool UnMirrorV;
}
