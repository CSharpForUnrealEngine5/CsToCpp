namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAsset.h")]
public partial struct FHairGroupInfo {
	public int GroupID;
	public FName GroupName;
	public int NumCurves;
	public int NumGuides;
	public int NumCurveVertices;
	public int NumGuideVertices;
	public float MaxCurveLength;
	public int GroupCardsID;
	public uint Flags;
	public TArray<FHairGroupLODInfo> LODInfos;
}
