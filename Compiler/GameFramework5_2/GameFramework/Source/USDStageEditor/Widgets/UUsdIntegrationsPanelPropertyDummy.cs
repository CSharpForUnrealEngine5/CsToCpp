#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We need an actual UObject and UPROPERTY to use the property editor module and generate one of the</summary>
[CppInclude("Widgets/SUSDIntegrationsPanel.h")]
public partial class UUsdIntegrationsPanelPropertyDummy : UObject {
	///<summary>Ideally these would be FSoftObjectPaths, but FPropertyEditorModule doesn&#39;t support generating</summary>
	public UObject AnimBPProperty;
	///<summary>ControlRigProperty</summary>
	public UObject ControlRigProperty;
}
