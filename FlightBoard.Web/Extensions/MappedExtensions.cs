// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Extensions.MappedExtensions
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using AutoMapper;
using FlightBoard.Data;
using FlightBoard.Service.Business.DataModels;
using FlightBoard.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightBoard.Web.Extensions
{
    public static class MappedExtensions
    {
        public static IEnumerable<T> ToModels<N, T>(this IEnumerable<N> entities)
        {
            return Enumerable.AsEnumerable<T>(Enumerable.Select<N, T>(entities, (Func<N, T>)(x => MappedExtensions.ToModel<N, T>(x))));
        }

        public static T ToModel<N, T>(this N entity)
        {
            return Mapper.Map<N, T>(entity);
        }

        public static fb_Users ToEntity(this UserModel model)
        {
            //return (fb_Users)Mapper.Map<UserModel, fb_Users>((M0)model);
            return null;
        }

        public static UserModel ToModel(this fb_Users entity)
        {
          //  return (UserModel)Mapper.Map<fb_Users, UserModel>((M0)entity);
            return null;
        }

        public static fb_Roles ToEntity(this RoleModel model)
        {
            //return (fb_Roles)Mapper.Map<RoleModel, fb_Roles>((M0)model);
            return null;
        }

        public static RoleModel ToModel(this fb_Roles entity)
        {
           // return (RoleModel)Mapper.Map<fb_Roles, RoleModel>((M0)entity);
            return null;
        }

        public static fb_Teams ToEntity(this TeamModel model)
        {
            //return (fb_Teams)Mapper.Map<TeamModel, fb_Teams>((M0)model);
            return null;
        }

        public static TeamModel ToModel(this fb_Teams entity)
        {
            //return (TeamModel)Mapper.Map<fb_Teams, TeamModel>((M0)entity);
            return null;
        }

        public static fb_Teams_View ToModel(this fb_Teams_Data entity)
        {
            //return (fb_Teams_View)Mapper.Map<fb_Teams_Data, fb_Teams_View>((M0)entity);
            return null;
        }

        public static fb_TeamMembers ToEntity(this TeamMembersModel model)
        {
            //return (fb_TeamMembers)Mapper.Map<TeamMembersModel, fb_TeamMembers>((M0)model);
            return null;
        }

        public static TeamMembersModel ToModel(this fb_TeamMembers entity)
        {
            //return (TeamMembersModel)Mapper.Map<fb_TeamMembers, TeamMembersModel>((M0)entity);
            return null;
        }

        public static fb_Events ToEntity(this DashboardModel model)
        {
            //return (fb_Events)Mapper.Map<DashboardModel, fb_Events>((M0)model);
            return null;
        }

        public static DashboardModel ToModel(this fb_Events entity)
        {
            //return (DashboardModel)Mapper.Map<fb_Events, DashboardModel>((M0)entity);
            return null;
        }

        public static fb_Items ToEntity(this ItemModel model)
        {
            return null;
           // return (fb_Items)Mapper.Map<ItemModel, fb_Items>((M0)model);

        }

        public static ItemModel ToModel(this fb_Items entity)
        {
            //return (ItemModel)Mapper.Map<fb_Items, ItemModel>((M0)entity);
            return null;
        }

        public static fb_Items_View ToModel(this fb_Items_Data entity)
        {
           // return (fb_Items_View)Mapper.Map<fb_Items_Data, fb_Items_View>((M0)entity);
            return null;
        }

        public static fb_RefreshTime ToEntity(this RefreshTimeModel model)
        {
           // return (fb_RefreshTime)Mapper.Map<RefreshTimeModel, fb_RefreshTime>((M0)model);
            return null;
        }

        public static RefreshTimeModel ToModel(this fb_RefreshTime entity)
        {
            //return (RefreshTimeModel)Mapper.Map<fb_RefreshTime, RefreshTimeModel>((M0)entity);
            return null;
        }

        public static fb_AssignedTeam ToEntity(this AssignedTeamModel model)
        {
            //return (fb_AssignedTeam)Mapper.Map<AssignedTeamModel, fb_AssignedTeam>((M0)model);
            return null;
        }

        public static AssignedTeamModel ToModel(this fb_AssignedTeam entity)
        {
            //return (AssignedTeamModel)Mapper.Map<fb_AssignedTeam, AssignedTeamModel>((M0)entity);
            return null;
        }

        public static AssignItem ToEntity(this AssignItemModel model)
        {
            //return (AssignItem)Mapper.Map<AssignItemModel, AssignItem>((M0)model);
            return null;
        }

        public static AssignItemModel ToModel(this AssignItem entity)
        {
            //return (AssignItemModel)Mapper.Map<AssignItem, AssignItemModel>((M0)entity);
            return null;
        }

        public static fb_ProductionDates ToEntity(this ProductionDatesModel model)
        {
            //return (fb_ProductionDates)Mapper.Map<ProductionDatesModel, fb_ProductionDates>((M0)model);
            return null;
        }

        public static ProductionDatesModel ToModel(this fb_ProductionDates entity)
        {
            //return (ProductionDatesModel)Mapper.Map<fb_ProductionDates, ProductionDatesModel>((M0)entity);
            return null;
        }

        public static fb_Batches ToEntity(this BatchModel model)
        {
            //return (fb_Batches)Mapper.Map<BatchModel, fb_Batches>((M0)model);
            return null;
        }

        public static BatchModel ToModel(this fb_Batches entity)
        {
            //return (BatchModel)Mapper.Map<fb_Batches, BatchModel>((M0)entity);
            return null;
        }

        public static fb_BatchItems ToEntity(this BatchItemModel model)
        {
            //return (fb_BatchItems)Mapper.Map<BatchItemModel, fb_BatchItems>((M0)model);
            return null;
        }

        public static BatchItemModel ToModel(this fb_BatchItems entity)
        {
            //return (BatchItemModel)Mapper.Map<fb_BatchItems, BatchItemModel>((M0)entity);
            return null;
        }
    }
}
