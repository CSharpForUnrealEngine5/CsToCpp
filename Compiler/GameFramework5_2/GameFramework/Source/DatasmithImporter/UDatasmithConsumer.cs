#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithConsumer.h")]
public partial class UDatasmithConsumer : UDataprepContentConsumer {
	///<summary>DEPRECATED: Removing use of TSoftObjectPtr</summary>
	public TSoftObjectPtr<UDatasmithScene> DatasmithScene_DEPRECATED;
	///<summary>Stores the level used on the last call to UDatasmithConsumer::Run</summary>
	public string UniqueID;
	///<summary>GetDatasmithScene</summary>
	public  UDatasmithScene GetDatasmithScene() { return default; }
	///<summary>Path to UDatasmithScene potentially linked to</summary>
	public string DatasmithSceneObjectPath;
	///<summary>Path to ULevel potentially linked to</summary>
	public string OutputLevelObjectPath;
	///<summary>OutputLevelSoftObject_DEPRECATED</summary>
	public FSoftObjectPath OutputLevelSoftObject_DEPRECATED;
	///<summary>DatasmithSceneWeakPtr</summary>
	public TWeakObjectPtr<UDatasmithScene> DatasmithSceneWeakPtr;
}
