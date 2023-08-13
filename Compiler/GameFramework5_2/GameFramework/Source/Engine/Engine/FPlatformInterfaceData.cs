namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that encompasses the most common types of data. This is the data payload</summary>
[CppInclude("Engine/PlatformInterfaceBase.h")]
public partial struct FPlatformInterfaceData {
	public string DataName;
	public EPlatformInterfaceDataType Type;
	public int IntValue;
	public float FloatValue;
	public string StringValue;
	public UObject ObjectValue;
}
