#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithInterchangeScripting.h")]
public partial class UDatasmithInterchangeImportResult : UObject {
	///<summary>Dynamic delegate used to trigger an event in the Game when the import is completed</summary>
	public TArray<UObject> ImportedObjects;
	///<summary>Dynamic delegate used to trigger an event in the Game when the import is completed</summary>
	public FDatasmithInterchangeImportEnded OnImportEnded;
}
