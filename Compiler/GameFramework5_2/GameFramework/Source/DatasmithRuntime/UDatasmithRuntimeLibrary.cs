#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithRuntimeBlueprintLibrary.h")]
public partial class UDatasmithRuntimeLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Load a file using the Datasmith translator associated with it</summary>
	public static bool LoadFile(ADatasmithRuntimeActor DatasmithRuntimeActor,string FilePath) { return default; }
	///<summary>ResetActor</summary>
	public static void ResetActor(ADatasmithRuntimeActor DatasmithRuntimeActor) {}
	///<summary>Returns an interface to the DirectLink end point</summary>
	public static UDirectLinkProxy GetDirectLinkProxy() { return default; }
	///<summary>Open a file browser to select a file and call LoadFile with the selected file</summary>
	public static bool LoadFileFromExplorer(ADatasmithRuntimeActor DatasmithRuntimeActor,string DefaultPath) { return default; }
}
