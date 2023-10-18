namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor that renders a simulated cable</summary>
[CppInclude("CableActor.h")]
public partial class ACableActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Cable component that performs simulation and rendering</summary>
	public UCableComponent CableComponent;
}
