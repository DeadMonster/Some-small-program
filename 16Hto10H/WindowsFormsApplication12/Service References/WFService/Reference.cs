﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication12.WFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WFService.IWFService")]
    public interface IWFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetAllDeviceOperate", ReplyAction="http://tempuri.org/IWFService/GetAllDeviceOperateResponse")]
        string GetAllDeviceOperate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetDeviceOperateByOperateID", ReplyAction="http://tempuri.org/IWFService/GetDeviceOperateByOperateIDResponse")]
        string GetDeviceOperateByOperateID(long operateID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetAllSystemOperate", ReplyAction="http://tempuri.org/IWFService/GetAllSystemOperateResponse")]
        string GetAllSystemOperate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetAllManageOperate", ReplyAction="http://tempuri.org/IWFService/GetAllManageOperateResponse")]
        string GetAllManageOperate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/AddPlan", ReplyAction="http://tempuri.org/IWFService/AddPlanResponse")]
        long AddPlan(string planModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/UpdatePlan", ReplyAction="http://tempuri.org/IWFService/UpdatePlanResponse")]
        bool UpdatePlan(string planModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/DeletePlan", ReplyAction="http://tempuri.org/IWFService/DeletePlanResponse")]
        bool DeletePlan(long planID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanListByPlanType", ReplyAction="http://tempuri.org/IWFService/GetPlanListByPlanTypeResponse")]
        string GetPlanListByPlanType(int planType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanByPlanID", ReplyAction="http://tempuri.org/IWFService/GetPlanByPlanIDResponse")]
        string GetPlanByPlanID(long planID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/AddDatePlan", ReplyAction="http://tempuri.org/IWFService/AddDatePlanResponse")]
        long AddDatePlan(string datePlanModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/UpdateDatePlan", ReplyAction="http://tempuri.org/IWFService/UpdateDatePlanResponse")]
        bool UpdateDatePlan(string datePlanModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetDatePlanByPlanID", ReplyAction="http://tempuri.org/IWFService/GetDatePlanByPlanIDResponse")]
        string GetDatePlanByPlanID(long planID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanRunRunStepByPlanID", ReplyAction="http://tempuri.org/IWFService/GetPlanRunRunStepByPlanIDResponse")]
        string GetPlanRunRunStepByPlanID(long planID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanRunByPlanID", ReplyAction="http://tempuri.org/IWFService/GetPlanRunByPlanIDResponse")]
        string GetPlanRunByPlanID(long planID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/AddPlanRun", ReplyAction="http://tempuri.org/IWFService/AddPlanRunResponse")]
        bool AddPlanRun(string PlanRunModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/UpdatePlanRun", ReplyAction="http://tempuri.org/IWFService/UpdatePlanRunResponse")]
        bool UpdatePlanRun(string PlanRunModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanRunStepByRunID", ReplyAction="http://tempuri.org/IWFService/GetPlanRunStepByRunIDResponse")]
        string GetPlanRunStepByRunID(long runID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/AddPlanRunStep", ReplyAction="http://tempuri.org/IWFService/AddPlanRunStepResponse")]
        bool AddPlanRunStep(string RunStepModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/UpdatePlanRunStep", ReplyAction="http://tempuri.org/IWFService/UpdatePlanRunStepResponse")]
        bool UpdatePlanRunStep(string RunStepModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetAllTaskHistory", ReplyAction="http://tempuri.org/IWFService/GetAllTaskHistoryResponse")]
        string GetAllTaskHistory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetTaskHistoryByExecutionUser", ReplyAction="http://tempuri.org/IWFService/GetTaskHistoryByExecutionUserResponse")]
        string GetTaskHistoryByExecutionUser(string ExecutionUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/AddTaskHistory", ReplyAction="http://tempuri.org/IWFService/AddTaskHistoryResponse")]
        bool AddTaskHistory(string TaskHistoryModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/UpdateTaskHistory", ReplyAction="http://tempuri.org/IWFService/UpdateTaskHistoryResponse")]
        bool UpdateTaskHistory(string TaskHistoryModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanCurrentStepByPlanType", ReplyAction="http://tempuri.org/IWFService/GetPlanCurrentStepByPlanTypeResponse")]
        string GetPlanCurrentStepByPlanType(int planType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWFService/GetPlanAndPlanRun", ReplyAction="http://tempuri.org/IWFService/GetPlanAndPlanRunResponse")]
        string GetPlanAndPlanRun(int planType, System.Nullable<System.DateTime> datetime, System.Nullable<System.DateTime> endtime, int currentStep);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWFServiceChannel : WindowsFormsApplication12.WFService.IWFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WFServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication12.WFService.IWFService>, WindowsFormsApplication12.WFService.IWFService {
        
        public WFServiceClient() {
        }
        
        public WFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAllDeviceOperate() {
            return base.Channel.GetAllDeviceOperate();
        }
        
        public string GetDeviceOperateByOperateID(long operateID) {
            return base.Channel.GetDeviceOperateByOperateID(operateID);
        }
        
        public string GetAllSystemOperate() {
            return base.Channel.GetAllSystemOperate();
        }
        
        public string GetAllManageOperate() {
            return base.Channel.GetAllManageOperate();
        }
        
        public long AddPlan(string planModel) {
            return base.Channel.AddPlan(planModel);
        }
        
        public bool UpdatePlan(string planModel) {
            return base.Channel.UpdatePlan(planModel);
        }
        
        public bool DeletePlan(long planID) {
            return base.Channel.DeletePlan(planID);
        }
        
        public string GetPlanListByPlanType(int planType) {
            return base.Channel.GetPlanListByPlanType(planType);
        }
        
        public string GetPlanByPlanID(long planID) {
            return base.Channel.GetPlanByPlanID(planID);
        }
        
        public long AddDatePlan(string datePlanModel) {
            return base.Channel.AddDatePlan(datePlanModel);
        }
        
        public bool UpdateDatePlan(string datePlanModel) {
            return base.Channel.UpdateDatePlan(datePlanModel);
        }
        
        public string GetDatePlanByPlanID(long planID) {
            return base.Channel.GetDatePlanByPlanID(planID);
        }
        
        public string GetPlanRunRunStepByPlanID(long planID) {
            return base.Channel.GetPlanRunRunStepByPlanID(planID);
        }
        
        public string GetPlanRunByPlanID(long planID) {
            return base.Channel.GetPlanRunByPlanID(planID);
        }
        
        public bool AddPlanRun(string PlanRunModel) {
            return base.Channel.AddPlanRun(PlanRunModel);
        }
        
        public bool UpdatePlanRun(string PlanRunModel) {
            return base.Channel.UpdatePlanRun(PlanRunModel);
        }
        
        public string GetPlanRunStepByRunID(long runID) {
            return base.Channel.GetPlanRunStepByRunID(runID);
        }
        
        public bool AddPlanRunStep(string RunStepModel) {
            return base.Channel.AddPlanRunStep(RunStepModel);
        }
        
        public bool UpdatePlanRunStep(string RunStepModel) {
            return base.Channel.UpdatePlanRunStep(RunStepModel);
        }
        
        public string GetAllTaskHistory() {
            return base.Channel.GetAllTaskHistory();
        }
        
        public string GetTaskHistoryByExecutionUser(string ExecutionUser) {
            return base.Channel.GetTaskHistoryByExecutionUser(ExecutionUser);
        }
        
        public bool AddTaskHistory(string TaskHistoryModel) {
            return base.Channel.AddTaskHistory(TaskHistoryModel);
        }
        
        public bool UpdateTaskHistory(string TaskHistoryModel) {
            return base.Channel.UpdateTaskHistory(TaskHistoryModel);
        }
        
        public string GetPlanCurrentStepByPlanType(int planType) {
            return base.Channel.GetPlanCurrentStepByPlanType(planType);
        }
        
        public string GetPlanAndPlanRun(int planType, System.Nullable<System.DateTime> datetime, System.Nullable<System.DateTime> endtime, int currentStep) {
            return base.Channel.GetPlanAndPlanRun(planType, datetime, endtime, currentStep);
        }
    }
}