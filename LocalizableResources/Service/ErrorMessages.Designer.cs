﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzurePack.VirtualMachineBackup.LocalizableResources.Service {
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
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzurePack.VirtualMachineBackup.LocalizableResources.Service.Erro" +
                            "rMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Cannot submit the protection job for virtual machine &apos;{0}&apos; as another virtual machine is already in the process of being protected for this subscription. Please try your request again later..
        /// </summary>
        public static string AnotherVirtualMachineAlreadyBeingAdded {
            get {
                return ResourceManager.GetString("AnotherVirtualMachineAlreadyBeingAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem deleting the backup server with ID &apos;{0}&apos;. Backup server has protection groups..
        /// </summary>
        public static string BackupServerHasProtectionGroups {
            get {
                return ResourceManager.GetString("BackupServerHasProtectionGroups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem backing up the virtual machine &apos;{0}&apos;..
        /// </summary>
        public static string BackupVirtualMachineFailed {
            get {
                return ResourceManager.GetString("BackupVirtualMachineFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem connecting to server &apos;{0}&apos;..
        /// </summary>
        public static string CannotConnectToServer {
            get {
                return ResourceManager.GetString("CannotConnectToServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem creating the backup server with name &apos;[0}&apos;. Azure subscription not found!.
        /// </summary>
        public static string CreateBackupServerFailedAzureSubscriptionNotFound {
            get {
                return ResourceManager.GetString("CreateBackupServerFailedAzureSubscriptionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem creating the backup server with name &apos;[0}&apos;. Azure subscription not ready!.
        /// </summary>
        public static string CreateBackupServerFailedAzureSubscriptionNotReady {
            get {
                return ResourceManager.GetString("CreateBackupServerFailedAzureSubscriptionNotReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem creating the backup server with name &apos;{0}&apos;. The server version, &apos;{1}&apos;, is not DPM 2012 R2 or higher (4.2.x)!.
        /// </summary>
        public static string CreateBackupServerFailedBadVersionNumber {
            get {
                return ResourceManager.GetString("CreateBackupServerFailedBadVersionNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem creating the backup server with name &apos;[0}&apos;. Group not found!.
        /// </summary>
        public static string CreateBackupServerFailedGroupNotFound {
            get {
                return ResourceManager.GetString("CreateBackupServerFailedGroupNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem creating the backup server with name &apos;[0}&apos;. A server by that name already registered!.
        /// </summary>
        public static string CreateBackupServerFailedNameInUse {
            get {
                return ResourceManager.GetString("CreateBackupServerFailedNameInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem creating the server group with name &apos;[0}&apos;..
        /// </summary>
        public static string CreateServerGroupFailed {
            get {
                return ResourceManager.GetString("CreateServerGroupFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem deleting the backup server with ID &apos;{0}&apos;. Backup server not found..
        /// </summary>
        public static string DeleteBackupServerNotFound {
            get {
                return ResourceManager.GetString("DeleteBackupServerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem deleting the server group with ID &apos;{0}&apos;. Group not found..
        /// </summary>
        public static string DeleteServerGroupNotFound {
            get {
                return ResourceManager.GetString("DeleteServerGroupNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a probem removing protection from a virtual machine..
        /// </summary>
        public static string DeleteVirtualMachineFailed {
            get {
                return ResourceManager.GetString("DeleteVirtualMachineFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription &apos;{0}&apos; is not in a valid subscription format. Subscriptions must be in GUID format..
        /// </summary>
        public static string InvalidSubscriptionFormat {
            get {
                return ResourceManager.GetString("InvalidSubscriptionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem retreiving the list of restore points. .
        /// </summary>
        public static string ListVirtualMachineRestorePointsFailed {
            get {
                return ResourceManager.GetString("ListVirtualMachineRestorePointsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem retrieving the list of protected virtual machines..
        /// </summary>
        public static string ListVirtualMachinesFailed {
            get {
                return ResourceManager.GetString("ListVirtualMachinesFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem setting up protection for virtual machine &apos;{0}&apos;. Protection group not found!.
        /// </summary>
        public static string NoProtectionGroupFound {
            get {
                return ResourceManager.GetString("NoProtectionGroupFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem restoring the virtual mahine &apos;{0}&apos;..
        /// </summary>
        public static string RestoreVirtualMachineFailed {
            get {
                return ResourceManager.GetString("RestoreVirtualMachineFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem deleting the server group with ID &apos;{0}&apos;. The group still has backup servers..
        /// </summary>
        public static string ServerGroupHasServers {
            get {
                return ResourceManager.GetString("ServerGroupHasServers", resourceCulture);
            }
        }
    }
}