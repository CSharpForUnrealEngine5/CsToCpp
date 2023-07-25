#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsField/PhysicsFieldComponent.h")]
///<summary>Static function with world field evaluation</summary>
public partial class UPhysicsFieldStatics : UBlueprintFunctionLibrary {
// PhysicsFieldStatics
	public FVector EvalPhysicsVectorField(UObject WorldContextObject,FVector WorldPosition,EFieldVectorType VectorType) { return default; }
	public float EvalPhysicsScalarField(UObject WorldContextObject,FVector WorldPosition,EFieldScalarType ScalarType) { return default; }
	public int EvalPhysicsIntegerField(UObject WorldContextObject,FVector WorldPosition,EFieldIntegerType IntegerType) { return default; }
}
