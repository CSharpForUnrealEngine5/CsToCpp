namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FMaterialLayersFunctions are no longer treated as material parameters, so this should maybe be refactored at some point</summary>
[CppInclude("MaterialEditor/DEditorMaterialLayersParameterValue.h")]
public partial class UDEditorMaterialLayersParameterValue : UDEditorParameterValue {
	public static UClass StaticClass() {return default;}
	///<summary>ParameterValue</summary>
	public FMaterialLayersFunctions ParameterValue;
}
