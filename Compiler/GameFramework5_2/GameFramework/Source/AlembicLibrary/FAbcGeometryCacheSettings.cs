#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbcImportSettings.h")]
public partial struct FAbcGeometryCacheSettings {
// AbcGeometryCacheSettings
	public bool bFlattenTracks;
	public bool bStoreImportedVertexNumbers;
	public bool bApplyConstantTopologyOptimizations;
	public bool bCalculateMotionVectorsDuringImport_DEPRECATED;
	public EAbcGeometryCacheMotionVectorsImport MotionVectors;
	public bool bOptimizeIndexBuffers;
	public float CompressedPositionPrecision;
	public int CompressedTextureCoordinatesNumberOfBits;
}
