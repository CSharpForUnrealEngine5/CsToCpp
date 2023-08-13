namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborModel.h")]
public partial struct FClothPartData {
	public int PCACoeffNum;
	public uint PCACoeffStart;
	public uint NumVertices;
	public uint NumNeighbors;
	public TArray<uint> VertexMap;
	public TArray<float> PCABasis;
	public TArray<float> VertexMean;
	public TArray<float> NeighborCoeffs;
	public TArray<float> NeighborOffsets;
}
