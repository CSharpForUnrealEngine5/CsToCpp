namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlDeltaAPITestData.h")]
public partial class URemoteControlDeltaAPITestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetInt32WithSetterValue</summary>
	public int GetInt32WithSetterValue() { return default; }
	///<summary>SetInt32WithSetterValue</summary>
	public void SetInt32WithSetterValue(int NewValue) {}
	///<summary>Int32Value</summary>
	public int Int32Value;
	///<summary>FloatValue</summary>
	public float FloatValue;
	///<summary>VectorValue</summary>
	public FVector VectorValue;
	///<summary>ColorValue</summary>
	public FLinearColor ColorValue;
	///<summary>StructValue</summary>
	public FRemoteControlDeltaAPITestStruct StructValue;
	///<summary>Int32WithSetterValue</summary>
	public int Int32WithSetterValue;
	///<summary>Uses Setter - not BlueprintSetter</summary>
	public float FloatWithSetterValue;
}
