﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EWSEditor.Settings.Internals {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class UserSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserSettings defaultInstance = ((UserSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserSettings())));
        
        public static UserSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DebugOutputFile {
            get {
                return ((string)(this["DebugOutputFile"]));
            }
            set {
                this["DebugOutputFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShouldSaveDebugOutput {
            get {
                return ((bool)(this["ShouldSaveDebugOutput"]));
            }
            set {
                this["ShouldSaveDebugOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowSplash {
            get {
                return ((bool)(this["ShowSplash"]));
            }
            set {
                this["ShowSplash"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowAutodiscoverRedirect {
            get {
                return ((bool)(this["AllowAutodiscoverRedirect"]));
            }
            set {
                this["AllowAutodiscoverRedirect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int DumpFolderViewSize {
            get {
                return ((int)(this["DumpFolderViewSize"]));
            }
            set {
                this["DumpFolderViewSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int FindItemViewSize {
            get {
                return ((int)(this["FindItemViewSize"]));
            }
            set {
                this["FindItemViewSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int FindFolderViewSize {
            get {
                return ((int)(this["FindFolderViewSize"]));
            }
            set {
                this["FindFolderViewSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int CalendarViewSize {
            get {
                return ((int)(this["CalendarViewSize"]));
            }
            set {
                this["CalendarViewSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableSslDetailLogging {
            get {
                return ((bool)(this["EnableSslDetailLogging"]));
            }
            set {
                this["EnableSslDetailLogging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EWSEditor")]
        public string UserAgent {
            get {
                return ((string)(this["UserAgent"]));
            }
            set {
                this["UserAgent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableScpLookups {
            get {
                return ((bool)(this["EnableScpLookups"]));
            }
            set {
                this["EnableScpLookups"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OverrideCertValidation {
            get {
                return ((bool)(this["OverrideCertValidation"]));
            }
            set {
                this["OverrideCertValidation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100000")]
        public int Timeout {
            get {
                return ((int)(this["Timeout"]));
            }
            set {
                this["Timeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OverrideTimeout {
            get {
                return ((bool)(this["OverrideTimeout"]));
            }
            set {
                this["OverrideTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PreAuthenticate {
            get {
                return ((bool)(this["PreAuthenticate"]));
            }
            set {
                this["PreAuthenticate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OverrideTimezone {
            get {
                return ((bool)(this["OverrideTimezone"]));
            }
            set {
                this["OverrideTimezone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedTimeZoneId {
            get {
                return ((string)(this["SelectedTimeZoneId"]));
            }
            set {
                this["SelectedTimeZoneId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string ProxyServerName {
            get {
                return ((string)(this["ProxyServerName"]));
            }
            set {
                this["ProxyServerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8888")]
        public int ProxyServerPort {
            get {
                return ((int)(this["ProxyServerPort"]));
            }
            set {
                this["ProxyServerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyServerUser {
            get {
                return ((string)(this["ProxyServerUser"]));
            }
            set {
                this["ProxyServerUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyServerPassword {
            get {
                return ((string)(this["ProxyServerPassword"]));
            }
            set {
                this["ProxyServerPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyServerDomain {
            get {
                return ((string)(this["ProxyServerDomain"]));
            }
            set {
                this["ProxyServerDomain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpecifyProxySettings {
            get {
                return ((bool)(this["SpecifyProxySettings"]));
            }
            set {
                this["SpecifyProxySettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OverrideProxyCredentials {
            get {
                return ((bool)(this["OverrideProxyCredentials"]));
            }
            set {
                this["OverrideProxyCredentials"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SetDefaultProxy {
            get {
                return ((bool)(this["SetDefaultProxy"]));
            }
            set {
                this["SetDefaultProxy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BypassProxyForLocalAddress {
            get {
                return ((bool)(this["BypassProxyForLocalAddress"]));
            }
            set {
                this["BypassProxyForLocalAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddTimeZoneContext {
            get {
                return ((bool)(this["AddTimeZoneContext"]));
            }
            set {
                this["AddTimeZoneContext"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedTimeZoneContextId {
            get {
                return ((string)(this["SelectedTimeZoneContextId"]));
            }
            set {
                this["SelectedTimeZoneContextId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableAdditionalHeader1 {
            get {
                return ((bool)(this["EnableAdditionalHeader1"]));
            }
            set {
                this["EnableAdditionalHeader1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalHeader1 {
            get {
                return ((string)(this["AdditionalHeader1"]));
            }
            set {
                this["AdditionalHeader1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalHeaderValue1 {
            get {
                return ((string)(this["AdditionalHeaderValue1"]));
            }
            set {
                this["AdditionalHeaderValue1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableAdditionalHeader2 {
            get {
                return ((bool)(this["EnableAdditionalHeader2"]));
            }
            set {
                this["EnableAdditionalHeader2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalHeader2 {
            get {
                return ((string)(this["AdditionalHeader2"]));
            }
            set {
                this["AdditionalHeader2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalHeaderValue2 {
            get {
                return ((string)(this["AdditionalHeaderValue2"]));
            }
            set {
                this["AdditionalHeaderValue2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableAdditionalHeader3 {
            get {
                return ((bool)(this["EnableAdditionalHeader3"]));
            }
            set {
                this["EnableAdditionalHeader3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalHeader3 {
            get {
                return ((string)(this["AdditionalHeader3"]));
            }
            set {
                this["AdditionalHeader3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalHeaderValue3 {
            get {
                return ((string)(this["AdditionalHeaderValue3"]));
            }
            set {
                this["AdditionalHeaderValue3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogSecurityToken {
            get {
                return ((bool)(this["LogSecurityToken"]));
            }
            set {
                this["LogSecurityToken"] = value;
            }
        }
    }
}
