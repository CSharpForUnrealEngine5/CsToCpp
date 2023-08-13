namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/FilterBarConfig.h")]
public partial class UFilterBarConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>FilterBars</summary>
	public TMap<string,FFilterBarSettings> FilterBars;
}
