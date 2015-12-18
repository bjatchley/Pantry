﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pantry.Client.PantryServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PantryServices.IPantryService")]
    public interface IPantryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPantryService/GetRecipes", ReplyAction="http://tempuri.org/IPantryService/GetRecipesResponse")]
        System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Recipe> GetRecipes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPantryService/GetRecipes", ReplyAction="http://tempuri.org/IPantryService/GetRecipesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Recipe>> GetRecipesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPantryService/GetAccounts", ReplyAction="http://tempuri.org/IPantryService/GetAccountsResponse")]
        System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Account> GetAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPantryService/GetAccounts", ReplyAction="http://tempuri.org/IPantryService/GetAccountsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Account>> GetAccountsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPantryService/AddIngredientToPantry", ReplyAction="http://tempuri.org/IPantryService/AddIngredientToPantryResponse")]
        void AddIngredientToPantry(Pantry.Data.DTOs.AvailableIngredient accountIngredient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPantryService/AddIngredientToPantry", ReplyAction="http://tempuri.org/IPantryService/AddIngredientToPantryResponse")]
        System.Threading.Tasks.Task AddIngredientToPantryAsync(Pantry.Data.DTOs.AvailableIngredient accountIngredient);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPantryServiceChannel : Pantry.Client.PantryServices.IPantryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PantryServiceClient : System.ServiceModel.ClientBase<Pantry.Client.PantryServices.IPantryService>, Pantry.Client.PantryServices.IPantryService {
        
        public PantryServiceClient() {
        }
        
        public PantryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PantryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PantryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PantryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Recipe> GetRecipes() {
            return base.Channel.GetRecipes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Recipe>> GetRecipesAsync() {
            return base.Channel.GetRecipesAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Account> GetAccounts() {
            return base.Channel.GetAccounts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Pantry.Data.Models.Account>> GetAccountsAsync() {
            return base.Channel.GetAccountsAsync();
        }
        
        public void AddIngredientToPantry(Pantry.Data.DTOs.AvailableIngredient accountIngredient) {
            base.Channel.AddIngredientToPantry(accountIngredient);
        }
        
        public System.Threading.Tasks.Task AddIngredientToPantryAsync(Pantry.Data.DTOs.AvailableIngredient accountIngredient) {
            return base.Channel.AddIngredientToPantryAsync(accountIngredient);
        }
    }
}
