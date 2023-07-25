#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveTool.h")]
///<summary>A UInteractiveTool contains a set of UObjects that contain "properties" of the Tool, ie</summary>
public partial class UInteractiveToolPropertySet : UObject {
// InteractiveToolPropertySet
	public TMap<string,UInteractiveToolPropertySet> CachedPropertiesMap;
	public bool bIsPropertySetEnabled;
}
