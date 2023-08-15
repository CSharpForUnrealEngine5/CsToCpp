namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataRenameElement.h")]
public partial class UPCGMetadataRenameSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>AttributeToRename</summary>
	public FName AttributeToRename;
	///<summary>NewAttributeName</summary>
	public FName NewAttributeName;
}
