﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoooooJu.WeChat.Core.SetUserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BoooooJu.Service.Core.Dal")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SignatureField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateTime {
            get {
                return this.CreateTimeField;
            }
            set {
                if ((this.CreateTimeField.Equals(value) != true)) {
                    this.CreateTimeField = value;
                    this.RaisePropertyChanged("CreateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Sex {
            get {
                return this.SexField;
            }
            set {
                if ((this.SexField.Equals(value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Signature {
            get {
                return this.SignatureField;
            }
            set {
                if ((object.ReferenceEquals(this.SignatureField, value) != true)) {
                    this.SignatureField = value;
                    this.RaisePropertyChanged("Signature");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SetUserService.ISetUser")]
    public interface ISetUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseSetDataOf_User/Insert", ReplyAction="http://tempuri.org/IBaseSetDataOf_User/InsertResponse")]
        BoooooJu.WeChat.Core.SetUserService.User Insert(BoooooJu.WeChat.Core.SetUserService.User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseSetDataOf_User/Insert", ReplyAction="http://tempuri.org/IBaseSetDataOf_User/InsertResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> InsertAsync(BoooooJu.WeChat.Core.SetUserService.User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseSetDataOf_User/DeleteByPrimaryKey", ReplyAction="http://tempuri.org/IBaseSetDataOf_User/DeleteByPrimaryKeyResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BoooooJu.WeChat.Core.SetUserService.User))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        bool DeleteByPrimaryKey(object[] keyValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseSetDataOf_User/DeleteByPrimaryKey", ReplyAction="http://tempuri.org/IBaseSetDataOf_User/DeleteByPrimaryKeyResponse")]
        System.Threading.Tasks.Task<bool> DeleteByPrimaryKeyAsync(object[] keyValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseSetDataOf_User/UpdateByPrimaryKey", ReplyAction="http://tempuri.org/IBaseSetDataOf_User/UpdateByPrimaryKeyResponse")]
        BoooooJu.WeChat.Core.SetUserService.User UpdateByPrimaryKey(BoooooJu.WeChat.Core.SetUserService.User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseSetDataOf_User/UpdateByPrimaryKey", ReplyAction="http://tempuri.org/IBaseSetDataOf_User/UpdateByPrimaryKeyResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> UpdateByPrimaryKeyAsync(BoooooJu.WeChat.Core.SetUserService.User t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByAccountName", ReplyAction="http://tempuri.org/ISetUser/RegisterByAccountNameResponse")]
        BoooooJu.WeChat.Core.SetUserService.User RegisterByAccountName(BoooooJu.WeChat.Core.SetUserService.User user, string accountName, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByAccountName", ReplyAction="http://tempuri.org/ISetUser/RegisterByAccountNameResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByAccountNameAsync(BoooooJu.WeChat.Core.SetUserService.User user, string accountName, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByCellPhone", ReplyAction="http://tempuri.org/ISetUser/RegisterByCellPhoneResponse")]
        BoooooJu.WeChat.Core.SetUserService.User RegisterByCellPhone(BoooooJu.WeChat.Core.SetUserService.User user, string cellPhone, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByCellPhone", ReplyAction="http://tempuri.org/ISetUser/RegisterByCellPhoneResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByCellPhoneAsync(BoooooJu.WeChat.Core.SetUserService.User user, string cellPhone, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByEmailAddress", ReplyAction="http://tempuri.org/ISetUser/RegisterByEmailAddressResponse")]
        BoooooJu.WeChat.Core.SetUserService.User RegisterByEmailAddress(BoooooJu.WeChat.Core.SetUserService.User user, string emailAddress, string pwsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByEmailAddress", ReplyAction="http://tempuri.org/ISetUser/RegisterByEmailAddressResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByEmailAddressAsync(BoooooJu.WeChat.Core.SetUserService.User user, string emailAddress, string pwsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByOpneId", ReplyAction="http://tempuri.org/ISetUser/RegisterByOpneIdResponse")]
        BoooooJu.WeChat.Core.SetUserService.User RegisterByOpneId(BoooooJu.WeChat.Core.SetUserService.User user, string opneId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/RegisterByOpneId", ReplyAction="http://tempuri.org/ISetUser/RegisterByOpneIdResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByOpneIdAsync(BoooooJu.WeChat.Core.SetUserService.User user, string opneId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByAccountName", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByAccountNameResponse")]
        BoooooJu.WeChat.Core.SetUserService.User AlterPswdByAccountName(string accountName, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByAccountName", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByAccountNameResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByAccountNameAsync(string accountName, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByCellPhone", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByCellPhoneResponse")]
        BoooooJu.WeChat.Core.SetUserService.User AlterPswdByCellPhone(string cellPhone, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByCellPhone", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByCellPhoneResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByCellPhoneAsync(string cellPhone, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByEmailAddress", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByEmailAddressResponse")]
        BoooooJu.WeChat.Core.SetUserService.User AlterPswdByEmailAddress(string emailAddress, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByEmailAddress", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByEmailAddressResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByEmailAddressAsync(string emailAddress, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByOpenId", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByOpenIdResponse")]
        BoooooJu.WeChat.Core.SetUserService.User AlterPswdByOpenId(string openId, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISetUser/AlterPswdByOpenId", ReplyAction="http://tempuri.org/ISetUser/AlterPswdByOpenIdResponse")]
        System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByOpenIdAsync(string openId, string pswd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISetUserChannel : BoooooJu.WeChat.Core.SetUserService.ISetUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SetUserClient : System.ServiceModel.ClientBase<BoooooJu.WeChat.Core.SetUserService.ISetUser>, BoooooJu.WeChat.Core.SetUserService.ISetUser {
        
        public SetUserClient() {
        }
        
        public SetUserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SetUserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SetUserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SetUserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User Insert(BoooooJu.WeChat.Core.SetUserService.User t) {
            return base.Channel.Insert(t);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> InsertAsync(BoooooJu.WeChat.Core.SetUserService.User t) {
            return base.Channel.InsertAsync(t);
        }
        
        public bool DeleteByPrimaryKey(object[] keyValues) {
            return base.Channel.DeleteByPrimaryKey(keyValues);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteByPrimaryKeyAsync(object[] keyValues) {
            return base.Channel.DeleteByPrimaryKeyAsync(keyValues);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User UpdateByPrimaryKey(BoooooJu.WeChat.Core.SetUserService.User t) {
            return base.Channel.UpdateByPrimaryKey(t);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> UpdateByPrimaryKeyAsync(BoooooJu.WeChat.Core.SetUserService.User t) {
            return base.Channel.UpdateByPrimaryKeyAsync(t);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User RegisterByAccountName(BoooooJu.WeChat.Core.SetUserService.User user, string accountName, string pswd) {
            return base.Channel.RegisterByAccountName(user, accountName, pswd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByAccountNameAsync(BoooooJu.WeChat.Core.SetUserService.User user, string accountName, string pswd) {
            return base.Channel.RegisterByAccountNameAsync(user, accountName, pswd);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User RegisterByCellPhone(BoooooJu.WeChat.Core.SetUserService.User user, string cellPhone, string pswd) {
            return base.Channel.RegisterByCellPhone(user, cellPhone, pswd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByCellPhoneAsync(BoooooJu.WeChat.Core.SetUserService.User user, string cellPhone, string pswd) {
            return base.Channel.RegisterByCellPhoneAsync(user, cellPhone, pswd);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User RegisterByEmailAddress(BoooooJu.WeChat.Core.SetUserService.User user, string emailAddress, string pwsd) {
            return base.Channel.RegisterByEmailAddress(user, emailAddress, pwsd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByEmailAddressAsync(BoooooJu.WeChat.Core.SetUserService.User user, string emailAddress, string pwsd) {
            return base.Channel.RegisterByEmailAddressAsync(user, emailAddress, pwsd);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User RegisterByOpneId(BoooooJu.WeChat.Core.SetUserService.User user, string opneId) {
            return base.Channel.RegisterByOpneId(user, opneId);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> RegisterByOpneIdAsync(BoooooJu.WeChat.Core.SetUserService.User user, string opneId) {
            return base.Channel.RegisterByOpneIdAsync(user, opneId);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User AlterPswdByAccountName(string accountName, string pswd) {
            return base.Channel.AlterPswdByAccountName(accountName, pswd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByAccountNameAsync(string accountName, string pswd) {
            return base.Channel.AlterPswdByAccountNameAsync(accountName, pswd);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User AlterPswdByCellPhone(string cellPhone, string pswd) {
            return base.Channel.AlterPswdByCellPhone(cellPhone, pswd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByCellPhoneAsync(string cellPhone, string pswd) {
            return base.Channel.AlterPswdByCellPhoneAsync(cellPhone, pswd);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User AlterPswdByEmailAddress(string emailAddress, string pswd) {
            return base.Channel.AlterPswdByEmailAddress(emailAddress, pswd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByEmailAddressAsync(string emailAddress, string pswd) {
            return base.Channel.AlterPswdByEmailAddressAsync(emailAddress, pswd);
        }
        
        public BoooooJu.WeChat.Core.SetUserService.User AlterPswdByOpenId(string openId, string pswd) {
            return base.Channel.AlterPswdByOpenId(openId, pswd);
        }
        
        public System.Threading.Tasks.Task<BoooooJu.WeChat.Core.SetUserService.User> AlterPswdByOpenIdAsync(string openId, string pswd) {
            return base.Channel.AlterPswdByOpenIdAsync(openId, pswd);
        }
    }
}
