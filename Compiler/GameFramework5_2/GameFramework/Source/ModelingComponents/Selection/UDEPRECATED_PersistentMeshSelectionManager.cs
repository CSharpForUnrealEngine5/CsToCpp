#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDEPRECATED_PersistentMeshSelectionManager manages an active Mesh Selection.</summary>
[CppInclude("Selection/PersistentMeshSelectionManager.h")]
public partial class UDEPRECATED_PersistentMeshSelectionManager : UObject {
	///<summary>ParentContext</summary>
	public UInteractiveToolsContext ParentContext;
	///<summary>ActiveSelection_DEPRECATED</summary>
	public UDEPRECATED_PersistentMeshSelection ActiveSelection_DEPRECATED;
	///<summary>SelectionDisplay</summary>
	public UPreviewGeometry SelectionDisplay;
}
