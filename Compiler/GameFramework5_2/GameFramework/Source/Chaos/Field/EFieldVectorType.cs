#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemTypes.h")]
///<summary>TODO : Refactor these 3 enums to be in sync with the GetFieldTargetTypes</summary>
public enum EFieldVectorType {
	Vector_LinearForce=0,
	Vector_LinearVelocity=1,
	Vector_AngularVelocity=2,
	Vector_AngularTorque=3,
	Vector_PositionTarget=4,
	Vector_InitialLinearVelocity=5,
	Vector_InitialAngularVelocity=6,
	Vector_LinearImpulse=7,
	Vector_TargetMax=8,
}
