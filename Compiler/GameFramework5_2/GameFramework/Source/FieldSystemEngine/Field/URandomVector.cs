#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a random vector value independently of the sample position. The output is equal to magnitude * random direction</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class URandomVector : UFieldNodeVector {
	///<summary>Set a random vector value independently of the sample position. The output is equal to magnitude * random direction</summary>
	public  URandomVector SetRandomVector(float Magnitude) { return default; }
	///<summary>Magnitude of the random vector field</summary>
	public float Magnitude;
}
