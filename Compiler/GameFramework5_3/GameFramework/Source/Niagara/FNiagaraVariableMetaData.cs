namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraVariableMetaData {
	public FText Description;
	public FText CategoryName;
	public EUnit DisplayUnit;
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
	public TMap<FName,string> PropertyMetaData;
	public FName ParentAttribute;
	public TArray<FName> AlternateAliases;
	public FNiagaraInputParameterCustomization WidgetCustomization;
	public FGuid VariableGuid;
	public bool bIsStaticSwitch_DEPRECATED;
	public int StaticSwitchDefaultValue_DEPRECATED;
}
