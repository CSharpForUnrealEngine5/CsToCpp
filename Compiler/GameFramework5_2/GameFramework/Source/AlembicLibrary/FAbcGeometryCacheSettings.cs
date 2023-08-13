namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbcImportSettings.h")]
public partial struct FAbcGeometryCacheSettings {
	public bool bFlattenTracks;
	public bool bStoreImportedVertexNumbers;
	public bool bApplyConstantTopologyOptimizations;
	public bool bCalculateMotionVectorsDuringImport_DEPRECATED;
	public EAbcGeometryCacheMotionVectorsImport MotionVectors;
	public bool bOptimizeIndexBuffers;
	public float CompressedPositionPrecision;
	public int CompressedTextureCoordinatesNumberOfBits;
}
