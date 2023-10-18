namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object to allow testing of inheritance on Python wrapped types.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestChildObject : UPyTestObject {
	public static UClass StaticClass() {return default;}
}
