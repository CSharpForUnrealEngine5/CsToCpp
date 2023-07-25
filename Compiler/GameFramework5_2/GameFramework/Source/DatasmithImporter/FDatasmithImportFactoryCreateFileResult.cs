#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithBlueprintLibrary.h")]
public partial struct FDatasmithImportFactoryCreateFileResult {
// DatasmithImportFactoryCreateFileResult
	public TArray<AActor> ImportedActors;
	public TArray<UObject> ImportedMeshes;
	public bool bImportSucceed;
	public UDatasmithScene Scene;
}
