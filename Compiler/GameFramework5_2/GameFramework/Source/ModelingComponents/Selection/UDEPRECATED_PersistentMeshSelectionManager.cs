namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDEPRECATED_PersistentMeshSelectionManager manages an active Mesh Selection.</summary>
[CppInclude("Selection/PersistentMeshSelectionManager.h")]
public partial class UDEPRECATED_PersistentMeshSelectionManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ParentContext</summary>
	public UInteractiveToolsContext ParentContext;
	///<summary>ActiveSelection_DEPRECATED</summary>
	public UDEPRECATED_PersistentMeshSelection ActiveSelection_DEPRECATED;
	///<summary>SelectionDisplay</summary>
	public UPreviewGeometry SelectionDisplay;
}
