#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Set a uniform vector value independently of the sample position.The output is equal to magnitude * direction</summary>
public partial class UUniformVector : UFieldNodeVector {
// UniformVector
	public UObject SetUniformVector(float Magnitude,FVector Direction) { return default; }
	public float Magnitude;
	public FVector Direction;
}
