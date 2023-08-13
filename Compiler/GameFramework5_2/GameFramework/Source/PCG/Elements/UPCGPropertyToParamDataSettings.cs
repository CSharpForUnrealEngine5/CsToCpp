namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extract a property value from an actor/component into a ParamData.</summary>
[CppInclude("Elements/PCGPropertyToParamData.h")]
public partial class UPCGPropertyToParamDataSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>ActorSelector</summary>
	public FPCGActorSelectorSettings ActorSelector;
	///<summary>Allow to look for an actor component instead of an actor. It will need to be attached to the found actor.</summary>
	public bool bSelectComponent;
	///<summary>If we are looking for an actor component, the class can be specified here.</summary>
	public UClass ComponentClass;
	///<summary>Property name to extract. Can only extract properties that are compatible with metadata types.</summary>
	public string PropertyName;
	///<summary>If the property is a struct/object unsupported by metadata, this option can be toggled to extract all (compatible) properties contained in this property. For now, only supports direct child properties (and not deeper).</summary>
	public bool bExtractObjectAndStruct;
	///<summary>By default, attribute name will be the property name, but it can be overridden by this name.</summary>
	public string OutputAttributeName;
	///<summary>If this is true, we will never put this element in cache, and will always try to re-query the actors and read the latest properties from them.</summary>
	public bool bAlwaysRequeryActors;
	///<summary>If this is checked, found actors that are outside component bounds will not trigger a refresh. Only works for tags for now in editor.</summary>
	public bool bTrackActorsOnlyWithinBounds;
	///<summary>ActorSelection_DEPRECATED</summary>
	public EPCGActorSelection ActorSelection_DEPRECATED;
	///<summary>ActorSelectionTag_DEPRECATED</summary>
	public string ActorSelectionTag_DEPRECATED;
	///<summary>ActorSelectionName_DEPRECATED</summary>
	public string ActorSelectionName_DEPRECATED;
	///<summary>ActorSelectionClass_DEPRECATED</summary>
	public UClass ActorSelectionClass_DEPRECATED;
	///<summary>ActorFilter_DEPRECATED</summary>
	public EPCGActorFilter ActorFilter_DEPRECATED;
	///<summary>bIncludeChildren_DEPRECATED</summary>
	public bool bIncludeChildren_DEPRECATED;
}
