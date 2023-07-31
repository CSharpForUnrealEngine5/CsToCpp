#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A USTRUCT version of FMeshToMeshVertData in SkeletalMeshTypes.h</summary>
[CppInclude("MuCO/CustomizableObject.h")]
public partial struct FCustomizableObjectMeshToMeshVertData {
	public float PositionBaryCoordsAndDist;
	public float NormalBaryCoordsAndDist;
	public float TangentBaryCoordsAndDist;
	public ushort SourceMeshVertIndices;
	public float Weight;
	public short SourceAssetIndex;
	public short SourceAssetLodIndex;
}
