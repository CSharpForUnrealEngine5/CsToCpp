namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specialization for property settings for tools that create a new actor and need to decide what to do with multiple input objects.</summary>
[CppInclude("PropertySets/OnAcceptProperties.h")]
public partial class UOnAcceptHandleSourcesProperties : UOnAcceptHandleSourcesPropertiesBase {
	public static UClass StaticClass() {return default;}
	///<summary>Defines what to do with the input objects when accepting the tool results.</summary>
	public EHandleSourcesMethod HandleInputs;
}
