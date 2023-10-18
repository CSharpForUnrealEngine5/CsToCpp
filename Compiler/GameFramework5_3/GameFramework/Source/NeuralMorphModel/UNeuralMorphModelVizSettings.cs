namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vizualization settings specific to this model.</summary>
[CppInclude("NeuralMorphModelVizSettings.h")]
public partial class UNeuralMorphModelVizSettings : UMLDeformerMorphModelVizSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The visualization mode for the masks.</summary>
	public ENeuralMorphMaskVizMode MaskVizMode;
}
