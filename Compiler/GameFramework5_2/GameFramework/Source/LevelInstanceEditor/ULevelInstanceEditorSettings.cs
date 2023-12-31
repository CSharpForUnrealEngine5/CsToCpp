namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstanceEditorSettings.h")]
public partial class ULevelInstanceEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of info for all known LevelInstance template maps</summary>
	public TArray<FTemplateMapInfo> TemplateMapInfos;
	///<summary>LevelInstanceClassName</summary>
	public string LevelInstanceClassName;
}
