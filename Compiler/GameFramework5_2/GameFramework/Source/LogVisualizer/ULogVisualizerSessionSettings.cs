namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogVisualizerSessionSettings.h")]
public partial class ULogVisualizerSessionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to show trivial logs, i.e. the ones with only one entry.</summary>
	public bool bEnableGraphsVisualization;
}
