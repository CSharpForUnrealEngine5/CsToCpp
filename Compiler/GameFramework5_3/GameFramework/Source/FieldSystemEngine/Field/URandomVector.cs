namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a random vector value independently of the sample position. The output is equal to magnitude * random direction</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class URandomVector : UFieldNodeVector {
	public static UClass StaticClass() {return default;}
	///<summary>Set a random vector value independently of the sample position. The output is equal to magnitude * random direction</summary>
	public URandomVector SetRandomVector(float Magnitude) { return default; }
	///<summary>Magnitude of the random vector field</summary>
	public float Magnitude;
}
