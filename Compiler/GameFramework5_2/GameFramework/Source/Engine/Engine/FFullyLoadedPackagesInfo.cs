#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Struct to help hold information about packages needing to be fully-loaded for DLC, etc.</summary>
public partial struct FFullyLoadedPackagesInfo {
// FullyLoadedPackagesInfo
	public EFullyLoadPackageType FullyLoadType;
	public string Tag;
	public TArray<string> PackagesToLoad;
	public TArray<UObject> LoadedObjects;
}
