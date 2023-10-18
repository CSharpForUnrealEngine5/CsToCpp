namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableSolverActor.h")]
public partial class ADeformableSolverActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>SolverComponent</summary>
	public UDeformableSolverComponent SolverComponent;
	///<summary>* Display icon in the editor</summary>
	public UBillboardComponent SpriteComponent;
}
