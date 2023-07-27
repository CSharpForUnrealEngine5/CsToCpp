#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceBase.h")]
///<summary>Struct that encompasses the most common types of data. This is the data payload</summary>
public partial struct FPlatformInterfaceData {
// PlatformInterfaceData
	public string DataName;
	public EPlatformInterfaceDataType Type;
	public int IntValue;
	public float FloatValue;
	public string StringValue;
	public UObject ObjectValue;
}
