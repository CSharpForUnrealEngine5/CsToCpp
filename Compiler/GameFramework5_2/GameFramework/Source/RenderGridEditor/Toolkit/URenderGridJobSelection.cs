#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The selected render grid jobs.</summary>
[CppInclude("Toolkit/RenderGridEditor.h")]
public partial class URenderGridJobSelection : UObject {
	///<summary>The GUIDs of the currently selected render grid jobs.</summary>
	public TSet<FGuid> SelectedRenderGridJobIds;
}
