#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundAssetSubsystem.h")]
///<summary>The subsystem in charge of the MetaSound asset registry</summary>
public partial class UMetaSoundAssetSubsystem : UEngineSubsystem {
// MetaSoundAssetSubsystem
	public  void RegisterAssetClassesInDirectories(TArray<FMetaSoundAssetDirectory> Directories) {}
	public  void UnregisterAssetClassesInDirectories(TArray<FMetaSoundAssetDirectory> Directories) {}
	public TArray<FMetaSoundAsyncAssetDependencies> LoadingDependencies;
}
