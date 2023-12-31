namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ControlPointMeshActor is an actor with a ControlPointMeshComponent.</summary>
[CppInclude("ControlPointMeshActor.h")]
public partial class AControlPointMeshActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ControlPointMeshComponent</summary>
	public UControlPointMeshComponent ControlPointMeshComponent;
}
