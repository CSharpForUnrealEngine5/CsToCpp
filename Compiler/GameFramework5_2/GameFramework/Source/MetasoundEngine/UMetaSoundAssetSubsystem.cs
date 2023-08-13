namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The subsystem in charge of the MetaSound asset registry</summary>
[CppInclude("MetasoundAssetSubsystem.h")]
public partial class UMetaSoundAssetSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>RegisterAssetClassesInDirectories</summary>
	public void RegisterAssetClassesInDirectories(TArray<FMetaSoundAssetDirectory> Directories) {}
	///<summary>UnregisterAssetClassesInDirectories</summary>
	public void UnregisterAssetClassesInDirectories(TArray<FMetaSoundAssetDirectory> Directories) {}
	///<summary>LoadingDependencies</summary>
	public TArray<FMetaSoundAsyncAssetDependencies> LoadingDependencies;
}
