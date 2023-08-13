namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object to test deprecation of Python wrapped types.</summary>
[CppInclude("PyTest.h")]
public partial class UDEPRECATED_LegacyPyTestObject : UPyTestObject {
	public static UClass StaticClass() {return default;}
}
