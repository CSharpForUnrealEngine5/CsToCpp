namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filters an input collection based on data type.</summary>
[CppInclude("Elements/PCGFilterByType.h")]
public partial class UPCGFilterByTypeSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>TargetType</summary>
	public EPCGDataType TargetType;
}
