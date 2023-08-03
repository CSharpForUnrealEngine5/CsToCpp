#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomBlueprintLibrary.h")]
public partial class UGroomBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new groom binding asset within the contents space of the project.</summary>
	public static UGroomBindingAsset CreateNewGroomBindingAssetWithPath(string InDesiredPackagePath,UGroomAsset InGroomAsset,USkeletalMesh InSkeletalMesh,int InNumInterpolationPoints/*=100*/,USkeletalMesh InSourceSkeletalMeshForTransfer/*=nullptr*/,int InMatchingSection/*=0*/) { return default; }
	///<summary>Create a new groom binding asset within the contents space of the project. The asset name will be auto generated based on the groom asset name and the skeletal asset name</summary>
	public static UGroomBindingAsset CreateNewGroomBindingAsset(UGroomAsset InGroomAsset,USkeletalMesh InSkeletalMesh,int InNumInterpolationPoints/*=100*/,USkeletalMesh InSourceSkeletalMeshForTransfer/*=nullptr*/,int InMatchingSection/*=0*/) { return default; }
	///<summary>Create a new groom binding asset within the contents space of the project.</summary>
	public static UGroomBindingAsset CreateNewGeometryCacheGroomBindingAssetWithPath(string DesiredPackagePath,UGroomAsset GroomAsset,UGeometryCache GeometryCache,int NumInterpolationPoints/*=100*/,UGeometryCache SourceGeometryCacheForTransfer/*=nullptr*/,int MatchingSection/*=0*/) { return default; }
	///<summary>Create a new groom binding asset within the contents space of the project. The asset name will be auto generated based on the groom asset name and the skeletal asset name</summary>
	public static UGroomBindingAsset CreateNewGeometryCacheGroomBindingAsset(UGroomAsset GroomAsset,UGeometryCache GeometryCache,int NumInterpolationPoints/*=100*/,UGeometryCache SourceGeometryCacheForTransfer/*=nullptr*/,int MatchingSection/*=0*/) { return default; }
}
