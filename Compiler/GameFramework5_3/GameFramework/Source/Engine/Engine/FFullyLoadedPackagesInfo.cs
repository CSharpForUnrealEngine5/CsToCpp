namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to help hold information about packages needing to be fully-loaded for DLC, etc.</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FFullyLoadedPackagesInfo {
	public EFullyLoadPackageType FullyLoadType;
	public string Tag;
	public TArray<FName> PackagesToLoad;
	public TArray<UObject> LoadedObjects;
}
