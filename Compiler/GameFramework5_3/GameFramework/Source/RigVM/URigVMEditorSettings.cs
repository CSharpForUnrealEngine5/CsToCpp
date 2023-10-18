namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Customize RigVM Rig Editor.</summary>
[CppInclude("RigVMSettings.h")]
public partial class URigVMEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>When this is checked mutable nodes (nodes with an execute pin)</summary>
	public bool bAutoLinkMutableNodes;
}
