namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavigationDataChunk.h")]
public partial class UNavigationDataChunk : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of NavigationData actor that owns this chunk</summary>
	public string NavigationDataName;
}
