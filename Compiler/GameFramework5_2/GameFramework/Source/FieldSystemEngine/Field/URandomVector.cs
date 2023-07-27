#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Set a random vector value independently of the sample position. The output is equal to magnitude * random direction</summary>
public partial class URandomVector : UFieldNodeVector {
// RandomVector
	public  URandomVector SetRandomVector(float Magnitude) { return default; }
	public float Magnitude;
}
