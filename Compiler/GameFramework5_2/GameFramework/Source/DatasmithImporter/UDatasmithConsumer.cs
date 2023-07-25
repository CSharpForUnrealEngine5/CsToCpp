#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithConsumer.h")]
public partial class UDatasmithConsumer : UDataprepContentConsumer {
// DatasmithConsumer
	public TSoftObjectPtr<UDatasmithScene> DatasmithScene_DEPRECATED;
	public string UniqueID;
	public UObject GetDatasmithScene() { return default; }
	public string DatasmithSceneObjectPath;
	public string OutputLevelObjectPath;
	public FSoftObjectPath OutputLevelSoftObject_DEPRECATED;
	public TWeakObjectPtr<UDatasmithScene> DatasmithSceneWeakPtr;
}
