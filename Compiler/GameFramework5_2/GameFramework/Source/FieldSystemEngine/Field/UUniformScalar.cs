namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a uniform scalar value independently of the sample position. The output is equal to magnitude</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UUniformScalar : UFieldNodeFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Set a uniform scalar value independently of the sample position. The output is equal to magnitude</summary>
	public UUniformScalar SetUniformScalar(float Magnitude) { return default; }
	///<summary>The field output will be equal the magnitude</summary>
	public float Magnitude;
}
