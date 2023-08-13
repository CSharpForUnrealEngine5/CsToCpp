namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug actor to visually test zone graph.</summary>
[CppInclude("NavCorridorTestingComponent.h")]
public partial class ANavCorridorTestingActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>DebugComp</summary>
	public UNavCorridorTestingComponent DebugComp;
}
