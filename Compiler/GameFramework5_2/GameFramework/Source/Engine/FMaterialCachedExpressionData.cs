#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialCachedData.h")]
public partial struct FMaterialCachedExpressionData {
// MaterialCachedExpressionData
	public FMaterialCachedParameterEntry RuntimeEntries;
	public TArray<int> ScalarPrimitiveDataIndexValues;
	public TArray<int> VectorPrimitiveDataIndexValues;
	public TArray<float> ScalarValues;
	public TArray<bool> StaticSwitchValues;
	public TArray<bool> DynamicSwitchValues;
	public TArray<FLinearColor> VectorValues;
	public TArray<FVector4d> DoubleVectorValues;
	public TArray<TSoftObjectPtr<UTexture>> TextureValues;
	public TArray<TSoftObjectPtr<UFont>> FontValues;
	public TArray<int> FontPageValues;
	public TArray<TSoftObjectPtr<URuntimeVirtualTexture>> RuntimeVirtualTextureValues;
	public TArray<TSoftObjectPtr<USparseVolumeTexture>> SparseVolumeTextureValues;
	public TArray<UObject> ReferencedTextures;
	public TArray<FMaterialFunctionInfo> FunctionInfos;
	public TArray<FMaterialParameterCollectionInfo> ParameterCollectionInfos;
	public TArray<ULandscapeGrassType> GrassTypes;
	public FMaterialLayersFunctionsRuntimeData MaterialLayers;
	public TArray<string> DynamicParameterNames;
	public TArray<bool> QualityLevelsUsed;
	public bool bHasMaterialLayers;
	public bool bHasRuntimeVirtualTextureOutput;
	public bool bHasSceneColor;
	public bool bHasPerInstanceCustomData;
	public bool bHasPerInstanceRandom;
	public bool bHasVertexInterpolator;
	public uint PropertyConnectedBitmask;
}
