#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Static function with world field evaluation</summary>
[CppInclude("PhysicsField/PhysicsFieldComponent.h")]
public partial class UPhysicsFieldStatics : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Evaluate the world physics vector field from BP</summary>
	public static FVector EvalPhysicsVectorField(UObject WorldContextObject,FVector WorldPosition,EFieldVectorType VectorType) { return default; }
	///<summary>Evaluate the world physics scalar field from BP</summary>
	public static float EvalPhysicsScalarField(UObject WorldContextObject,FVector WorldPosition,EFieldScalarType ScalarType) { return default; }
	///<summary>Evaluate the world physics integer field from BP</summary>
	public static int EvalPhysicsIntegerField(UObject WorldContextObject,FVector WorldPosition,EFieldIntegerType IntegerType) { return default; }
}
