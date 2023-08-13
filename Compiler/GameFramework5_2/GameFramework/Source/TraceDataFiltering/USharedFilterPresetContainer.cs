namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FilterPresets.h")]
public partial class USharedFilterPresetContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SharedPresets</summary>
	public TArray<FFilterData> SharedPresets;
}
