namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UInteractiveTool contains a set of UObjects that contain &quot;properties&quot; of the Tool, ie</summary>
[CppInclude("InteractiveTool.h")]
public partial class UInteractiveToolPropertySet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CachedPropertiesMap</summary>
	public TMap<string,UInteractiveToolPropertySet> CachedPropertiesMap;
	///<summary>Controls whether a property set is shown in the UI.  Transient so that disabling a PropertySet in one tool doesn&#39;t disable it in others.</summary>
	public bool bIsPropertySetEnabled;
}
