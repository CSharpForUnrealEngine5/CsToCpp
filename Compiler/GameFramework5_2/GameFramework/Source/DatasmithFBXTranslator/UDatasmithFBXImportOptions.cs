namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithFBXImportOptions.h")]
public partial class UDatasmithFBXImportOptions : UDatasmithOptionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Where to look for textures</summary>
	public TArray<FDirectoryPath> TextureDirs;
}
