#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosEngineInterface.h")]
///<summary>Specifies angular degrees of freedom</summary>
public enum EAngularConstraintMotion {
	ACM_Free=0,
	ACM_Limited=1,
	ACM_Locked=2,
	ACM_MAX=3,
}
