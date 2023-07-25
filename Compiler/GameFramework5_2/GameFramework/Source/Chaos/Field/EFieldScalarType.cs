#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemTypes.h")]
public enum EFieldScalarType {
	Scalar_ExternalClusterStrain=0,
	Scalar_Kill=1,
	Scalar_DisableThreshold=2,
	Scalar_SleepingThreshold=3,
	Scalar_InternalClusterStrain=4,
	Scalar_DynamicConstraint=5,
	Scalar_TargetMax=6,
}
