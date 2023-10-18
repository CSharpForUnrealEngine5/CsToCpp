namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We need an actual UObject and UPROPERTY to use the property editor module and generate one of the</summary>
[CppInclude("Widgets/SUSDIntegrationsPanel.h")]
public partial class UUsdIntegrationsPanelPropertyDummy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Ideally these would be FSoftObjectPaths, but FPropertyEditorModule doesn&#39;t support generating</summary>
	public UObject AnimBPProperty;
	///<summary>ControlRigProperty</summary>
	public UObject ControlRigProperty;
}
