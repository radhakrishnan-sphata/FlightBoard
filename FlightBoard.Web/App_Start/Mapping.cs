// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Mapping
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using AutoMapper;
using FlightBoard.Data;
using FlightBoard.Service.Business.DataModels;
using FlightBoard.Web.Models;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Web
{
    public class Mapping
    {
        public static void FBMapping()
        {
            ParameterExpression parameterExpression1;
            ParameterExpression parameterExpression2;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      //((IMappingExpression<RoleModel, fb_Roles>)Mapper.CreateMap<RoleModel, fb_Roles>()).ForMember((Expression<Func<fb_Roles, object>>)Expression.Lambda<Func<fb_Roles, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression1, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleId))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression1
      //}), (Action<IMemberConfigurationExpression<RoleModel>>)(u => u.MapFrom<int>((Expression<Func<RoleModel, M0>>)(m => m.RoleId)))).ForMember((Expression<Func<fb_Roles, object>>)Expression.Lambda<Func<fb_Roles, object>>((Expression)Expression.Property((Expression)parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
      //{
      //  parameterExpression2
      //}), (Action<IMemberConfigurationExpression<RoleModel>>)(u => u.MapFrom<string>((Expression<Func<RoleModel, M0>>)(m => m.RoleName))));
      //      ParameterExpression parameterExpression3;
      //      ParameterExpression parameterExpression4;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<fb_Roles, RoleModel>)Mapper.CreateMap<fb_Roles, RoleModel>()).ForMember((Expression<Func<RoleModel, object>>)(a => (object)a.RoleId), (Action<IMemberConfigurationExpression<fb_Roles>>)(u => u.MapFrom<int>((Expression<Func<fb_Roles, M0>>)Expression.Lambda<Func<fb_Roles, int>>((Expression)Expression.Property((Expression)parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleId))), new ParameterExpression[1]
      //{
      //  parameterExpression3
      //})))).ForMember((Expression<Func<RoleModel, object>>)(a => a.RoleName), (Action<IMemberConfigurationExpression<fb_Roles>>)(u => u.MapFrom<string>((Expression<Func<fb_Roles, M0>>)Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
      //{
      //  parameterExpression4
      //}))));
      //      Mapper.CreateMap<UserModel, fb_Users>();
      //      Mapper.CreateMap<fb_Users, UserModel>();
      //      Mapper.CreateMap<TeamModel, fb_Teams>();
      //      Mapper.CreateMap<fb_Teams, TeamModel>();
      //      Mapper.CreateMap<fb_Teams_View, fb_Teams_Data>();
      //      Mapper.CreateMap<fb_Teams_Data, fb_Teams_View>();
      //      Mapper.CreateMap<TeamMembersModel, fb_TeamMembers>();
      //      Mapper.CreateMap<fb_TeamMembers, TeamMembersModel>();
      //      ParameterExpression parameterExpression5;
      //      ParameterExpression parameterExpression6;
      //      ParameterExpression parameterExpression7;
      //      ParameterExpression parameterExpression8;
      //      ParameterExpression parameterExpression9;
      //      ParameterExpression parameterExpression10;
      //      ParameterExpression parameterExpression11;
      //      ParameterExpression parameterExpression12;
      //      ParameterExpression parameterExpression13;
      //      ParameterExpression parameterExpression14;
      //      ParameterExpression parameterExpression15;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<DashboardModel, fb_Events>)Mapper.CreateMap<DashboardModel, fb_Events>()).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression5, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventId))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression5
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<int>((Expression<Func<DashboardModel, M0>>)(m => m.EventId)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Property((Expression)parameterExpression6, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_Contract))), new ParameterExpression[1]
      //{
      //  parameterExpression6
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<string>((Expression<Func<DashboardModel, M0>>)(m => m.Contract)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Property((Expression)parameterExpression7, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventName))), new ParameterExpression[1]
      //{
      //  parameterExpression7
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<string>((Expression<Func<DashboardModel, M0>>)(m => m.EventName)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression8, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventDate))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression8
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<DateTime?>((Expression<Func<DashboardModel, M0>>)(m => m.EventDate)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Property((Expression)parameterExpression9, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_TeamLead))), new ParameterExpression[1]
      //{
      //  parameterExpression9
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<string>((Expression<Func<DashboardModel, M0>>)(m => m.TeamLead)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Property((Expression)parameterExpression10, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_UnitName))), new ParameterExpression[1]
      //{
      //  parameterExpression10
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<string>((Expression<Func<DashboardModel, M0>>)(m => m.UnitName)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression11, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_UnitId))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression11
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<int?>((Expression<Func<DashboardModel, M0>>)(m => m.UnitId)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Property((Expression)parameterExpression12, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_DateOfProduction))), new ParameterExpression[1]
      //{
      //  parameterExpression12
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<string>((Expression<Func<DashboardModel, M0>>)(m => m.ProdDate)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression13, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_FSSeventlist_intid))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression13
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<int>((Expression<Func<DashboardModel, M0>>)(m => m.ItemEvent_intid)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Property((Expression)parameterExpression14, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_Description))), new ParameterExpression[1]
      //{
      //  parameterExpression14
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<string>((Expression<Func<DashboardModel, M0>>)(m => m.Description)))).ForMember((Expression<Func<fb_Events, object>>)Expression.Lambda<Func<fb_Events, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression15, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventDate))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression15
      //}), (Action<IMemberConfigurationExpression<DashboardModel>>)(u => u.MapFrom<DateTime?>((Expression<Func<DashboardModel, M0>>)(m => m.EventDate))));
      //      ParameterExpression parameterExpression16;
      //      ParameterExpression parameterExpression17;
      //      ParameterExpression parameterExpression18;
      //      ParameterExpression parameterExpression19;
      //      ParameterExpression parameterExpression20;
      //      ParameterExpression parameterExpression21;
      //      ParameterExpression parameterExpression22;
      //      ParameterExpression parameterExpression23;
      //      ParameterExpression parameterExpression24;
      //      ParameterExpression parameterExpression25;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<fb_Events, DashboardModel>)Mapper.CreateMap<fb_Events, DashboardModel>()).ForMember((Expression<Func<DashboardModel, object>>)(a => a.Contract), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<string>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, string>>((Expression)Expression.Property((Expression)parameterExpression16, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_Contract))), new ParameterExpression[1]
      //{
      //  parameterExpression16
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => a.EventName), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<string>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, string>>((Expression)Expression.Property((Expression)parameterExpression17, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventName))), new ParameterExpression[1]
      //{
      //  parameterExpression17
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => (object)a.EventDate), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<DateTime?>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, DateTime?>>((Expression)Expression.Property((Expression)parameterExpression18, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventDate))), new ParameterExpression[1]
      //{
      //  parameterExpression18
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => a.TeamLead), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<string>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, string>>((Expression)Expression.Property((Expression)parameterExpression19, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_TeamLead))), new ParameterExpression[1]
      //{
      //  parameterExpression19
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => a.UnitName), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<string>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, string>>((Expression)Expression.Property((Expression)parameterExpression20, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_UnitName))), new ParameterExpression[1]
      //{
      //  parameterExpression20
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => (object)a.UnitId), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<int?>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, int?>>((Expression)Expression.Property((Expression)parameterExpression21, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_UnitId))), new ParameterExpression[1]
      //{
      //  parameterExpression21
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => a.ProdDate), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<string>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, string>>((Expression)Expression.Property((Expression)parameterExpression22, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_DateOfProduction))), new ParameterExpression[1]
      //{
      //  parameterExpression22
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => (object)a.ItemEvent_intid), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<int?>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, int?>>((Expression)Expression.Property((Expression)parameterExpression23, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_FSSeventlist_intid))), new ParameterExpression[1]
      //{
      //  parameterExpression23
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => a.Description), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<string>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, string>>((Expression)Expression.Property((Expression)parameterExpression24, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_Description))), new ParameterExpression[1]
      //{
      //  parameterExpression24
      //})))).ForMember((Expression<Func<DashboardModel, object>>)(a => (object)a.EventDate), (Action<IMemberConfigurationExpression<fb_Events>>)(u => u.MapFrom<DateTime?>((Expression<Func<fb_Events, M0>>)Expression.Lambda<Func<fb_Events, DateTime?>>((Expression)Expression.Property((Expression)parameterExpression25, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Events.get_EventDate))), new ParameterExpression[1]
      //{
      //  parameterExpression25
      //}))));
      //      ParameterExpression parameterExpression26;
      //      ParameterExpression parameterExpression27;
      //      ParameterExpression parameterExpression28;
      //      ParameterExpression parameterExpression29;
      //      ParameterExpression parameterExpression30;
      //      ParameterExpression parameterExpression31;
      //      ParameterExpression parameterExpression32;
      //      ParameterExpression parameterExpression33;
      //      ParameterExpression parameterExpression34;
      //      ParameterExpression parameterExpression35;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<ItemModel, fb_Items>)Mapper.CreateMap<ItemModel, fb_Items>()).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression26, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_ID))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression26
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<int>((Expression<Func<ItemModel, M0>>)(m => m.ID)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression27, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_Item_intid))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression27
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<int>((Expression<Func<ItemModel, M0>>)(m => m.ItemId)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Property((Expression)parameterExpression28, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_ItemName))), new ParameterExpression[1]
      //{
      //  parameterExpression28
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<string>((Expression<Func<ItemModel, M0>>)(m => m.ItemName)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression29, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_ItemEvent_intid))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression29
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<int>((Expression<Func<ItemModel, M0>>)(m => m.ItemEvent_intid)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression30, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_Quantity))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression30
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<Decimal?>((Expression<Func<ItemModel, M0>>)(m => m.Quantity)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression31, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_IsSubItem))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression31
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<bool>((Expression<Func<ItemModel, M0>>)(m => m.IsSubItem)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Property((Expression)parameterExpression32, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_UniQueItemIds))), new ParameterExpression[1]
      //{
      //  parameterExpression32
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<string>((Expression<Func<ItemModel, M0>>)(m => m.UniQueItemIds)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression33, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_HasSubItem))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression33
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<bool>((Expression<Func<ItemModel, M0>>)(m => m.HasSubItem)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression34, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_PrepAreaId))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression34
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<int?>((Expression<Func<ItemModel, M0>>)(m => m.PrepAreaId)))).ForMember((Expression<Func<fb_Items, object>>)Expression.Lambda<Func<fb_Items, object>>((Expression)Expression.Property((Expression)parameterExpression35, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_PrepAreaName))), new ParameterExpression[1]
      //{
      //  parameterExpression35
      //}), (Action<IMemberConfigurationExpression<ItemModel>>)(u => u.MapFrom<string>((Expression<Func<ItemModel, M0>>)(m => m.PrepAreaName))));
      //      ParameterExpression parameterExpression36;
      //      ParameterExpression parameterExpression37;
      //      ParameterExpression parameterExpression38;
      //      ParameterExpression parameterExpression39;
      //      ParameterExpression parameterExpression40;
      //      ParameterExpression parameterExpression41;
      //      ParameterExpression parameterExpression42;
      //      ParameterExpression parameterExpression43;
      //      ParameterExpression parameterExpression44;
      //      ParameterExpression parameterExpression45;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<fb_Items, ItemModel>)Mapper.CreateMap<fb_Items, ItemModel>()).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.ID), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<int>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, int>>((Expression)Expression.Property((Expression)parameterExpression36, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_ID))), new ParameterExpression[1]
      //{
      //  parameterExpression36
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.ItemId), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<int>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, int>>((Expression)Expression.Property((Expression)parameterExpression37, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_Item_intid))), new ParameterExpression[1]
      //{
      //  parameterExpression37
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => a.ItemName), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<string>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, string>>((Expression)Expression.Property((Expression)parameterExpression38, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_ItemName))), new ParameterExpression[1]
      //{
      //  parameterExpression38
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.Quantity), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<Decimal?>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, Decimal?>>((Expression)Expression.Property((Expression)parameterExpression39, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_Quantity))), new ParameterExpression[1]
      //{
      //  parameterExpression39
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.ItemEvent_intid), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<int>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, int>>((Expression)Expression.Property((Expression)parameterExpression40, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_ItemEvent_intid))), new ParameterExpression[1]
      //{
      //  parameterExpression40
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.IsSubItem), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<bool>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, bool>>((Expression)Expression.Property((Expression)parameterExpression41, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_IsSubItem))), new ParameterExpression[1]
      //{
      //  parameterExpression41
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => a.UniQueItemIds), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<string>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, string>>((Expression)Expression.Property((Expression)parameterExpression42, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_UniQueItemIds))), new ParameterExpression[1]
      //{
      //  parameterExpression42
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.HasSubItem), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<bool?>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, bool?>>((Expression)Expression.Property((Expression)parameterExpression43, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_HasSubItem))), new ParameterExpression[1]
      //{
      //  parameterExpression43
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => (object)a.PrepAreaId), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<int?>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, int?>>((Expression)Expression.Property((Expression)parameterExpression44, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_PrepAreaId))), new ParameterExpression[1]
      //{
      //  parameterExpression44
      //})))).ForMember((Expression<Func<ItemModel, object>>)(a => a.PrepAreaName), (Action<IMemberConfigurationExpression<fb_Items>>)(u => u.MapFrom<string>((Expression<Func<fb_Items, M0>>)Expression.Lambda<Func<fb_Items, string>>((Expression)Expression.Property((Expression)parameterExpression45, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Items.get_PrepAreaName))), new ParameterExpression[1]
      //{
      //  parameterExpression45
      //}))));
      //      Mapper.CreateMap<fb_Items_View, fb_Items_Data>();
      //      Mapper.CreateMap<fb_Items_Data, fb_Items_View>();
      //      ParameterExpression parameterExpression46;
      //      ParameterExpression parameterExpression47;
      //      ParameterExpression parameterExpression48;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<RefreshTimeModel, fb_RefreshTime>)Mapper.CreateMap<RefreshTimeModel, fb_RefreshTime>()).ForMember((Expression<Func<fb_RefreshTime, object>>)Expression.Lambda<Func<fb_RefreshTime, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression46, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_ID))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression46
      //}), (Action<IMemberConfigurationExpression<RefreshTimeModel>>)(u => u.MapFrom<int>((Expression<Func<RefreshTimeModel, M0>>)(m => m.ID)))).ForMember((Expression<Func<fb_RefreshTime, object>>)Expression.Lambda<Func<fb_RefreshTime, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression47, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_RefreshTime))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression47
      //}), (Action<IMemberConfigurationExpression<RefreshTimeModel>>)(u => u.MapFrom<DateTime>((Expression<Func<RefreshTimeModel, M0>>)(m => m.RefreshTime)))).ForMember((Expression<Func<fb_RefreshTime, object>>)Expression.Lambda<Func<fb_RefreshTime, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression48, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_NoOfNewRecords))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression48
      //}), (Action<IMemberConfigurationExpression<RefreshTimeModel>>)(u => u.MapFrom<int>((Expression<Func<RefreshTimeModel, M0>>)(m => m.NoOfNewRecords))));
      //      ParameterExpression parameterExpression49;
      //      ParameterExpression parameterExpression50;
      //      ParameterExpression parameterExpression51;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<fb_RefreshTime, RefreshTimeModel>)Mapper.CreateMap<fb_RefreshTime, RefreshTimeModel>()).ForMember((Expression<Func<RefreshTimeModel, object>>)(a => (object)a.ID), (Action<IMemberConfigurationExpression<fb_RefreshTime>>)(u => u.MapFrom<int>((Expression<Func<fb_RefreshTime, M0>>)Expression.Lambda<Func<fb_RefreshTime, int>>((Expression)Expression.Property((Expression)parameterExpression49, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_ID))), new ParameterExpression[1]
      //{
      //  parameterExpression49
      //})))).ForMember((Expression<Func<RefreshTimeModel, object>>)(a => (object)a.RefreshTime), (Action<IMemberConfigurationExpression<fb_RefreshTime>>)(u => u.MapFrom<DateTime>((Expression<Func<fb_RefreshTime, M0>>)Expression.Lambda<Func<fb_RefreshTime, DateTime>>((Expression)Expression.Property((Expression)parameterExpression50, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_RefreshTime))), new ParameterExpression[1]
      //{
      //  parameterExpression50
      //})))).ForMember((Expression<Func<RefreshTimeModel, object>>)(a => (object)a.NoOfNewRecords), (Action<IMemberConfigurationExpression<fb_RefreshTime>>)(u => u.MapFrom<int?>((Expression<Func<fb_RefreshTime, M0>>)Expression.Lambda<Func<fb_RefreshTime, int?>>((Expression)Expression.Property((Expression)parameterExpression51, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_NoOfNewRecords))), new ParameterExpression[1]
      //{
      //  parameterExpression51
      //}))));
      //      Mapper.CreateMap<AssignItemModel, AssignItem>();
      //      Mapper.CreateMap<AssignItem, AssignItemModel>();
      //      ParameterExpression parameterExpression52;
      //      ParameterExpression parameterExpression53;
      //      ParameterExpression parameterExpression54;
      //      ParameterExpression parameterExpression55;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<ProductionDatesModel, fb_ProductionDates>)Mapper.CreateMap<ProductionDatesModel, fb_ProductionDates>()).ForMember((Expression<Func<fb_ProductionDates, object>>)Expression.Lambda<Func<fb_ProductionDates, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression52, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_ID))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression52
      //}), (Action<IMemberConfigurationExpression<ProductionDatesModel>>)(u => u.MapFrom<int>((Expression<Func<ProductionDatesModel, M0>>)(m => m.ID)))).ForMember((Expression<Func<fb_ProductionDates, object>>)Expression.Lambda<Func<fb_ProductionDates, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression53, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_ItemId))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression53
      //}), (Action<IMemberConfigurationExpression<ProductionDatesModel>>)(u => u.MapFrom<int>((Expression<Func<ProductionDatesModel, M0>>)(m => m.ItemId)))).ForMember((Expression<Func<fb_ProductionDates, object>>)Expression.Lambda<Func<fb_ProductionDates, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression54, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_EventID))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression54
      //}), (Action<IMemberConfigurationExpression<ProductionDatesModel>>)(u => u.MapFrom<int>((Expression<Func<ProductionDatesModel, M0>>)(m => m.EventId)))).ForMember((Expression<Func<fb_ProductionDates, object>>)Expression.Lambda<Func<fb_ProductionDates, object>>((Expression)Expression.Convert((Expression)Expression.Property((Expression)parameterExpression55, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_ProdcutionDate))), typeof(object)), new ParameterExpression[1]
      //{
      //  parameterExpression55
      //}), (Action<IMemberConfigurationExpression<ProductionDatesModel>>)(u => u.MapFrom<DateTime>((Expression<Func<ProductionDatesModel, M0>>)(m => m.ProdcutionDate))));
      //      ParameterExpression parameterExpression56;
      //      ParameterExpression parameterExpression57;
      //      ParameterExpression parameterExpression58;
      //      ParameterExpression parameterExpression59;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      ((IMappingExpression<fb_ProductionDates, ProductionDatesModel>)Mapper.CreateMap<fb_ProductionDates, ProductionDatesModel>()).ForMember((Expression<Func<ProductionDatesModel, object>>)(a => (object)a.ID), (Action<IMemberConfigurationExpression<fb_ProductionDates>>)(u => u.MapFrom<int>((Expression<Func<fb_ProductionDates, M0>>)Expression.Lambda<Func<fb_ProductionDates, int>>((Expression)Expression.Property((Expression)parameterExpression56, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_ID))), new ParameterExpression[1]
      //{
      //  parameterExpression56
      //})))).ForMember((Expression<Func<ProductionDatesModel, object>>)(a => (object)a.ItemId), (Action<IMemberConfigurationExpression<fb_ProductionDates>>)(u => u.MapFrom<int>((Expression<Func<fb_ProductionDates, M0>>)Expression.Lambda<Func<fb_ProductionDates, int>>((Expression)Expression.Property((Expression)parameterExpression57, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_ItemId))), new ParameterExpression[1]
      //{
      //  parameterExpression57
      //})))).ForMember((Expression<Func<ProductionDatesModel, object>>)(a => (object)a.EventId), (Action<IMemberConfigurationExpression<fb_ProductionDates>>)(u => u.MapFrom<int>((Expression<Func<fb_ProductionDates, M0>>)Expression.Lambda<Func<fb_ProductionDates, int>>((Expression)Expression.Property((Expression)parameterExpression58, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_EventID))), new ParameterExpression[1]
      //{
      //  parameterExpression58
      //})))).ForMember((Expression<Func<ProductionDatesModel, object>>)(a => (object)a.ProdcutionDate), (Action<IMemberConfigurationExpression<fb_ProductionDates>>)(u => u.MapFrom<DateTime>((Expression<Func<fb_ProductionDates, M0>>)Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression)Expression.Property((Expression)parameterExpression59, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //{
      //  parameterExpression59
      //}))));
      //      Mapper.CreateMap<AssignedTeamModel, fb_AssignedTeam>();
      //      Mapper.CreateMap<fb_AssignedTeam, AssignedTeamModel>();
      //      Mapper.CreateMap<BatchModel, fb_Batches>();
      //      Mapper.CreateMap<fb_Batches, BatchModel>();
      //      Mapper.CreateMap<BatchItemModel, fb_BatchItems>();
      //      Mapper.CreateMap<fb_BatchItems, BatchItemModel>();
     }
    }
}
