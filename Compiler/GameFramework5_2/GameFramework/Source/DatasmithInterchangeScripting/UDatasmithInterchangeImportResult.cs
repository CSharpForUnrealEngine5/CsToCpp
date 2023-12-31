namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithInterchangeScripting.h")]
public partial class UDatasmithInterchangeImportResult : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Dynamic delegate used to trigger an event in the Game when the import is completed</summary>
	public TArray<UObject> ImportedObjects;
	///<summary>Dynamic delegate used to trigger an event in the Game when the import is completed</summary>
	public FDatasmithInterchangeImportEnded OnImportEnded;
}
