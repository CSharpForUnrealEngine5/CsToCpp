namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AInternalToolFrameworkActor is a base class for internal Actors that the</summary>
[CppInclude("InteractiveToolObjects.h")]
public partial class AInternalToolFrameworkActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Controls whether this InternalToolFrameworkActor can be selected in the Editor.</summary>
	public bool bIsSelectableInEditor;
}
