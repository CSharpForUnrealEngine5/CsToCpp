namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The selected render grid jobs.</summary>
[CppInclude("Toolkit/RenderGridEditor.h")]
public partial class URenderGridJobSelection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The GUIDs of the currently selected render grid jobs.</summary>
	public TSet<FGuid> SelectedRenderGridJobIds;
}
