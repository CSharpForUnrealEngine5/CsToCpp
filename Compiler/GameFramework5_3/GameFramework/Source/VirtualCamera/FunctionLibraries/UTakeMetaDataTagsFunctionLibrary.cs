namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This library&#39;s purpose is to expose the names of the UTakeMetaData asset registry tag names.</summary>
[CppInclude("FunctionLibraries/TakeMetaDataTagsFunctionLibrary.h")]
public partial class UTakeMetaDataTagsFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>The asset registry tag that contains the slate for this meta-data</summary>
	public static FName GetTakeMetaDataTag_Slate() { return default; }
	///<summary>The asset registry tag that contains the take number for this meta-data</summary>
	public static FName GetTakeMetaDataTag_TakeNumber() { return default; }
	///<summary>The asset registry tag that contains the timestamp for this meta-data</summary>
	public static FName GetTakeMetaDataTag_Timestamp() { return default; }
	///<summary>The asset registry tag that contains the timecode in for this meta-data</summary>
	public static FName GetTakeMetaDataTag_TimecodeIn() { return default; }
	///<summary>The asset registry tag that contains the timecode out for this meta-data</summary>
	public static FName GetTakeMetaDataTag_TimecodeOut() { return default; }
	///<summary>The asset registry tag that contains the user-description for this meta-data</summary>
	public static FName GetTakeMetaDataTag_Description() { return default; }
	///<summary>The asset registry tag that contains the level-path for this meta-data</summary>
	public static FName GetTakeMetaDataTag_LevelPath() { return default; }
	///<summary>Gets all tags for TakeMetaData</summary>
	public static TSet<FName> GetAllTakeMetaDataTags() { return default; }
}
