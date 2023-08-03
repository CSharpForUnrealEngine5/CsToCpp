#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CSVtoSVGArguments.h")]
public partial class UCSVtoSVGArugments : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies a list of CSVs separated by spaces</summary>
	public FFilePath CSV;
	///<summary>Sets the filename for the SVG output.</summary>
	public FDirectoryPath OutputDirectory;
	///<summary>Sets the filename for the SVG output.</summary>
	public string OutputFilename;
	///<summary>Skips a specified number of rows in the CSV. This is useful for CSV file sgenerated from the FPSChartStart command, where there&#39;s a 4-row summary at the top.</summary>
	public int skipRows;
	///<summary>Clamps the X and Y range of the source data.</summary>
	public float minX;
	///<summary>Clamps the X and Y range of the source data.</summary>
	public float maxX;
	///<summary>Clamps the X and Y range of the source data.</summary>
	public float minY;
	///<summary>Clamps the X and Y range of the source data.</summary>
	public float maxY;
	///<summary>Smooth the graph.</summary>
	public bool smooth;
	///<summary>Specifies the smoothing kernel size in column entries to use.</summary>
	public int smoothKernelSize;
	///<summary>Specifies the smoothing kernel size as a percentage of the graph length.</summary>
	public float smoothKernelPercent;
	///<summary>The width of the graph.</summary>
	public int width;
	///<summary>The height of the graph.</summary>
	public int height;
	///<summary>Sets the title for the graph.</summary>
	public string title;
	///<summary>noMetadata</summary>
	public bool noMetadata;
	///<summary>Render just the graph, no borders.</summary>
	public bool graphOnly;
	///<summary>Sets the budget line. Default is 33.3.</summary>
	public float budget;
	///<summary>Sets the line thickness of the graph.</summary>
	public float thickness;
	///<summary>theme</summary>
	public ESVGTheme theme;
	///<summary>Ignores stats which are entirely under this threshold.</summary>
	public float threshold;
	///<summary>Makes a stacked graph for cumulative stats.</summary>
	public bool stacked;
	///<summary>Specifies the total stat. Valid for stacked graphs only.</summary>
	public string stacktotalstack;
	///<summary>Adds an interactive frame marker.</summary>
	public bool interactive;
	///<summary>Shows stat averages next to the legend and sorts the stats in the legend high to low by average value.</summary>
	public bool showaverages;
	///<summary>Rotates the colours.</summary>
	public int colourOffset;
	///<summary>Ignores stats whose average is under this threshold.</summary>
	public float averageThreshold;
}
