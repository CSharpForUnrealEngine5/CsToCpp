namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bone data for a vertex</summary>
[CppInclude("ClothVertBoneData.h")]
public partial struct FClothVertBoneData {
	public int NumInfluences;
	public ushort BoneIndices;
	public float BoneWeights;
}
