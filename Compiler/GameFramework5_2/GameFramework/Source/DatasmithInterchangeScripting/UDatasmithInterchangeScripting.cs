namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithInterchangeScripting.h")]
public partial class UDatasmithInterchangeScripting : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Utility method to load a specific file into the current level</summary>
	public static UDatasmithInterchangeImportResult LoadFile(string FilePath,FDatasmithInterchangeImportContext Context) { return default; }
	///<summary>Fetch the typed options associated with this file</summary>
	public void GetDatasmithOptionsForFile(string FilePath,TArray<UObject> Options) {}
	///<summary>Utility method to get list of supported extensions and string to pass to IDesktopPlatform::OpenFileDialog</summary>
	public static void GetDatasmithFormats(string Extensions,string FileTypes) {}
}
