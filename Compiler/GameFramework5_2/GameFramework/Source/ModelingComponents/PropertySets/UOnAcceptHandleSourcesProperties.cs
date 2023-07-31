#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specialization for property settings for tools that create a new actor and need to decide what to do with multiple input objects.</summary>
[CppInclude("PropertySets/OnAcceptProperties.h")]
public partial class UOnAcceptHandleSourcesProperties : UOnAcceptHandleSourcesPropertiesBase {
	///<summary>Defines what to do with the input objects when accepting the tool results.</summary>
	public EHandleSourcesMethod HandleInputs;
}
