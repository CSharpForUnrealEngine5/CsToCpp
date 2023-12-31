namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SplineMeshActor is an actor with a SplineMeshComponent.</summary>
[CppInclude("Engine/SplineMeshActor.h")]
public partial class ASplineMeshActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>SplineMeshComponent</summary>
	public USplineMeshComponent SplineMeshComponent;
}
