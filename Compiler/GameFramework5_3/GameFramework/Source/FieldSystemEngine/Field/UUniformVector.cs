namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a uniform vector value independently of the sample position.The output is equal to magnitude * direction</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UUniformVector : UFieldNodeVector {
	public static UClass StaticClass() {return default;}
	///<summary>Set a uniform vector value independently of the sample position.The output is equal to magnitude * direction</summary>
	public UUniformVector SetUniformVector(float Magnitude,FVector Direction) { return default; }
	///<summary>Magnitude of the uniform vector field</summary>
	public float Magnitude;
	///<summary>Normalized direction of the uniform vector field</summary>
	public FVector Direction;
}
