﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LicenseHeaderManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LicenseHeaderManager.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add....
        /// </summary>
        public static string Add {
            get {
                return ResourceManager.GetString("Add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to After.
        /// </summary>
        public static string After {
            get {
                return ResourceManager.GetString("After", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to After selected command.
        /// </summary>
        public static string AfterCommand {
            get {
                return ResourceManager.GetString("AfterCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Before.
        /// </summary>
        public static string Before {
            get {
                return ResourceManager.GetString("Before", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Before selected command.
        /// </summary>
        public static string BeforeCommand {
            get {
                return ResourceManager.GetString("BeforeCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin.
        /// </summary>
        public static string Begin {
            get {
                return ResourceManager.GetString("Begin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin comment.
        /// </summary>
        public static string BeginComment {
            get {
                return ResourceManager.GetString("BeginComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin region.
        /// </summary>
        public static string BeginRegion {
            get {
                return ResourceManager.GetString("BeginRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        public static string Cancel {
            get {
                return ResourceManager.GetString("Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Int32 similar to 5.
        /// </summary>
        public static int Constant_DisplayNameLookup_TimeDifferenceInSecondsBeforeTooOld {
            get {
                object obj = ResourceManager.GetObject("Constant_DisplayNameLookup_TimeDifferenceInSecondsBeforeTooOld", resourceCulture);
                return ((int)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit....
        /// </summary>
        public static string Edit {
            get {
                return ResourceManager.GetString("Edit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End.
        /// </summary>
        public static string End {
            get {
                return ResourceManager.GetString("End", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End comment.
        /// </summary>
        public static string EndComment {
            get {
                return ResourceManager.GetString("EndComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End region.
        /// </summary>
        public static string EndRegion {
            get {
                return ResourceManager.GetString("EndRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file could not be created..
        /// </summary>
        public static string Error_CreatingFile {
            get {
                return ResourceManager.GetString("Error_CreatingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while parsing the file {0}.\nMake sure the comment syntax is correct..
        /// </summary>
        public static string Error_InvalidLicenseHeader {
            get {
                return ResourceManager.GetString("Error_InvalidLicenseHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide at least an extension and either a line comment or begin and end comment tags..
        /// </summary>
        public static string Error_LanguageInvalid {
            get {
                return ResourceManager.GetString("Error_LanguageInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No comment definitions found for {0} files.\nDo you want to add them to the configuration?.
        /// </summary>
        public static string Error_LanguageNotFound {
            get {
                return ResourceManager.GetString("Error_LanguageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No license header definition file found in following projects:\n\n{0}\n\nDo you want to add the default license header definition files automatically?.
        /// </summary>
        public static string Error_MulitpleProjectsNoLicenseHeaderFile {
            get {
                return ResourceManager.GetString("Error_MulitpleProjectsNoLicenseHeaderFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No license header definition file found in project {0}.\nDo you want to add a new file?.
        /// </summary>
        public static string Error_NoHeaderDefinition {
            get {
                return ResourceManager.GetString("Error_NoHeaderDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This extension currently has no header defined in the license header definition file\n .
        /// </summary>
        public static string Error_NoHeaderFound {
            get {
                return ResourceManager.GetString("Error_NoHeaderFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project has no license header file..
        /// </summary>
        public static string Error_NoLicenseHeaderFile {
            get {
                return ResourceManager.GetString("Error_NoLicenseHeaderFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Execute &apos;Add license header&apos; command.
        /// </summary>
        public static string Execute {
            get {
                return ResourceManager.GetString("Execute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension.
        /// </summary>
        public static string Extension {
            get {
                return ResourceManager.GetString("Extension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extensions.
        /// </summary>
        public static string Extensions {
            get {
                return ResourceManager.GetString("Extensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit....
        /// </summary>
        public static string FileHeaderTextEditButton {
            get {
                return ResourceManager.GetString("FileHeaderTextEditButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text for new license header definitions.
        /// </summary>
        public static string FileHeaderTextLabel {
            get {
                return ResourceManager.GetString("FileHeaderTextLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help.
        /// </summary>
        public static string Help {
            get {
                return ResourceManager.GetString("Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatically insert license headers in new files.
        /// </summary>
        public static string InsertInNewFiles {
            get {
                return ResourceManager.GetString("InsertInNewFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager.
        /// </summary>
        public static string LicenseHeaderManagerName {
            get {
                return ResourceManager.GetString("LicenseHeaderManagerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line.
        /// </summary>
        public static string Line {
            get {
                return ResourceManager.GetString("Line", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line Comment.
        /// </summary>
        public static string LineComment {
            get {
                return ResourceManager.GetString("LineComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can link the &apos;Add license header&apos; command to other commands so that it is automatically executed before or after them..
        /// </summary>
        public static string LinkedCommands {
            get {
                return ResourceManager.GetString("LinkedCommands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We could not update following linked files, because there is no license header definition file in their original project, or the original project is not part of this solution.\n\n{0}.
        /// </summary>
        public static string LinkedFileUpdateInformation {
            get {
                return ResourceManager.GetString("LinkedFileUpdateInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager.
        /// </summary>
        public static string NameOfThisExtension {
            get {
                return ResourceManager.GetString("NameOfThisExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK.
        /// </summary>
        public static string Ok {
            get {
                return ResourceManager.GetString("Ok", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove.
        /// </summary>
        public static string Remove {
            get {
                return ResourceManager.GetString("Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can specify a list of keywords separated by commas..
        /// </summary>
        public static string RequiredKeywordsTooltip {
            get {
                return ResourceManager.GetString("RequiredKeywordsTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search:.
        /// </summary>
        public static string Search {
            get {
                return ResourceManager.GetString("Search", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip expression.
        /// </summary>
        public static string SkipExpression {
            get {
                return ResourceManager.GetString("SkipExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some languages require special instructions at the very beginning of the file.\nXML-based languages need the &lt;?xml ... ?&gt; declaration for example. You can\ndefine a regular expression that identifies these instructions here so that the\nlicense header comment can be inserted after them, leaving the file valid.\n\nSee the online documentation on http://licensemanager.codeplex.com/\nfor more detailed information..
        /// </summary>
        public static string SkipExpressionHelp {
            get {
                return ResourceManager.GetString("SkipExpressionHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager has automatically updated its configuration to add SkipExpressions.\n\nPlease check your language settings if they were modified\nbefore the update.\n\nIf you added any XML-based languages, you might need to add\na SkipExpression..
        /// </summary>
        public static string Update_1_1_3 {
            get {
                return ResourceManager.GetString("Update_1_1_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager has automatically updated its configuration to add .config and .xsd.\n\nPlease check your language settings if they were modified\nbefore the update..
        /// </summary>
        public static string Update_1_3_1 {
            get {
                return ResourceManager.GetString("Update_1_3_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager has automatically updated its configuration\nto include settings for the default license header definition file..
        /// </summary>
        public static string Update_DefaultLicenseHeader_1_2_1 {
            get {
                return ResourceManager.GetString("Update_DefaultLicenseHeader_1_2_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager has automatically updated its configuration\nto fix the settings for C# and VB.NET regions.\n\nPlease check your language settings if they were modified\nbefore the update..
        /// </summary>
        public static string Update_RegionSettings_1_2_1 {
            get {
                return ResourceManager.GetString("Update_RegionSettings_1_2_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Header Manager has automatically updated its configuration\nto fix a problem with the SkipExpressions for XML, HTML (and similar), and JS files.\n\nPlease check your language settings if they were modified\nbefore the update..
        /// </summary>
        public static string Update_SkipExpressions_1_2_2 {
            get {
                return ResourceManager.GetString("Update_SkipExpressions_1_2_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Project {0}/{1}.
        /// </summary>
        public static string UpdateSolution {
            get {
                return ResourceManager.GetString("UpdateSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating files....
        /// </summary>
        public static string UpdatingFiles {
            get {
                return ResourceManager.GetString("UpdatingFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only remove comments containing at least one of the keywords below.
        /// </summary>
        public static string UseRequiredKeywords {
            get {
                return ResourceManager.GetString("UseRequiredKeywords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        public static string Warning {
            get {
                return ResourceManager.GetString("Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected license header definition file already exists in this project. It is not possible to add a link to an item that already exists in the project..
        /// </summary>
        public static string Warning_CantLinkItemInSameProject {
            get {
                return ResourceManager.GetString("Warning_CantLinkItemInSameProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The header definition for {0} files contains non-comment text.\nIf you insert this header, you will not be able to remove or replace the header automatically!\nDo you really want to add this header to the file?.
        /// </summary>
        public static string Warning_InvalidLicenseHeader {
            get {
                return ResourceManager.GetString("Warning_InvalidLicenseHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit default header definition.
        /// </summary>
        public static string WpfDefaultLicenseHeaderDialogTitle {
            get {
                return ResourceManager.GetString("WpfDefaultLicenseHeaderDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit language.
        /// </summary>
        public static string WpfLanguageDialogTitle {
            get {
                return ResourceManager.GetString("WpfLanguageDialogTitle", resourceCulture);
            }
        }
    }
}
