#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a uniform vector value independently of the sample position.The output is equal to magnitude * direction</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UUniformVector : UFieldNodeVector {
	///<summary>Set a uniform vector value independently of the sample position.The output is equal to magnitude * direction</summary>
	public  UUniformVector SetUniformVector(float Magnitude,FVector Direction) { return default; }
	///<summary>Magnitude of the uniform vector field</summary>
	public float Magnitude;
	///<summary>Normalized direction of the uniform vector field</summary>
	public FVector Direction;
}
