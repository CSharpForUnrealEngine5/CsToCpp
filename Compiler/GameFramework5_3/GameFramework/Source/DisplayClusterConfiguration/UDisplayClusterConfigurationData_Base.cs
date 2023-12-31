namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>All configuration UObjects should inherit from this class.</summary>
[CppInclude("DisplayClusterConfigurationTypes_Base.h")]
public partial class UDisplayClusterConfigurationData_Base : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ExportedObjects</summary>
	public TArray<UObject> ExportedObjects;
}
