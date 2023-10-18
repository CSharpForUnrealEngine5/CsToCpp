namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple actor that is spawned at the origin for AR systems that want to hang components on an actor</summary>
[CppInclude("AROriginActor.h")]
public partial class AAROriginActor : AActor {
	public static UClass StaticClass() {return default;}
}
