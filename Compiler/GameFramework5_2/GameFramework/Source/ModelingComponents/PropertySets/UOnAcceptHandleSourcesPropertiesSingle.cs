namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specialization for property settings for tools that create a new actor and need to decide what to do with a single input object.</summary>
[CppInclude("PropertySets/OnAcceptProperties.h")]
public partial class UOnAcceptHandleSourcesPropertiesSingle : UOnAcceptHandleSourcesPropertiesBase {
	public static UClass StaticClass() {return default;}
	///<summary>Defines what to do with the input object when accepting the tool results.</summary>
	public EHandleSourcesMethod HandleInputs;
}
