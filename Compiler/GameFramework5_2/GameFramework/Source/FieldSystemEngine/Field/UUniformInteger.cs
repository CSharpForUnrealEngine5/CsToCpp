#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a uniform integer value independently of the sample position. The output is equal to magnitude</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UUniformInteger : UFieldNodeInt {
	///<summary>Set a uniform integer value independently of the sample position. The output is equal to magnitude</summary>
	public  UUniformInteger SetUniformInteger(int Magnitude) { return default; }
	///<summary>The field output will be equal the magnitude</summary>
	public int Magnitude;
}
