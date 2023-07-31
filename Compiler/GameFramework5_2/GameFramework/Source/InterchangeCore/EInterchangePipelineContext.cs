#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineBase.h")]
public enum EInterchangePipelineContext {
	None=0,
	AssetImport=1,
	AssetReimport=2,
	SceneImport=3,
	SceneReimport=4,
	AssetCustomLODImport=5,
	AssetCustomLODReimport=6,
	AssetAlternateSkinningImport=7,
	AssetAlternateSkinningReimport=8,
}
