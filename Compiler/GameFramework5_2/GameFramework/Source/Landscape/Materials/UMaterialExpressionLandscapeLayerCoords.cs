namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLandscapeLayerCoords.h")]
public partial class UMaterialExpressionLandscapeLayerCoords : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Determines the mapping place to use on the terrain.</summary>
	public ETerrainCoordMappingType MappingType;
	///<summary>Determines the mapping place to use on the terrain.</summary>
	public ELandscapeCustomizedCoordType CustomUVType;
	///<summary>Uniform scale to apply to the mapping.</summary>
	public float MappingScale;
	///<summary>Rotation to apply to the mapping.</summary>
	public float MappingRotation;
	///<summary>Offset to apply to the mapping along U.</summary>
	public float MappingPanU;
	///<summary>Offset to apply to the mapping along V.</summary>
	public float MappingPanV;
}
