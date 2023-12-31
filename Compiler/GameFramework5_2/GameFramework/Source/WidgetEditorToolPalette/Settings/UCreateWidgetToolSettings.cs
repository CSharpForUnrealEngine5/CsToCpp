namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows for create widget tool layout to be defined via settings.</summary>
[CppInclude("Settings/CreateWidgetToolSettings.h")]
public partial class UCreateWidgetToolSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>List of tool stacks to create</summary>
	public TArray<FCreateWidgetStackInfo> CreateWidgetStacks;
}
