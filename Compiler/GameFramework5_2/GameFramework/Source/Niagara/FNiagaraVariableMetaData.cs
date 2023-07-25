#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraVariableMetaData {
// NiagaraVariableMetaData
	public string Description;
	public string CategoryName;
	public bool bAdvancedDisplay;
	public bool bDisplayInOverviewStack;
	public int InlineParameterSortPriority;
	public bool bOverrideColor;
	public FLinearColor InlineParameterColorOverride;
	public TArray<FNiagaraEnumParameterMetaData> InlineParameterEnumOverrides;
	public bool bEnableBoolOverride;
	public FNiagaraBoolParameterMetaData InlineParameterBoolOverride;
	public int EditorSortPriority;
	public bool bInlineEditConditionToggle;
	public FNiagaraInputConditionMetadata EditCondition;
	public FNiagaraInputConditionMetadata VisibleCondition;
	public TMap<string,string> PropertyMetaData;
	public string ParentAttribute;
	public TArray<string> AlternateAliases;
	public FGuid VariableGuid;
	public bool bIsStaticSwitch_DEPRECATED;
	public int StaticSwitchDefaultValue_DEPRECATED;
}
