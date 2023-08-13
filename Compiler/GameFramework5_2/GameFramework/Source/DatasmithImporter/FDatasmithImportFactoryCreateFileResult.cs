namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithBlueprintLibrary.h")]
public partial struct FDatasmithImportFactoryCreateFileResult {
	public TArray<AActor> ImportedActors;
	public TArray<UObject> ImportedMeshes;
	public bool bImportSucceed;
	public UDatasmithScene Scene;
}
