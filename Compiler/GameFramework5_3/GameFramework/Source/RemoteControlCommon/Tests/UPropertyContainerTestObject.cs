namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RCPropertyContainerTestData.h")]
public partial class UPropertyContainerTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bSomeBool</summary>
	public bool bSomeBool;
	///<summary>SomeUInt32</summary>
	public uint SomeUInt32;
	///<summary>SomeFloat</summary>
	public float SomeFloat;
	///<summary>SomeVector</summary>
	public FVector SomeVector;
	///<summary>SomeRotator</summary>
	public FRotator SomeRotator;
	///<summary>SomeClampedInt</summary>
	public int SomeClampedInt;
	///<summary>SomeClampedInt2</summary>
	public int SomeClampedInt2;
	///<summary>SomeUIClampedInt</summary>
	public int SomeUIClampedInt;
	///<summary>SomeClampedFloat</summary>
	public float SomeClampedFloat;
	///<summary>SomeUIClampedFloat</summary>
	public float SomeUIClampedFloat;
	///<summary>SomeClampedFloat2</summary>
	public float SomeClampedFloat2;
	///<summary>SomeString</summary>
	public string SomeString;
	///<summary>SomeText</summary>
	public FText SomeText;
	///<summary>SomeFloatArray</summary>
	public TArray<float> SomeFloatArray;
}
