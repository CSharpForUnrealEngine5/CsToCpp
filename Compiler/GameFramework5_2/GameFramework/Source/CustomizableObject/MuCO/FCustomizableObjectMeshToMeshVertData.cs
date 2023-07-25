#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
///<summary>A USTRUCT version of FMeshToMeshVertData in SkeletalMeshTypes.h</summary>
public partial struct FCustomizableObjectMeshToMeshVertData {
// CustomizableObjectMeshToMeshVertData
	public float PositionBaryCoordsAndDist;
	public float NormalBaryCoordsAndDist;
	public float TangentBaryCoordsAndDist;
	public ushort SourceMeshVertIndices;
	public float Weight;
	public short SourceAssetIndex;
	public short SourceAssetLodIndex;
}
