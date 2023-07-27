#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomBlueprintLibrary.h")]
public partial class UGroomBlueprintLibrary : UBlueprintFunctionLibrary {
// GroomBlueprintLibrary
	public static UGroomBindingAsset CreateNewGroomBindingAssetWithPath(string InDesiredPackagePath,UGroomAsset InGroomAsset,USkeletalMesh InSkeletalMesh,int InNumInterpolationPoints/*=100*/,USkeletalMesh InSourceSkeletalMeshForTransfer/*=nullptr*/,int InMatchingSection/*=0*/) { return default; }
	public static UGroomBindingAsset CreateNewGroomBindingAsset(UGroomAsset InGroomAsset,USkeletalMesh InSkeletalMesh,int InNumInterpolationPoints/*=100*/,USkeletalMesh InSourceSkeletalMeshForTransfer/*=nullptr*/,int InMatchingSection/*=0*/) { return default; }
	public static UGroomBindingAsset CreateNewGeometryCacheGroomBindingAssetWithPath(string DesiredPackagePath,UGroomAsset GroomAsset,UGeometryCache GeometryCache,int NumInterpolationPoints/*=100*/,UGeometryCache SourceGeometryCacheForTransfer/*=nullptr*/,int MatchingSection/*=0*/) { return default; }
	public static UGroomBindingAsset CreateNewGeometryCacheGroomBindingAsset(UGroomAsset GroomAsset,UGeometryCache GeometryCache,int NumInterpolationPoints/*=100*/,UGeometryCache SourceGeometryCacheForTransfer/*=nullptr*/,int MatchingSection/*=0*/) { return default; }
}
