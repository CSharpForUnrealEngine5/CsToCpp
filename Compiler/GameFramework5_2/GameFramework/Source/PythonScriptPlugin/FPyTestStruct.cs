#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to allow testing of the various UStruct features that are exposed to Python wrapped types.</summary>
[CppInclude("PyTest.h")]
public partial struct FPyTestStruct {
	public bool Bool;
	public int Int;
	public float Float;
	public EPyTestEnum Enum;
	public string String;
	public string Name;
	public string Text;
	public object FieldPath;
	public object StructFieldPath;
	public TArray<string> StringArray;
	public TSet<string> StringSet;
	public TMap<string,int> StringIntMap;
	public int LegacyInt_DEPRECATED;
	public bool BoolInstanceOnly;
	public bool BoolDefaultsOnly;
	public bool BoolMutable;
}
