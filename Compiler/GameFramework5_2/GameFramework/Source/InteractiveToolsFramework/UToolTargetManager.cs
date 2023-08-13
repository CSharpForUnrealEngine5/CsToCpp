namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The tool target manager converts input objects into tool targets- objects that</summary>
[CppInclude("ToolTargetManager.h")]
public partial class UToolTargetManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Factories</summary>
	public TArray<UToolTargetFactory> Factories;
}
